using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Model
{
    public enum Roles {Administrator,FrontDesk,Service};
    public class Employee:Person
    {
        public decimal salary { get; set; }
        public Roles role { get; set; }

        public List<Hotel> Hotels
        {
            get
            {
                var res = new List<Hotel>();
                foreach (var ht in HotelEmployee.Items.Values)
                    if (ht.Employee == this)
                        res.Add(ht.Hotel);
                return res;
            }
        }
    }
}
