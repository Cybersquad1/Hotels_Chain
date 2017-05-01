using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Model
{
    public class Booking:Base<Booking>
    {
        //public int BookingId { get; set; }
        public int _roomID { get; set; }
        private int _clientID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Client Client
        {
            get
            {
                if (_clientID == -1)
                    return null;
                return (Client)Person.Items[_clientID];
            }
            set
            {
                if (value == null)
                    _clientID = -1;
                else
                    _clientID = value.ID;
            }
        }
        public Room BookingRoom
        {
            get
            {
                if (_roomID == -1)
                    return null;
                return Room.Items[_roomID];
            }
            set
            {
                if (value == null)
                    _roomID = -1;
                else
                    _roomID = value.ID;
            }
        }
        public Booking() { }
        public Booking(Room r,Client cl)
        {
            BookingRoom = r; Client = cl;
        }

        public override void Insert()
        {
            try
            {
                conn.Open();
                string query = @"insert into tbBooking
                            (_roomID,_clientID,StartDate,EndDate)
                            values (@_roomID,@_clientID,@StartDate,@EndDate)";
                // 2. define parameters used in command object
                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@_roomID";
                param1.Value = this._roomID;
                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@_clientID";
                param2.Value = this._clientID;
                SqlParameter param3 = new SqlParameter();
                param3.ParameterName = "@StartDate";
                param3.Value = this.StartDate;
                SqlParameter param4 = new SqlParameter();
                param4.ParameterName = "@EndDate";
                param4.Value = this.EndDate;

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                cmd.Parameters.Add(param3);
                cmd.Parameters.Add(param4);
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
        public override List<Booking> Retrieve()
        {
            try
            {
                conn.Open();
                string query = @"select * from tbBooking";
                // 1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand(query, conn);

                // 2. Call Execute reader to get query results
                SqlDataReader rdr = cmd.ExecuteReader();
                List<Booking> list = new List<Booking>();
                Items.Clear();
                while (rdr.Read())
                {
                    Booking temp = new Booking();
                    temp.ID = Convert.ToInt32(rdr[0]);
                    temp._roomID = Convert.ToInt32(rdr[1]);
                    temp._clientID = Convert.ToInt32(rdr[2]);
                    temp.StartDate = Convert.ToDateTime(rdr[3]);
                    temp.EndDate = Convert.ToDateTime(rdr[4]);
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
                update tbBooking
                set Name = @Name,
                    _roomID = @_roomID,
                    _clientID = @_clientID,
                    StartDate = @StartDate,
                    EndDate = @EndDate
                where BookingID = @BookingID";

                // 1. Instantiate a new command with command text only

                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@_roomID";
                param1.Value = this._roomID;
                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@_clientID";
                param2.Value = this._clientID;
                SqlParameter param3 = new SqlParameter();
                param3.ParameterName = "@StartDate";
                param3.Value = this.StartDate;
                SqlParameter param4 = new SqlParameter();
                param4.ParameterName = "@EndDate";
                param4.Value = this.EndDate;
                SqlParameter param5 = new SqlParameter();
                param5.ParameterName = "@BookingID";
                param5.Value = this.ID;

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                cmd.Parameters.Add(param3);
                cmd.Parameters.Add(param4);
                cmd.Parameters.Add(param5);
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
                 delete from tbBooking
                 where BookingID = @BookingID";
                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@BookingID";
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
