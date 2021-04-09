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
    /// Логика взаимодействия для ClientByManagers.xaml
    /// </summary>
    public partial class ClientByManagers : Page
    {
        string conn = "Data Source=DESKTOP-5QF6I54;" +
                               "Initial Catalog=SoftTradePlus;" +
                               "Integrated Security=True";
        public ClientByManagers()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //наистраиваем запрос
            string sql =    "SELECT m.name AS name, COUNT(c.name) AS count " +
                            "FROM Clients AS c, Managers AS m " +
                            "WHERE c.manager = m.id " +
                            "GROUP BY m.name";
            SqlConnection connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand(sql, connection);
            DataTable QueryResult = new DataTable();
            SqlDataAdapter adapter;

            //выполнение запроса
            try
            {
                adapter = new SqlDataAdapter(cmd);
                connection.Open();
                adapter.Fill(QueryResult);
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

            //загрузка новых данных в датагрид
            grid.ItemsSource = QueryResult.DefaultView;

        }
    }
}
