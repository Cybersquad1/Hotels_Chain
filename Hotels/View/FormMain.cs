using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using DataHotels;

namespace Hotels
{
    public partial class FormMain : Form
    {
        SqlConnection connection;
        string connectionString;
        public FormMain()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Hotels.Properties.Settings.dbHotelsConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Person person = new Person("Anton","Boloban4","sdd@ukr.net");
            person.Create();
            person.Retrieve();
            //connection.Open();
            //string query = @"insert into tbPerson
            //                (FirstName, LastName,Email)
            //                values ('Bogdan', 'Ivashko','ddd@ukr.net')";
            //SqlCommand cmd = new SqlCommand(query, connection);
            //cmd.ExecuteNonQuery();
            //connection.Close();
            Retail();
        }

        private void Retail()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbPerson", connection))
            {
                DataTable personTable = new DataTable();
                adapter.Fill(personTable);
                lB1.DisplayMember = "LastName";
                lB1.ValueMember = "PersonId";
                lB1.DataSource = personTable;
            }
        }
    }
}
