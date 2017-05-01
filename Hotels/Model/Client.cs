using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Model
{
    public class Client:Person
    {
        List<Booking> Bookings
        {
            get
            {
                var res = new List<Booking>();
                foreach (var bk in Booking.Items.Values)
                    if (bk.Client == this)
                        res.Add(bk);
                return res;
            }

        }
        List<Room> BookedRoom
        {
            get
            {
                var res = new List<Room>();
                foreach (var bk in Booking.Items.Values)
                    if (bk.Client == this)
                        res.Add(bk.BookingRoom);
                return res;
            }
        }
    }
}
