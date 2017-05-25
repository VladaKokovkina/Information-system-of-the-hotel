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
    /// Interaction logic for InformationAboutHotel.xaml
    /// </summary>
    public partial class InformationAboutHotel : Page
    {
        public InformationAboutHotel()
        {
            InitializeComponent();           
        }




        private void exit_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
        }


        private void dataguests_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*List<Client> clientlist = new List<Client>();
           Serialization.Deserialize(clientlist);
           foreach(Client cl in clientlist)
           {
               dataguests.Items.Add(cl.show());
           }*/
        }

        private void newgust_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignUpGuest());
        }

        private void find_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FindInformation());
        }
    }
}
