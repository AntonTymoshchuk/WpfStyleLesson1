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

namespace WpfStyleLesson1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            //Application.Current.Resources["secondStyle"]
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["firstStyle"] = Application.Current.Resources["thirdStyle"];
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["lightPinkColor"] = new SolidColorBrush(Colors.Yellow);
        }
    }
}
