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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(tBPassword1.Text !="" && tBPassword2.Text != "")
            {
                if (tBPassword1.Text == tBPassword2.Text)
                {
                    Person tempPerson = new Person();
                    tempPerson.FirstName = tBFirstName.Text;
                    tempPerson.LastName = tbLastName.Text;
                    tempPerson.Email = tBEmail.Text;
                    tempPerson.Telephone = "";
                    tempPerson.Login = tBLogin.Text;
                    tempPerson.Password = tBPassword1.Text;
                    tempPerson.Insert();
                    MessageBox.Show("Користувач " + tempPerson.Login + " зареєстрований", "Реєстрація пройшла успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Паролі не збігаються", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введіть пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxShow_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                tBPassword1.PasswordChar = '\0';
                tBPassword2.PasswordChar = '\0';
            }
            else
            {
                tBPassword1.PasswordChar = '*';
                tBPassword2.PasswordChar = '*';
            }
        }
    }
}
