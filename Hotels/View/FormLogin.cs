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
    public partial class FormLogin : Form
    {

        ControllerProfile controller;
        public FormLogin()
        {
            InitializeComponent();
            controller = new ControllerProfile();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Person currentuser= new Person();
            if (controller.Authentication(tBLogin.Text,tbPassword.Text))
            {
                MessageBox.Show("Добрий день,  " + ControllerProfile.User.Login, "Авторизація пройшла успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                controller.SaveRegister();
                ((FormMain)(MdiParent)).controller.AccessLevel(ControllerProfile.User);
                Close();
            }
            else
            {
                MessageBox.Show("Дані введені невірно", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.MdiParent = MdiParent;
            formRegister.Show();
            Close();
        }

        

        private void checkBoxShow_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
