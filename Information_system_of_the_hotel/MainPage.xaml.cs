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

namespace Information_system_of_the_hotel
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InformationForGuests());
        }

        private void signin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignIn());
        }

        private void signin_MouseEnter(object sender, MouseEventArgs e)
        {
            signin.FontSize = 60;
        }

        private void signin_MouseLeave(object sender, MouseEventArgs e)
        {
            signin.FontSize = 48;
        }

        private void start_MouseEnter(object sender, MouseEventArgs e)
        {
            start.FontSize = 60;
        }

        private void start_MouseLeave(object sender, MouseEventArgs e)
        {
            start.FontSize = 48;
        }
    }
}
