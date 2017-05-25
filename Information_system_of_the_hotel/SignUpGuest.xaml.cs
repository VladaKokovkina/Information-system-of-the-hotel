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
    /// Interaction logic for SignUpGuest.xaml
    /// </summary>
    public partial class SignUpGuest : Page
    {
        public SignUpGuest()
        {
            InitializeComponent();
        }

        private void signup_Click(object sender, RoutedEventArgs e)
        {
                int guests = 0;
                StreamReader sr = new StreamReader("Residents.txt");
                while (!sr.EndOfStream)
                {
                    sr.ReadLine();
                    ++guests;
                }
                sr.Close();
                
                if(surname1.Text == "" && name1.Text == "" && birth1.Text == "" && sex1.SelectedIndex == -1 && passport1.Text == "" && arrival1.Text == "" && depature1.Text == "")
                {
                    MessageBox.Show("Empty fields are not allowed!");
                }
                else if (55 - guests > 0)
                {
                    StreamWriter sw = new StreamWriter("Residents.txt", true);
                    sw.WriteLine(surname1.Text + " " + name1.Text + " " + birth1.Text + " " + sex1.Text + " " + passport1.Text + " " + arrival1.Text + " " + depature1.Text + "\n");
                    sw.Close();
                }
                else
                {
                    MessageBox.Show("No available rooms");
                }
            
            NavigationService.Navigate(new InformationAboutHotel());
        }
    }
}
