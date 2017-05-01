using Hotels.Controller;
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
    public partial class FormRoomType : Form
    {
        ControllerRoomType controller;
        public FormRoomType()
        {
            InitializeComponent();
            Dictionary<string, TextBox> textBoxs = new Dictionary<string, TextBox>();
            textBoxs.Add("Name", tbName);
            textBoxs.Add("Description", tbDescription);
            textBoxs.Add("Price", tbPrice);
            textBoxs.Add("MaxPerson", tbMaxPerson);
            controller = new ControllerRoomType(dgvRoomType, bindingNavigatorRoomType, textBoxs);
            controller.FillColumns();
        }

        private void FormRoomType_Load(object sender, EventArgs e)
        {
            controller.LoadDB();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            controller.Save();
            controller.LoadDB();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            controller.Delete();
            controller.LoadDB();
        }
    }
}
