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
    /// Логика взаимодействия для ManagerPage.xaml
    /// </summary>
    public partial class ManagerPage : Page
    {
        public ManagerPage()
        {
            InitializeComponent();
        }


        //создание экземпляра запросника
        Query query = new Query();
        Exception ex = null;
        int curid;

        //сообщнение об ошибке
        private void Excpt()
        {
            if (ex != null)
            {
                MessageBox.Show(ex.Message);
                ex = null;
            }

        }
        //обновление значений датагрида
        private void UpdateGrid()
        {
            //наистраиваем запрос
            string sql = "SELECT * FROM Managers AS m";
            DataTable QueryResult;
            //выполнение запроса
            QueryResult = query.Running(sql, out ex);
            Excpt();
            //загрузка новых данных в датагрид
            Managers.ItemsSource = QueryResult.DefaultView;

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //обновление датагрида
            UpdateGrid();
        }

        //кнопка выбора
        private void Chose(object sender, RoutedEventArgs e)
        {
            //не выделен ни одна строка
            if (Managers.SelectedItems.Count != 1)
            {
                MessageBox.Show("Выделено неверное колличество обьектов");
            }
            else
            {
                //блокируем возможность добавить или выбирать обьект, разблокируем воможность сохранить изменения
                Change.IsEnabled = true;
                Add.IsEnabled = false;
                Pick.IsEnabled = false;

                //сохраняем старые параметры обьекта
                string name;

                int index = Managers.SelectedIndex;
                DataRowView v = (DataRowView)Managers.Items[index];
                curid = (int)v[0];
                name = (string)v[1];

                //выводим параметры в поля ввода
                ManagerName.Text = name;

            }


        }

        //кнопка сохранения изменений
        private void Change_Click(object sender, RoutedEventArgs e)
        {
            //разблокируем возможность добавлять и выбирать обьекты, блокируем возможность сохранить
            Pick.IsEnabled = true;
            Add.IsEnabled = true;
            Change.IsEnabled = false;

            //настраиваем запрос на изменение данных
            string UpdateQuerry = "UPDATE Managers SET name = @name " +
                                    "WHERE id = @curid";
            SqlCommand cmd = new SqlCommand();

            //добовляем обьекту параметры
            try
            {
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = ManagerName.Text;
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
            ManagerName.Text = "";

        }

        //кнопка удаления обьекта
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            //не выделена ни одна строка
            if (Managers.SelectedItems.Count != 1)
            {
                MessageBox.Show("Выделено неверное колличество обьектов");
            }
            else
            {
                //получаем id обьекта в базе
                int index = Managers.SelectedIndex;
                DataRowView v = (DataRowView)Managers.Items[index];
                int id = (int)v[0];

                //настраиваем запрос
                string removeQuery = "DELETE FROM Managers WHERE id = " + id.ToString();
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
            string name = ManagerName.Text;


            //настраиваем запрос
            string addQuery = "INSERT INTO Managers([name])" +
                                "VALUES (@name)";
            SqlCommand cmd = new SqlCommand();
            DataTable QueryResult;

            //добовляем обьекту параметры
            try
            {
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = ManagerName.Text;
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
            ManagerName.Text = "";
        }
    }
}
