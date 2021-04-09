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
    }
}
