using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Hotels.Model
{
    public class Person:Base
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birth { get; set; }
        public string Telephone { get; set; }

        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Hotels.Properties.Settings.dbHotelsConnectionString"].ConnectionString);
        public Person() { }
        public Person(string firstName,string lastName,string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public override void Insert()
        {
            try
            {
                conn.Open();
                string query = @"insert into tbPerson
                            (FirstName, LastName,Email,Telephone)
                            values (@FirstName, @LastName,@Email,@Telephone)";
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
                SqlParameter param4 = new SqlParameter();
                param4.ParameterName = "@Birth";
                param4.Value = this.Birth;
                SqlParameter param5 = new SqlParameter();
                param5.ParameterName = "@Telephone";
                param5.Value = this.Telephone;

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                cmd.Parameters.Add(param3);
                cmd.Parameters.Add(param5);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public /*override*/ static List<Person> Retrieve()
        {
            try
            {
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
                    temp.PersonID = Convert.ToInt32(rdr[0]);
                    temp.FirstName = rdr[1].ToString();
                    temp.LastName = rdr[2].ToString();
                    temp.Email = rdr[3].ToString();
                    //temp.Birth = (DateTime)rdr[4];
                    temp.Telephone = rdr[5].ToString();
                    list.Add(temp);
                }
                conn.Close();
                return list;
            }
            finally
            {
                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void Select(int id)
        {
            try
            {
                conn.Open();
                string query = @"select * from tbPerson 
                                 where PersonID = @PersonID";
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@PersonID";
                param.Value = this.PersonID;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public override void Update()
        {
            try
            {
                conn.Open();
                // prepare command string
                string query = @"
                update tbPerson
                set FirstName = @FirstName,
                    LastName = @LastName,
                    Email = @Email,
                    Birth = @Birth,
                    Telephone = @Telephone
                where PersonID = @PersonID";

                // 1. Instantiate a new command with command text only
                
                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@FirstName";
                param1.Value = this.FirstName;
                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@LastName";
                param2.Value = this.LastName;
                SqlParameter param3 = new SqlParameter();
                param3.ParameterName = "@Email";
                param3.Value = this.Email;
                SqlParameter param4 = new SqlParameter();
                param4.ParameterName = "@Birth";
                param4.Value = this.Birth;
                SqlParameter param5 = new SqlParameter();
                param5.ParameterName = "@Telephone";
                param5.Value = this.Telephone;
                SqlParameter param6 = new SqlParameter();
                param6.ParameterName = "@PersonID";
                param6.Value = this.PersonID;

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                cmd.Parameters.Add(param3);
                cmd.Parameters.Add(param4);
                cmd.Parameters.Add(param5);
                cmd.Parameters.Add(param6);
                // 3. Call ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();
            }
            finally
            {
                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public override void Delete()
        {
            try
            {               
                // Open the connection
                conn.Open();

                // prepare command string
                string query = @"
                 delete from tbPerson
                 where PersonID = @PersonID";
                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@PersonID";
                param1.Value = this.PersonID;
                // 1. Instantiate a new command
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.Parameters.Add(param1);
                cmd.ExecuteNonQuery();

            }
            finally
            {
                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
