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
using System.Windows.Shapes;
using avicomTestChallange.windows.ViewData.Pages;

namespace avicomTestChallange.windows.ViewData
{
    /// <summary>
    /// Логика взаимодействия для ViewDataWindow.xaml
    /// </summary>
    public partial class ViewDataWindow : Window
    {
        public ViewDataWindow()
        {
            InitializeComponent();
        }

        private void ReturnBtn(object sender, RoutedEventArgs e)
        {
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
            this.Close();
        }

        private void Managers(object sender, RoutedEventArgs e)
        {
            gridFrame.Content = new ManagerList();
        }

        private void Clients(object sender, RoutedEventArgs e)
        {
            gridFrame.Content = new ClientList();

        }

        private void Products(object sender, RoutedEventArgs e)
        {
            gridFrame.Content = new ProductList();

        }

        private void ClientsByManagers(object sender, RoutedEventArgs e)
        {
            gridFrame.Content = new ClientByManagers();

        }

        private void ProductsByClients(object sender, RoutedEventArgs e)
        {
            gridFrame.Content = new ProductsByClients();

        }

        private void ClientByStatus(object sender, RoutedEventArgs e)
        {
            gridFrame.Content = new ClientByStatus();

        }
    }
}
