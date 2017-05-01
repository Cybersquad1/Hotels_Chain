using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Model
{
    public class HotelEmployee:Base<HotelEmployee>
    {

        private int _hotelID;
        public Hotel Hotel
        {
            get
            {
                if (_hotelID == -1)
                    return null;
                return Hotel.Items[_hotelID];
            }
            set
            {
                if (value == null)
                    _hotelID = -1;
                else
                    _hotelID = value.ID;
            }
        }
        private int _employeeID;
        public Employee Employee
        {
            get
            {
                if (_employeeID == -1)
                    return null;
                return (Employee)Person.Items[_employeeID];
            }
            set
            {
                if (value == null)
                    _employeeID = -1;
                else
                    _employeeID = value.ID;
            }
        }
        public HotelEmployee(Hotel ht, Employee em)
        {
            Hotel = ht; Employee = em;
        }
        public override void Insert()
        {
            throw new NotImplementedException();
        }
        public override List<HotelEmployee> Retrieve()
        {
            throw new NotImplementedException();
        }
        public override void Update()
        {
            throw new NotImplementedException();
        }
        public override void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
