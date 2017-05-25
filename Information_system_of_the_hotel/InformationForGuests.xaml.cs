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
    /// Interaction logic for InformationForGuests.xaml
    /// </summary>
    public partial class InformationForGuests : Page
    {
        public InformationForGuests()
        {
            InitializeComponent();
        }

        private void back1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            StreamReader str = new StreamReader("Rooms.txt", Encoding.Default);
            while (!str.EndOfStream)
            {
                string[] input = str.ReadLine().Split(' ');
                Room room = new Room(int.Parse(input[0]), input[1], int.Parse(input[2]), input[3], int.Parse(input[4]));
                if(room.Type == comboBox.Text && room.Place == int.Parse(comboBox1.Text) && room.Status == "свободно")
                {
                    freerooms.Items.Add(room.Show());
                }
            }
        }
    }
}
