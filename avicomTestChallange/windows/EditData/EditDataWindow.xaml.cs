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
using avicomTestChallange.windows.EditData.Pages;

namespace avicomTestChallange.windows.EditData
{
    /// <summary>
    /// Логика взаимодействия для EditDataWindow.xaml
    /// </summary>
    public partial class EditDataWindow : Window
    {
        public EditDataWindow()
        {
            InitializeComponent();
        }

        private void Returnbtn(object sender, RoutedEventArgs e)
        {
            MainWindow mainWin = new MainWindow();
            mainWin.Show();
            this.Close();
        }

        private void ClientEdit(object sender, RoutedEventArgs e)
        {
            editDataFrame.Content = new ClientPage();
        }

        private void ProductEdit(object sender, RoutedEventArgs e)
        {
            editDataFrame.Content = new ProductPage();
        }

        private void ManagerEdit(object sender, RoutedEventArgs e)
        {
            editDataFrame.Content = new ManagerPage();
        }
    }
}
