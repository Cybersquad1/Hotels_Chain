namespace Hotels.View
{
    partial class FormRegister
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tBLogin = new System.Windows.Forms.TextBox();
            this.tBEmail = new System.Windows.Forms.TextBox();
            this.tBPassword1 = new System.Windows.Forms.TextBox();
            this.tBPassword2 = new System.Windows.Forms.TextBox();
            this.cBGender = new System.Windows.Forms.ComboBox();
            this.dTPDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(375, 329);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(116, 39);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "ОК";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(542, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 39);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Вийти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Реєстрація";
            // 
            // tBFirstName
            // 
            this.tBFirstName.Location = new System.Drawing.Point(169, 83);
            this.tBFirstName.Name = "tBFirstName";
            this.tBFirstName.Size = new System.Drawing.Size(100, 20);
            this.tBFirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ім\'я";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Прізвище";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Логін";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Емейл";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Пароль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Пароль";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Стать";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Дата народження";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(169, 127);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 12;
            // 
            // tBLogin
            // 
            this.tBLogin.Location = new System.Drawing.Point(169, 173);
            this.tBLogin.Name = "tBLogin";
            this.tBLogin.Size = new System.Drawing.Size(100, 20);
            this.tBLogin.TabIndex = 13;
            // 
            // tBEmail
            // 
            this.tBEmail.Location = new System.Drawing.Point(169, 214);
            this.tBEmail.Name = "tBEmail";
            this.tBEmail.Size = new System.Drawing.Size(100, 20);
            this.tBEmail.TabIndex = 14;
            // 
            // tBPassword1
            // 
            this.tBPassword1.Location = new System.Drawing.Point(493, 76);
            this.tBPassword1.Name = "tBPassword1";
            this.tBPassword1.PasswordChar = '*';
            this.tBPassword1.Size = new System.Drawing.Size(100, 20);
            this.tBPassword1.TabIndex = 15;
            // 
            // tBPassword2
            // 
            this.tBPassword2.Location = new System.Drawing.Point(493, 116);
            this.tBPassword2.Name = "tBPassword2";
            this.tBPassword2.PasswordChar = '*';
            this.tBPassword2.Size = new System.Drawing.Size(100, 20);
            this.tBPassword2.TabIndex = 16;
            // 
            // cBGender
            // 
            this.cBGender.FormattingEnabled = true;
            this.cBGender.Location = new System.Drawing.Point(493, 169);
            this.cBGender.Name = "cBGender";
            this.cBGender.Size = new System.Drawing.Size(139, 21);
            this.cBGender.TabIndex = 17;
            // 
            // dTPDate
            // 
            this.dTPDate.Location = new System.Drawing.Point(493, 211);
            this.dTPDate.Name = "dTPDate";
            this.dTPDate.Size = new System.Drawing.Size(139, 20);
            this.dTPDate.TabIndex = 18;
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.Location = new System.Drawing.Point(611, 76);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(114, 17);
            this.checkBoxShow.TabIndex = 19;
            this.checkBoxShow.Text = "Показати пароль";
            this.checkBoxShow.UseVisualStyleBackColor = true;
            this.checkBoxShow.CheckStateChanged += new System.EventHandler(this.checkBoxShow_CheckStateChanged);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 398);
            this.Controls.Add(this.checkBoxShow);
            this.Controls.Add(this.dTPDate);
            this.Controls.Add(this.cBGender);
            this.Controls.Add(this.tBPassword2);
            this.Controls.Add(this.tBPassword1);
            this.Controls.Add(this.tBEmail);
            this.Controls.Add(this.tBLogin);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegister);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tBLogin;
        private System.Windows.Forms.TextBox tBEmail;
        private System.Windows.Forms.TextBox tBPassword1;
        private System.Windows.Forms.TextBox tBPassword2;
        private System.Windows.Forms.ComboBox cBGender;
        private System.Windows.Forms.DateTimePicker dTPDate;
        private System.Windows.Forms.CheckBox checkBoxShow;
    }
}