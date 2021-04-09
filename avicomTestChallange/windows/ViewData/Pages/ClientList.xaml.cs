﻿using System;
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
        string conn = "Data Source=DESKTOP-5QF6I54;" +
                               "Initial Catalog=SoftTradePlus;" +
                               "Integrated Security=True";
        public ClientList()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            

            //наистраиваем запрос
            string sql = "SELECT c.id, c.name, c.status, m.name AS manager FROM Clients AS c, Managers AS m " +
                            "WHERE c.manager = m.id";
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
