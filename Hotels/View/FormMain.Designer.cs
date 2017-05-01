namespace Hotels
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.довідникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.itemHotels = new System.Windows.Forms.ToolStripMenuItem();
            this.itemRoomType = new System.Windows.Forms.ToolStripMenuItem();
            this.itemRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.довідникToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(782, 24);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "menuStrip1";
            // 
            // довідникToolStripMenuItem
            // 
            this.довідникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemPerson,
            this.itemHotels,
            this.itemRoomType,
            this.itemRoom,
            this.itemBooking,
            this.itemEmployee});
            this.довідникToolStripMenuItem.Name = "довідникToolStripMenuItem";
            this.довідникToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.довідникToolStripMenuItem.Text = "Довідник";
            // 
            // itemPerson
            // 
            this.itemPerson.Name = "itemPerson";
            this.itemPerson.Size = new System.Drawing.Size(152, 22);
            this.itemPerson.Text = "Користувачі";
            this.itemPerson.Click += new System.EventHandler(this.itemPerson_Click);
            // 
            // itemHotels
            // 
            this.itemHotels.Name = "itemHotels";
            this.itemHotels.Size = new System.Drawing.Size(152, 22);
            this.itemHotels.Text = "Готелі";
            this.itemHotels.Click += new System.EventHandler(this.itemHotels_Click);
            // 
            // itemRoomType
            // 
            this.itemRoomType.Name = "itemRoomType";
            this.itemRoomType.Size = new System.Drawing.Size(152, 22);
            this.itemRoomType.Text = "Типи кімнат";
            this.itemRoomType.Click += new System.EventHandler(this.itemRoomType_Click);
            // 
            // itemRoom
            // 
            this.itemRoom.Name = "itemRoom";
            this.itemRoom.Size = new System.Drawing.Size(152, 22);
            this.itemRoom.Text = "Кімнати";
            this.itemRoom.Click += new System.EventHandler(this.itemRoom_Click);
            // 
            // itemBooking
            // 
            this.itemBooking.Name = "itemBooking";
            this.itemBooking.Size = new System.Drawing.Size(152, 22);
            this.itemBooking.Text = "Бронювання";
            this.itemBooking.Click += new System.EventHandler(this.itemBooking_Click);
            // 
            // itemEmployee
            // 
            this.itemEmployee.Name = "itemEmployee";
            this.itemEmployee.Size = new System.Drawing.Size(152, 22);
            this.itemEmployee.Text = "Працівники";
            this.itemEmployee.Click += new System.EventHandler(this.itemEmployee_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 458);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem довідникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemPerson;
        private System.Windows.Forms.ToolStripMenuItem itemHotels;
        private System.Windows.Forms.ToolStripMenuItem itemRoomType;
        private System.Windows.Forms.ToolStripMenuItem itemRoom;
        private System.Windows.Forms.ToolStripMenuItem itemBooking;
        private System.Windows.Forms.ToolStripMenuItem itemEmployee;
    }
}

