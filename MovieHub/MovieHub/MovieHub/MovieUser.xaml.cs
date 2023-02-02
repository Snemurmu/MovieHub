using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
    /// Interaction logic for MovieUser.xaml
    /// </summary>
    public partial class MovieUser : Window
    {
        SqlConnection con;

        public MovieUser()
        {
            InitializeComponent();
        }

        private void list_TextChanged(object sender, TextChangedEventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-QAJII73\\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
            con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT * from Movie";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader(); 

            if(dr.Read())
            {
                textBox.Text = dr.GetValue(0).ToString();
            }
            con.Close();
        }
    }
}
