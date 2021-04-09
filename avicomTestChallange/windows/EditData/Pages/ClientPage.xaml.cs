using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace avicomTestChallange.windows.EditData.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    /// 
    public partial class ClientPage : Page
    {
        //подключение к бд
        string conn = "Data Source=DESKTOP-5QF6I54;" +
                            "Initial Catalog=SoftTradePlus;" +
                            "Integrated Security=True";
        SqlDataAdapter adapter;
        DataTable ClientTable;
        int curid;
        public ClientPage()
        {
            InitializeComponent();
        }

        //Отправление запроса к БД и получение ответа
        private void Query(SqlConnection connection, SqlCommand cmd, out DataTable ReturnTable)
        {
            ReturnTable = new DataTable();
            try
            {
                adapter = new SqlDataAdapter(cmd);
                connection.Open();
                adapter.Fill(ReturnTable);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

        }

        //обновление значений датагрида
        private void UpdateGrid()
        {
            //наистраиваем запрос
            string sql = "SELECT c.id, c.name, c.status, m.name AS 'manager' FROM Clients AS c, Managers AS m " +
                            "WHERE c.manager = m.id";
            ClientTable = new DataTable();
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand(sql, connection);
            DataTable QueryResult;
            //выполнение запроса
            Query(connection, cmd, out QueryResult);
            //загрузка новых данных в датагрид
            Clients.ItemsSource = QueryResult.DefaultView;

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //настраиваем запрос к БД
            string managerReq = "SELECT * FROM Managers";
            string statusReq = "SELECT * FROM ClientStatus";
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand(managerReq, connection);
            SqlCommand cmd1 = new SqlCommand(statusReq, connection);
            DataTable man = new DataTable();
            DataTable stat = new DataTable();

            //получаем имена менеджеров и заполняем ими комбобокс
            Query(connection, cmd, out man);
            for (int i = 0; i < man.Rows.Count; i++)
            {
                ClientManager.Items.Add(man.Rows[i][1]);
            }

            //получаем список статусов и заполняем комбобокс
            Query(connection, cmd1, out stat);
            for (int i = 0; i < stat.Rows.Count; i++)
            {
                ClientStatus.Items.Add(stat.Rows[i][0]);
            }

            //обновление датагрида
            UpdateGrid();
        }

        //кнопка выбора
        private void Chose(object sender, RoutedEventArgs e)
        {
            //не выделен ни одна строка
            if (Clients.SelectedItems.Count != 1)
            {
                MessageBox.Show("Выделено неверное колличество клиентов");
            }
            else
            {
                //блокируем возможность добавить или выбирать клиентов, разблокируем воможность сохранить изменения
                Change.IsEnabled = true;
                Add.IsEnabled = false;
                Pick.IsEnabled = false;

                //сохраняем старые параметры пользователя
                string name;
                string manager;
                string status;

                int index = Clients.SelectedIndex;
                DataRowView v = (DataRowView)Clients.Items[index];
                curid = (int)v[0];
                name = (string)v[1];
                status = (string)v[2];
                manager = (string)v[3];

                //выводим параметры в поля ввода
                ClientName.Text = name;
                ClientStatus.SelectedItem = status;
                ClientManager.SelectedItem = manager;

            }


        }

        //кнопка сохранения изменений
        private void Change_Click(object sender, RoutedEventArgs e)
        {
            //разблокируем возможность добавлять и выбирать, блокируем возможность сохранить
            Pick.IsEnabled = true;
            Add.IsEnabled = true;
            Change.IsEnabled = false;

            //настраиваем запрос на изменение данных
            string UpdateQuerry =   "UPDATE Clients SET name = @name, status = @status, manager = @managerId " +
                                    "WHERE id = @curid";
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = UpdateQuerry;

            //добовляем обьекту параметры
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = ClientName.Text;
            cmd.Parameters.Add("@status", SqlDbType.NVarChar, 15).Value = ClientStatus.SelectedItem;
            cmd.Parameters.Add("@managerId", SqlDbType.NVarChar, 15).Value = ClientManager.SelectedIndex;
            cmd.Parameters.Add("@curid", SqlDbType.Int).Value = curid;
            DataTable QueryResult = new DataTable();

            //запрашиваем изменения и обновляем датагрид
            Query(connection, cmd, out QueryResult);
            UpdateGrid();


            //обнуление полей
            ClientName.Text = "";
            ClientManager.SelectedIndex = -1;
            ClientStatus.SelectedIndex = -1;

        }

        //кнопка удаления обьекта
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            //не выделена ни одна строка
            if(Clients.SelectedItems.Count != 1)
            {
                MessageBox.Show("Выделено неверное колличество клиентов");
            }
            else
            {
                //получаем id обьекта в базе
                int index = Clients.SelectedIndex;
                DataRowView v = (DataRowView)Clients.Items[index];
                int id = (int)v[0];

                //настраиваем запрос
                string removeQuery = "DELETE FROM Clients WHERE id = " + id.ToString();
                SqlConnection connection = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = removeQuery;
                DataTable QueryResult;

                //выполняем запрос и обнавляем датагрид
                Query(connection, cmd, out QueryResult);
                UpdateGrid();
            }
        }

        //добавление обьекта
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            //плучаем параметры из полей ввода
            string name = ClientName.Text;
            string status = ClientStatus.Text;
            int managerId = ClientManager.SelectedIndex;

            //настраиваем запрос
            string addQuery = "INSERT INTO Clients([name], [status], [manager])" +
                                "VALUES (@name, @status, @managerId)";
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = addQuery;
            DataTable QueryResult;

            //добовляем обьекту параметры
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name;
            cmd.Parameters.Add("@status", SqlDbType.NVarChar, 15).Value = status;
            cmd.Parameters.Add("@managerId", SqlDbType.NVarChar, 15).Value = managerId;

            //выполнение запроса и обновление датагрида
            Query(connection, cmd, out QueryResult);
            UpdateGrid();

            //обнуление полей
            ClientName.Text = "";
            ClientManager.SelectedIndex = -1;
            ClientStatus.SelectedIndex = -1;
        }
    }
}
