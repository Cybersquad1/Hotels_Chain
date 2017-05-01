using Hotels.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotels.Controller
{
    public class ControllerHotel:Controller<Hotel>
    {
        public ControllerHotel(DataGridView dgv, BindingNavigator bn, Dictionary<string, TextBox> textBoxs) : base(dgv, bn, textBoxs) { }

        public override void Save()
        {
            Hotel hotel = new Hotel();
            hotel.Name = TextBoxs["Name"].Text;
            
            if (((DataRowView)bindingSource.Current).IsNew == true)
                hotel.Insert();
            else
            {
                hotel.ID = (int)((DataRowView)bindingSource.Current).Row["ID"];
                hotel.Update();
            }
        }
        public override void Delete()
        {
            Hotel hotel = new Hotel();
            hotel.ID = (int)((DataRowView)bindingSource.Current).Row["ID"];
            hotel.Delete();
        }
        public override void LoadDB()
        {
            Hotel temp = new Hotel();
            List<Hotel> list = temp.Retrieve();
            Hotel.Items.Values.ToArray();
            //if(list.Count!=0)
                FillRows(Hotel.Items.Values.ToArray());
        }
    }
}
