using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for Movie.xaml
    /// </summary>
    public partial class Movie : Window
    {
        SqlConnection con;
        public Movie()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {
            //Open database connection
            try
            {
                string connectionString = "Data Source=DESKTOP-QAJII73\\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "Insert into Movie values(@ID, @Title, @Year, @Genre, @Price)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("ID", int.Parse(id.Text));
                cmd.Parameters.AddWithValue("Title", title.Text);
                cmd.Parameters.AddWithValue("Year", int.Parse(year.Text));
                cmd.Parameters.AddWithValue("Genre", genre.Text);
                cmd.Parameters.AddWithValue("Price", float.Parse(price.Text));

                //Execute the query
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted Perfectly to the Database");
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            //Open database connection
            try
            {
                string connectionString = "Data Source=DESKTOP-QAJII73\\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "Update Movie set title=@Title, year=@Year, genre=@Genre, price=@Price where id=@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("ID", int.Parse(id.Text));
                cmd.Parameters.AddWithValue("Title", title.Text);
                cmd.Parameters.AddWithValue("Year", int.Parse(year.Text));
                cmd.Parameters.AddWithValue("Genre", genre.Text);
                cmd.Parameters.AddWithValue("Price", float.Parse(price.Text));

                //Execute the query
                cmd.ExecuteNonQuery();
                MessageBox.Show("Database Updated");
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            //Open database connection
            try
            {
                string connectionString = "Data Source=DESKTOP-QAJII73\\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "SELECT title, year, genre, price from Movie where id=@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("ID", int.Parse(id.Text));
                SqlDataReader sqlReader = cmd.ExecuteReader();
                
                while (sqlReader.Read())
                {
                    title.Text = (string)sqlReader.GetValue(0);
                    year.Text = sqlReader.GetValue(1).ToString();
                    genre.Text = (string)sqlReader.GetValue(2);
                    price.Text = sqlReader.GetValue(3).ToString();
                }

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            //Open database connection
            try
            {
                string connectionString = "Data Source=DESKTOP-QAJII73\\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "DELETE Movie where id=@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("ID", int.Parse(id.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Properly");
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void main_Click(object sender, RoutedEventArgs e)
        {                    
            MessageBox.Show("Account Logged out Successfully!");            
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
