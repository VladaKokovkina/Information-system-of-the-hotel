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
using System.IO;

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

        private void find_Click(object sender, RoutedEventArgs e)
        {
            StreamReader str = new StreamReader("Residents.txt", Encoding.Default);
            while (!str.EndOfStream)
            {
                string st = str.ReadLine();
                if (st.StartsWith(surname.Text))
                {
                    info.Items.Add(st.ToString());
                    break;
                }
            }
            str.Close();
        }

        private void info_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditPage());
        }
    }
}
