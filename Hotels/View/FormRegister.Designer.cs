﻿namespace Hotels.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword1 = new System.Windows.Forms.TextBox();
            this.tbPassword2 = new System.Windows.Forms.TextBox();
            this.dTPBirth = new System.Windows.Forms.DateTimePicker();
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
            this.rBMale = new System.Windows.Forms.RadioButton();
            this.rBFemale = new System.Windows.Forms.RadioButton();
            this.groupBoxPersonalData = new System.Windows.Forms.GroupBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxPersonalData.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(222, 329);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(116, 39);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "ОК";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(420, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 39);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Реєстрація";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(128, 22);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(98, 20);
            this.tbFirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ім\'я";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Прізвище";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Логін";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Емейл";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Пароль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Пароль";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Стать";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Дата народження";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(128, 55);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(98, 20);
            this.tbLastName.TabIndex = 12;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(100, 22);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 13;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(100, 65);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(98, 20);
            this.tbEmail.TabIndex = 14;
            // 
            // tbPassword1
            // 
            this.tbPassword1.Location = new System.Drawing.Point(100, 102);
            this.tbPassword1.Name = "tbPassword1";
            this.tbPassword1.PasswordChar = '*';
            this.tbPassword1.Size = new System.Drawing.Size(100, 20);
            this.tbPassword1.TabIndex = 15;
            // 
            // tbPassword2
            // 
            this.tbPassword2.Location = new System.Drawing.Point(100, 138);
            this.tbPassword2.Name = "tbPassword2";
            this.tbPassword2.PasswordChar = '*';
            this.tbPassword2.Size = new System.Drawing.Size(100, 20);
            this.tbPassword2.TabIndex = 16;
            // 
            // dTPBirth
            // 
            this.dTPBirth.CustomFormat = "dd.MM.yyyy";
            this.dTPBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPBirth.Location = new System.Drawing.Point(128, 87);
            this.dTPBirth.Name = "dTPBirth";
            this.dTPBirth.Size = new System.Drawing.Size(98, 20);
            this.dTPBirth.TabIndex = 18;
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.Location = new System.Drawing.Point(100, 174);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(114, 17);
            this.checkBoxShow.TabIndex = 19;
            this.checkBoxShow.Text = "Показати пароль";
            this.checkBoxShow.UseVisualStyleBackColor = true;
            this.checkBoxShow.CheckStateChanged += new System.EventHandler(this.checkBoxShow_CheckStateChanged);
            // 
            // rBMale
            // 
            this.rBMale.AutoSize = true;
            this.rBMale.Checked = true;
            this.rBMale.Location = new System.Drawing.Point(128, 121);
            this.rBMale.Name = "rBMale";
            this.rBMale.Size = new System.Drawing.Size(45, 17);
            this.rBMale.TabIndex = 20;
            this.rBMale.TabStop = true;
            this.rBMale.Text = "Чол";
            this.rBMale.UseVisualStyleBackColor = true;
            // 
            // rBFemale
            // 
            this.rBFemale.AutoSize = true;
            this.rBFemale.Location = new System.Drawing.Point(128, 144);
            this.rBFemale.Name = "rBFemale";
            this.rBFemale.Size = new System.Drawing.Size(44, 17);
            this.rBFemale.TabIndex = 21;
            this.rBFemale.Text = "Жін";
            this.rBFemale.UseVisualStyleBackColor = true;
            // 
            // groupBoxPersonalData
            // 
            this.groupBoxPersonalData.Controls.Add(this.tbTelephone);
            this.groupBoxPersonalData.Controls.Add(this.label2);
            this.groupBoxPersonalData.Controls.Add(this.label10);
            this.groupBoxPersonalData.Controls.Add(this.rBFemale);
            this.groupBoxPersonalData.Controls.Add(this.tbFirstName);
            this.groupBoxPersonalData.Controls.Add(this.rBMale);
            this.groupBoxPersonalData.Controls.Add(this.label3);
            this.groupBoxPersonalData.Controls.Add(this.dTPBirth);
            this.groupBoxPersonalData.Controls.Add(this.label8);
            this.groupBoxPersonalData.Controls.Add(this.label9);
            this.groupBoxPersonalData.Controls.Add(this.tbLastName);
            this.groupBoxPersonalData.Location = new System.Drawing.Point(40, 55);
            this.groupBoxPersonalData.Name = "groupBoxPersonalData";
            this.groupBoxPersonalData.Size = new System.Drawing.Size(247, 227);
            this.groupBoxPersonalData.TabIndex = 22;
            this.groupBoxPersonalData.TabStop = false;
            this.groupBoxPersonalData.Text = "Персональні дані:";
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(126, 178);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(100, 20);
            this.tbTelephone.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Телефон";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbLogin);
            this.groupBox2.Controls.Add(this.checkBoxShow);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbPassword2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbPassword1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbEmail);
            this.groupBox2.Location = new System.Drawing.Point(313, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 227);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Акаунт:";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 387);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxPersonalData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстрація";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.groupBoxPersonalData.ResumeLayout(false);
            this.groupBoxPersonalData.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword1;
        private System.Windows.Forms.TextBox tbPassword2;
        private System.Windows.Forms.DateTimePicker dTPBirth;
        private System.Windows.Forms.CheckBox checkBoxShow;
        private System.Windows.Forms.RadioButton rBMale;
        private System.Windows.Forms.RadioButton rBFemale;
        private System.Windows.Forms.GroupBox groupBoxPersonalData;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}