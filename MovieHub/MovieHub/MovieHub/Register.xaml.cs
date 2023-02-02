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
using System.Xml.Linq;

namespace MovieHub
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        SqlConnection con;
        public Register()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-QAJII73\\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "Insert into Account values(@Username, @Password, @First_name, @Last_name, @Date_of_birth, @Email)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("Username", username.Text);
                cmd.Parameters.AddWithValue("Password", password.Text);
                cmd.Parameters.AddWithValue("First_name", fName.Text);
                cmd.Parameters.AddWithValue("Last_name", lName.Text);
                cmd.Parameters.AddWithValue("Date_of_birth", dob.Text);
                cmd.Parameters.AddWithValue("Email", email.Text);

                //Execute the query
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account Registered");
                con.Close();
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
