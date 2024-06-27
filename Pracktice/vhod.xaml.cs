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

namespace Pracktice
{
    /// <summary>
    /// Логика взаимодействия для vhod.xaml
    /// </summary>
    public partial class vhod : Page
    {
        public vhod()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PaswordTextBox.Text;
            Data.GetUserByLogin(login, password);
            User user = Data.GetUserByLogin(login, password);
            if (user != null)
            {
                NavigationService.Navigate(new Uri("/HomePage.xaml", UriKind.Relative));
            }
            else
            {
                warning.Content = "неправильный пароль или логин!";
            }
        }

        private void LoginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PaswordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
