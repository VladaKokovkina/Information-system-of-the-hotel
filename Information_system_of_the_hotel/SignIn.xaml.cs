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
using System.Data;
using System.Data.SqlClient;

namespace Information_system_of_the_hotel
{
    /// <summary>
    /// Interaction logic for SignIn.xaml
    /// </summary>
    public partial class SignIn : Page
    {
        User user;
        SqlConnection conn;

        public SignIn()
        {
            InitializeComponent();
        }

        private async void forward_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            conn = new SqlConnection(connectionString);

            await conn.OpenAsync();

            SqlCommand cmd = new SqlCommand("SELECT id FROM [Users] WHERE UserName = @login AND Password = @password", conn);

            cmd.Parameters.Add("@login", SqlDbType.VarChar, 50).Value = username1.Text;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = password1.Password.ToString();
            await cmd.ExecuteNonQueryAsync();
            SqlDataReader reader = await cmd.ExecuteReaderAsync();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    int id = Convert.ToInt16(reader["Id"]);
                    user = new User(username1.Text, id);
                    NavigationService.Navigate(new InformationAboutHotel());
                }
            }
            else
            {
                MessageBox.Show("Check your login or password, it's incorrect");
            }

            conn.Close();
        }

        private async void forward_MouseEnter(object sender, MouseEventArgs e)
        {
            forward.FontSize = 60;
        }

        private async void forward_MouseLeave(object sender, MouseEventArgs e)
        {
            forward.FontSize = 48;
        }

        private async void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}
