using Hotels.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hotels.Controller
{
    public class ControllerPerson:Controller<Person>
    {
        public ControllerPerson(DataGridView dgv,BindingNavigator bn,Dictionary<string, TextBox> textBoxs):base(dgv,bn,textBoxs){  }
        
        public override void Save()
        {
            Person person = new Person();
            person.FirstName = TextBoxs["FirstName"].Text;
            person.LastName = TextBoxs["LastName"].Text;
            person.Email = TextBoxs["Email"].Text;
            person.Telephone = TextBoxs["Telephone"].Text;
            person.Login = TextBoxs["Login"].Text;
            person.Password = TextBoxs["Password"].Text;

            if (((DataRowView)bindingSource.Current).IsNew==true)
                person.Insert();               
            else
            {
                person.ID = (int)((DataRowView)bindingSource.Current).Row["ID"];
                person.Update();
            }
        }

        public override void Delete()
        {
            Person person = new Person();
            person.ID = (int)((DataRowView)bindingSource.Current).Row["ID"];
            person.Delete();
        }
        public override void LoadDB()
        {
            Person temp = new Person();
            List<Person> listPerson = temp.Retrieve();
            FillRows(listPerson.ToArray());
        }
    }
}
