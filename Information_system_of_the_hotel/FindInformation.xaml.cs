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
    /// Interaction logic for FindInformation.xaml
    /// </summary>
    public partial class FindInformation : Page
    {
        public FindInformation()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InformationAboutHotel());
        }
    }
}
