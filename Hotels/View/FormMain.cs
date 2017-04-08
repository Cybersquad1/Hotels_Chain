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
using Hotels.Model;
using Hotels.Controller;
using Hotels.View;

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
            //Person person = new Person("Anton","Boloban4","sdd@ukr.net");
            //person.Create();
            //List<Person> list = Person.Retrieve();
            ////connection.Open();
            ////string query = @"insert into tbPerson
            ////                (FirstName, LastName,Email)
            ////                values ('Bogdan', 'Ivashko','ddd@ukr.net')";
            ////SqlCommand cmd = new SqlCommand(query, connection);
            ////cmd.ExecuteNonQuery();
            ////connection.Close();
            //Draw();
            //DrawTable.DrawObjectInTable(list.ToArray(), dGVPerson);
        }

        private void itemPerson_Click(object sender, EventArgs e)
        {
            FormPerson formperson = new FormPerson();
            formperson.MdiParent = this;
            formperson.Show();
        }

        //private void Draw()
        //{
        //    using (connection = new SqlConnection(connectionString))
        //    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbPerson", connection))
        //    {
        //        DataTable personTable = new DataTable();
        //        adapter.Fill(personTable);
        //        lB1.DisplayMember = "LastName";
        //        lB1.ValueMember = "PersonId";
        //        lB1.DataSource = personTable;
        //    }
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    List<Person> list = Person.Retrieve();
        //    foreach (var item in list)
        //    {
        //        item.Delete();
        //    }
        //    List<Person> list1 = Person.Retrieve();
        //    Draw();
        //    DrawTable.DrawObjectInTable(list1.ToArray(), dGVPerson);
        //}

        //private void btUpdate_Click(object sender, EventArgs e)
        //{
        //    List<Person> list = Person.Retrieve();
        //    foreach (var item in list)
        //    {
        //        item.Telephone = "+380980127501";
        //        item.Birth = new DateTime(1997, 08, 29);
        //        item.Update();
        //    }
        //    List<Person> list1 = Person.Retrieve();
        //    Draw();
        //    DrawTable.DrawObjectInTable(list1.ToArray(), dGVPerson);
        //}
    }
}
