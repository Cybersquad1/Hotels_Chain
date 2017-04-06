using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataHotels
{
    public class Person:Base
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        DateTime Birth { get; set; }
        string Telephone { get; set; }

        private string tbName = "tbPerson";

        public Person() { }
        public Person(string firstName,string lastName,string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public override void Create()
        {
            SqlConnection conn = new SqlConnection(
                     "Data Source=ACER\\SQLEXPRESS;Initial Catalog=dbHotels;Integrated Security=True");
            conn.Open();
            string query = @"insert into tbPerson
                            (FirstName, LastName,Email)
                            values (@FirstName, @LastName,@Email)";
            // 2. define parameters used in command object
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@FirstName";
            param1.Value = this.FirstName;
            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@LastName";
            param2.Value = this.LastName;
            SqlParameter param3 = new SqlParameter();
            param3.ParameterName = "@Email";
            param3.Value = this.Email;

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2);
            cmd.Parameters.Add(param3);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public /*override*/ List<Person> Retrieve()
        {
            SqlConnection conn = new SqlConnection(
                     "Data Source=ACER\\SQLEXPRESS;Initial Catalog=dbHotels;Integrated Security=True");
            conn.Open();
            string query = @"select * from tbPerson";
            // 1. Instantiate a new command with a query and connection
            SqlCommand cmd = new SqlCommand(query, conn);

            // 2. Call Execute reader to get query results
            SqlDataReader rdr = cmd.ExecuteReader();
            List<Person> list = new List<Person>();
            while (rdr.Read())
            {
                Person temp = new Person();
                temp.FirstName = rdr[1].ToString();
                temp.LastName = rdr[2].ToString();
                temp.Email = rdr[3].ToString();
                list.Add(temp);
            }
            conn.Close();
            return list;
            
        }
        public override void Update()
        {

        }
        public override void Delete()
        {

        }
    }
}
