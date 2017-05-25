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
    /// Interaction logic for EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        public EditPage()
        {
            InitializeComponent();


            List<Client> clientlist = new List<Client>();
            StreamReader sr = new StreamReader("Residents.txt");
            while (!sr.EndOfStream)
            {
                string[] input = sr.ReadLine().Split(' ');
                clientlist.Add(new Client(input[0], input[1], input[2], input[3], input[4], input[5], input[6]));
            }
            foreach (Client client in clientlist)
            {
                edit.AppendText(client.show());
                edit.AppendText("\n");
            }
            sr.Close();


        }

        private void edit_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("Residents.txt");
            string[] clientmass = edit.Text.Split('\n');
            for(int i = 0; i != clientmass.Length; ++i)
            {
                sw.WriteLine(clientmass[i]);
            }
            sw.Close();

            NavigationService.Navigate(new InformationAboutHotel());
        }
    }
}
