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
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        //создание экземпляра запросника
        Query query = new Query();
        Exception ex = null;
        int curid;

        //сообщение об ошибке
        private void Excpt()
        {
            if (ex != null)
            {
                MessageBox.Show(ex.Message);
                ex = null;
            }

        }

        public ProductPage()
        {
            InitializeComponent();
        }

        //обновление значений датагрида
        private void UpdateGrid()
        {
            //наистраиваем запрос
            string sql = "SELECT * FROM Products";
            DataTable QueryResult;
            //выполнение запроса
            QueryResult = query.Running(sql, out ex);
            Excpt();
            //загрузка новых данных в датагрид
            Products.ItemsSource = QueryResult.DefaultView;

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //заполнение типов лицензия
            ProductType.Items.Add("Подписка");
            ProductType.Items.Add("Лицензия");

            //обновление датагрида
            UpdateGrid();
        }

        //формирование позвожных периодов
        private void ProductType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProductPeriod.Items.Clear();
            if (ProductType.SelectedIndex == 0)
            {
                ProductPeriod.Items.Add("Месяц");
                ProductPeriod.Items.Add("Квартал");
                ProductPeriod.Items.Add("Год");
            }
            else
            {
                ProductPeriod.Items.Add("Лицензия");
                ProductPeriod.SelectedIndex = 0;
            }

        }

        //кнопка выбора
        private void Chose(object sender, RoutedEventArgs e)
        {
            //не выделен ни одна строка
            if (Products.SelectedItems.Count != 1)
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
                string type;
                int price;
                string period;

                int index = Products.SelectedIndex;
                DataRowView v = (DataRowView)Products.Items[index];
                curid = (int)v[0];
                name = (string)v[1];
                type = (string)v[2];
                price = (int)v[3];
                period = (string)v[4];

                //выводим параметры в поля ввода
                ProductName.Text = name;
                ProductType.SelectedItem = type;
                ProductPrice.Text = price.ToString();
                ProductPeriod.SelectedItem = period;

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
            string UpdateQuerry = "UPDATE Products SET name = @name, type = @type, price = @price, period = @period " +
                                    "WHERE id = @curid";
            SqlCommand cmd = new SqlCommand();

            //добовляем обьекту параметры
            try
            {
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = ProductName.Text;
                cmd.Parameters.Add("@type", SqlDbType.NVarChar, 8).Value = ProductType.Text;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = Convert.ToInt32(ProductPrice.Text);
                cmd.Parameters.Add("@period", SqlDbType.NVarChar, 8).Value = ProductPeriod.Text;
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
            ProductName.Text = "";
            ProductType.SelectedIndex = -1;
            ProductPrice.Text = "";
            ProductPeriod.SelectedIndex = -1;

        }

        //кнопка удаления обьекта
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            //не выделена ни одна строка
            if (Products.SelectedItems.Count != 1)
            {
                MessageBox.Show("Выделено неверное колличество обьектов");
            }
            else
            {
                //получаем id обьекта в базе
                int index = Products.SelectedIndex;
                DataRowView v = (DataRowView)Products.Items[index];
                int id = (int)v[0];

                //настраиваем запрос
                string removeQuery = "DELETE FROM Products WHERE id = " + id.ToString();
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
            string name = ProductName.Text;
            string type = ProductType.Text;
            string price = ProductPrice.Text;
            string period = ProductPeriod.Text;
            

            //настраиваем запрос
            string addQuery = "INSERT INTO Products([name], [type], [price], [period])" +
                                "VALUES (@name, @type, @price, @period)";
            SqlCommand cmd = new SqlCommand();
            DataTable QueryResult;

            //добовляем обьекту параметры
            try
            {
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = ProductName.Text;
                cmd.Parameters.Add("@type", SqlDbType.NVarChar, 8).Value = ProductType.Text;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = Convert.ToInt32(ProductPrice.Text);
                cmd.Parameters.Add("@period", SqlDbType.NVarChar, 8).Value = ProductPeriod.Text;
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
            ProductName.Text = "";
            ProductType.SelectedIndex = -1;
            ProductPrice.Text = "";
            ProductPeriod.SelectedIndex = -1;
        }
    }
}
