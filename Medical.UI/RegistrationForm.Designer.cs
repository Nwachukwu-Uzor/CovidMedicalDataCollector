namespace Medical.UI
{
    partial class RegistrationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NUDAge = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbDiabeticHistory = new System.Windows.Forms.ComboBox();
            this.NUDTemperature = new System.Windows.Forms.NumericUpDown();
            this.NUDHeartRate = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbFeverSymptom = new System.Windows.Forms.ComboBox();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.LblViewAll = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHeartRate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 65);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTER NEW PATIENT";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(44, 134);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(208, 20);
            this.TxtFirstName.TabIndex = 2;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(493, 134);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(208, 20);
            this.TxtLastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(490, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // NUDAge
            // 
            this.NUDAge.Location = new System.Drawing.Point(44, 214);
            this.NUDAge.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.NUDAge.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NUDAge.Name = "NUDAge";
            this.NUDAge.Size = new System.Drawing.Size(187, 20);
            this.NUDAge.TabIndex = 5;
            this.NUDAge.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Body Temperature";
            // 
            // CmbDiabeticHistory
            // 
            this.CmbDiabeticHistory.FormattingEnabled = true;
            this.CmbDiabeticHistory.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.CmbDiabeticHistory.Location = new System.Drawing.Point(552, 387);
            this.CmbDiabeticHistory.Name = "CmbDiabeticHistory";
            this.CmbDiabeticHistory.Size = new System.Drawing.Size(149, 21);
            this.CmbDiabeticHistory.TabIndex = 11;
            // 
            // NUDTemperature
            // 
            this.NUDTemperature.Location = new System.Drawing.Point(44, 302);
            this.NUDTemperature.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.NUDTemperature.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NUDTemperature.Name = "NUDTemperature";
            this.NUDTemperature.Size = new System.Drawing.Size(187, 20);
            this.NUDTemperature.TabIndex = 12;
            this.NUDTemperature.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // NUDHeartRate
            // 
            this.NUDHeartRate.Location = new System.Drawing.Point(493, 302);
            this.NUDHeartRate.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.NUDHeartRate.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NUDHeartRate.Name = "NUDHeartRate";
            this.NUDHeartRate.Size = new System.Drawing.Size(208, 20);
            this.NUDHeartRate.TabIndex = 14;
            this.NUDHeartRate.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(490, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Heart Rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Does the patient have diabetic history?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(405, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Has the patient suffered fever symptom in the last 2 days?";
            // 
            // CmbFeverSymptom
            // 
            this.CmbFeverSymptom.FormattingEnabled = true;
            this.CmbFeverSymptom.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.CmbFeverSymptom.Location = new System.Drawing.Point(552, 450);
            this.CmbFeverSymptom.Name = "CmbFeverSymptom";
            this.CmbFeverSymptom.Size = new System.Drawing.Size(149, 21);
            this.CmbFeverSymptom.TabIndex = 16;
            // 
            // CmbGender
            // 
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.CmbGender.Location = new System.Drawing.Point(493, 225);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(208, 21);
            this.CmbGender.TabIndex = 18;
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.Black;
            this.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegister.FlatAppearance.BorderSize = 0;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.Location = new System.Drawing.Point(315, 507);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(139, 35);
            this.BtnRegister.TabIndex = 19;
            this.BtnRegister.Text = "REGISTER";
            this.BtnRegister.UseVisualStyleBackColor = false;
            // 
            // LblViewAll
            // 
            this.LblViewAll.AutoSize = true;
            this.LblViewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblViewAll.ForeColor = System.Drawing.Color.Maroon;
            this.LblViewAll.Location = new System.Drawing.Point(290, 577);
            this.LblViewAll.Name = "LblViewAll";
            this.LblViewAll.Size = new System.Drawing.Size(216, 16);
            this.LblViewAll.TabIndex = 20;
            this.LblViewAll.Text = "View All Registered Patient >>";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 630);
            this.Controls.Add(this.LblViewAll);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.CmbGender);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CmbFeverSymptom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NUDHeartRate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NUDTemperature);
            this.Controls.Add(this.CmbDiabeticHistory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUDAge);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRATION";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHeartRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUDAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbDiabeticHistory;
        private System.Windows.Forms.NumericUpDown NUDTemperature;
        private System.Windows.Forms.NumericUpDown NUDHeartRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbFeverSymptom;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label LblViewAll;
    }
}

