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
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;


namespace Information_system_of_the_hotel
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        

        public Window1()
        {
            InitializeComponent();
            

            /*List<Client> clientlist = new List<Client>();
            Serialization.Deserialize(clientlist);
            foreach(Client cl in clientlist)
            {
                dataguests.Items.Add(cl.show());
            }*/
        }

        private async void exit_Click(object sender, RoutedEventArgs e)
        {     
            this.Close();
        }
    }
}
