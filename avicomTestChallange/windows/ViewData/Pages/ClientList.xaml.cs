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

namespace avicomTestChallange.windows.ViewData.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientList.xaml
    /// </summary>
    public partial class ClientList : Page
    {
        Query query = new Query();
        Exception ex = null;

        //сообщение об ошибке
        private void Excpt()
        {
            if (ex != null)
            {
                MessageBox.Show(ex.Message);
                ex = null;
            }

        }
        public ClientList()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            

            //наистраиваем запрос
            string sql = "SELECT c.id, c.name, c.status, m.name AS manager FROM Clients AS c, Managers AS m " +
                            "WHERE c.manager = m.id";
            DataTable QueryResult = new DataTable();


            //выполнение запроса
            QueryResult = query.Running(sql, out ex);
            Excpt();

            //загрузка новых данных в датагрид
            grid.ItemsSource = QueryResult.DefaultView;

        }
    }
}
