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
using avicomTestChallange.windows;
using avicomTestChallange.windows.ViewData;
using avicomTestChallange.windows.EditData;

namespace avicomTestChallange
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }


        //кнопка выхода
        private void ExitBtn(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }


        //кнопка просмотра данных
        private void ViewDataClick(object sender, RoutedEventArgs e)
        {
            ViewDataWindow ViewData = new ViewDataWindow();
            ViewData.Show();
            Hide();
        }

        private void EditDataClick(object sender, RoutedEventArgs e)
        {
            EditDataWindow editData = new EditDataWindow();
            editData.Show();
            Hide();
        }
    }

    }

