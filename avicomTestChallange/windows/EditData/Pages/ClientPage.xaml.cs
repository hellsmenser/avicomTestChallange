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
        //создание экземпляра запросника
        Query query = new Query();
        Exception ex = null;
        int curid;
        DataTable man;

        //сообщение об ошибке
        private void Excpt()
        {
            if (ex != null)
            {
                MessageBox.Show(ex.Message);
                ex = null;
            }

        }

        public ClientPage()
        {
            InitializeComponent();
        }

        //обновление значений датагрида
        private void UpdateGrid()
        {
            //наистраиваем запрос
            string sql = "SELECT c.id, c.name, c.status, m.name AS 'manager' FROM Clients AS c, Managers AS m " +
                            "WHERE c.manager = m.id";
            DataTable QueryResult;
            //выполнение запроса
            QueryResult = query.Running(sql, out ex);
            Excpt();
            //загрузка новых данных в датагрид
            Clients.ItemsSource = QueryResult.DefaultView;

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //настройказапроса к бд
            string managerReq = "SELECT * FROM Managers";
            string statusReq = "SELECT * FROM ClientStatus";
            man = new DataTable();
            DataTable stat = new DataTable();

            //получаем имена менеджеров и заполняем ими комбобокс
            man = query.Running(managerReq, out ex);
            Excpt();
            for (int i = 0; i < man.Rows.Count; i++)
            {
                ClientManager.Items.Add(man.Rows[i][1]);
            }

            //получаем список статусов и заполняем комбобокс
            stat = query.Running(statusReq, out ex);
            Excpt();
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
                MessageBox.Show("Выделено неверное колличество обьектов");
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
            SqlCommand cmd = new SqlCommand();

            //добовляем обьекту параметры
            try
            {
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = ClientName.Text;
                cmd.Parameters.Add("@status", SqlDbType.NVarChar, 15).Value = ClientStatus.SelectedItem;
                cmd.Parameters.Add("@managerId", SqlDbType.NVarChar, 15).Value = (int)man.Rows[ClientManager.SelectedIndex][0]; ;
                cmd.Parameters.Add("@curid", SqlDbType.Int).Value = curid;
            }
            catch (Exception cex)
            {
                ex = cex;
                Excpt();
            }
            DataTable QueryResult = new DataTable();

            //запрашиваем изменения и обновляем датагрид
            QueryResult = query.Running(UpdateQuerry, cmd, out ex);
            Excpt();
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
                MessageBox.Show("Выделено неверное колличество обьектов");
            }
            else
            {
                //получаем id обьекта в базе
                int index = Clients.SelectedIndex;
                DataRowView v = (DataRowView)Clients.Items[index];
                int id = (int)v[0];

                //настраиваем запрос
                string removeQuery = "DELETE FROM Clients WHERE id = " + id.ToString();
                DataTable QueryResult;

                //выполняем запрос и обнавляем датагрид
                QueryResult = query.Running(removeQuery, out ex);
                Excpt();
                UpdateGrid();
            }
        }

        //добавление обьекта
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            //плучаем параметры из полей ввода
            string name = ClientName.Text;
            string status = ClientStatus.Text;
            int managerId = (int)man.Rows[ClientManager.SelectedIndex][0];

            //настраиваем запрос
            string addQuery = "INSERT INTO Clients([name], [status], [manager])" +
                                "VALUES (@name, @status, @managerId)";
            SqlCommand cmd = new SqlCommand();
            DataTable QueryResult;

            //добовляем обьекту параметры
            try
            {
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name;
                cmd.Parameters.Add("@status", SqlDbType.NVarChar, 15).Value = status;
                cmd.Parameters.Add("@managerId", SqlDbType.NVarChar, 15).Value = managerId;
            }
            catch (Exception cex)
            {
                ex = cex;
                Excpt();
            }

            //выполнение запроса и обновление датагрида
            QueryResult = query.Running(addQuery, cmd, out ex);
            Excpt();
            UpdateGrid();

            //обнуление полей
            ClientName.Text = "";
            ClientManager.SelectedIndex = -1;
            ClientStatus.SelectedIndex = -1;
        }
    }
}
