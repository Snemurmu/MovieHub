using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace MovieHub
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        SqlConnection con;
        public Login()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-QAJII73\\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "Select count(*) from Account where username = @Username and password = @Password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("Username", username.Text);
                cmd.Parameters.AddWithValue("Password", password.Text);

                //Execute the query
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if ((count == 1) && (username.Text.Equals("chester") || username.Text.Equals("sneha")))
                {
                    MessageBox.Show("ADMIN Account Successfully Logged in!");
                    con.Close();                    
                    Movie movieAdmin = new Movie();
                    movieAdmin.Show();
                    this.Close();
                }
                else if (count == 1)
                {
                    MessageBox.Show("Account Successfully Logged in!");
                    con.Close();                    
                    MovieUser movieuser = new MovieUser();
                    movieuser.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!");
                    con.Close();
                    
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   

        private void back_Click(object sender, RoutedEventArgs e)
        {            
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
