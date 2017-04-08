using Hotels.Controller;
using Hotels.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotels.View
{
    public partial class FormPerson : Form
    {
        public FormPerson()
        {
            InitializeComponent();
        }

        private void FormPerson_Load(object sender, EventArgs e)
        {
            LoadDB();
        }
        private void LoadDB()
        {
            List<Person> list = Person.Retrieve();
            //DrawTable.DrawObjectInTable(list.ToArray(), dGVPerson);
            DrawTable.DrawDataTable(list.ToArray(), dGVPerson);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Person newperson = new Person();
            newperson.FirstName = tbFirstName.Text;
            newperson.LastName = tbLastName.Text;
            newperson.Email = tbEmail.Text;
            newperson.Telephone = tbTelephone.Text;
            newperson.Insert();
            LoadDB();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }
    }
}
