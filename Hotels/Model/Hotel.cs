using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Model
{
    public class Hotel : Base<Hotel>
    {
        //public int HotelID { get; set; }
        public string Name { get; set; }

        public List<RoomType> RoomTypes
        {
            get
            {
                var res = new List<RoomType>();
                foreach (var ht in HotelRoomType.Items.Values)
                    if (ht.Hotel == this)
                        res.Add(ht.RoomType);
                return res;
            }
        }
        public List<Employee> Employees
        {
            get
            {
                var res = new List<Employee>();
                foreach (var he in HotelEmployee.Items.Values)
                    if (he.Hotel == this)
                        res.Add(he.Employee);
                return res;
            }
        }

        public override void Insert()
        {
            try
            {
                conn.Open();
                string query = @"insert into tbHotel
                            (Name)
                            values (@Name)";
                // 2. define parameters used in command object
                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@Name";
                param1.Value = this.Name;
                SqlCommand cmd = new SqlCommand(query, conn);
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
        public override List<Hotel> Retrieve()
        {
            try
            {
                conn.Open();
                string query = @"select * from tbHotel";
                // 1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand(query, conn);

                // 2. Call Execute reader to get query results
                SqlDataReader rdr = cmd.ExecuteReader();
                List<Hotel> list = new List<Hotel>();
                Items.Clear();
                while (rdr.Read())
                {
                    Hotel temp = new Hotel();
                    temp.ID = Convert.ToInt32(rdr[0]);
                    temp.Name = rdr[1].ToString();
                    list.Add(temp);
                    //словник об'єктів
                    Items.Add(temp.ID, temp);
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
        public override void Update()
        {
            try
            {
                conn.Open();
                // prepare command string
                string query = @"
                update tbHotel
                set Name = @Name
                where HotelID = @HotelID";

                // 1. Instantiate a new command with command text only

                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@Name";
                param1.Value = this.Name;
                
                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@HotelID";
                param2.Value = this.ID;

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
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
                 delete from tbHotel
                 where HotelID = @HotelID";
                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@HotelID";
                param1.Value = this.ID;
                // 1. Instantiate a new command
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(param1);
                cmd.ExecuteNonQuery();

            }
            finally
            {
                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                    //Items.Remove(this.ID);
                }
            }
        }
    }
}
