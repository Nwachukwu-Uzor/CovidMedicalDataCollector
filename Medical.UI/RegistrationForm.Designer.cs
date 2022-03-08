
namespace Medical.UI
{
    partial class RegistrationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NUDAge = new System.Windows.Forms.NumericUpDown();
            this.NUDHeartRate = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NUDTemperature = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbCardiac = new System.Windows.Forms.ComboBox();
            this.CmbDiabetic = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbFever = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.LinkToPatientsList = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHeartRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 87);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(359, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTER NEW PATIENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(41, 168);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.PlaceholderText = "Enter the Patients First Name";
            this.TxtFirstName.Size = new System.Drawing.Size(332, 27);
            this.TxtFirstName.TabIndex = 2;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(617, 168);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.PlaceholderText = "Enter the Patients Last Name";
            this.TxtLastName.Size = new System.Drawing.Size(332, 27);
            this.TxtLastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(617, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age";
            // 
            // NUDAge
            // 
            this.NUDAge.Location = new System.Drawing.Point(41, 280);
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
            this.NUDAge.Size = new System.Drawing.Size(229, 27);
            this.NUDAge.TabIndex = 6;
            this.NUDAge.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // NUDHeartRate
            // 
            this.NUDHeartRate.Location = new System.Drawing.Point(41, 405);
            this.NUDHeartRate.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NUDHeartRate.Name = "NUDHeartRate";
            this.NUDHeartRate.Size = new System.Drawing.Size(229, 27);
            this.NUDHeartRate.TabIndex = 8;
            this.NUDHeartRate.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(41, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Heart Rate (Beats Per Minute)";
            // 
            // CmbGender
            // 
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "MALE ",
            "FEMALE"});
            this.CmbGender.Location = new System.Drawing.Point(617, 279);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(246, 28);
            this.CmbGender.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(617, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender";
            // 
            // NUDTemperature
            // 
            this.NUDTemperature.Location = new System.Drawing.Point(617, 387);
            this.NUDTemperature.Maximum = new decimal(new int[] {
            41,
            0,
            0,
            0});
            this.NUDTemperature.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.NUDTemperature.Name = "NUDTemperature";
            this.NUDTemperature.Size = new System.Drawing.Size(229, 27);
            this.NUDTemperature.TabIndex = 12;
            this.NUDTemperature.Value = new decimal(new int[] {
            41,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(617, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Body Temperate (Degree Celcius)_";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(41, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(397, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Does the patient have cardiac related condition?";
            // 
            // CmbCardiac
            // 
            this.CmbCardiac.FormattingEnabled = true;
            this.CmbCardiac.Items.AddRange(new object[] {
            "NO",
            "YES"});
            this.CmbCardiac.Location = new System.Drawing.Point(617, 469);
            this.CmbCardiac.Name = "CmbCardiac";
            this.CmbCardiac.Size = new System.Drawing.Size(202, 28);
            this.CmbCardiac.TabIndex = 14;
            // 
            // CmbDiabetic
            // 
            this.CmbDiabetic.FormattingEnabled = true;
            this.CmbDiabetic.Items.AddRange(new object[] {
            "NO",
            "YES"});
            this.CmbDiabetic.Location = new System.Drawing.Point(617, 541);
            this.CmbDiabetic.Name = "CmbDiabetic";
            this.CmbDiabetic.Size = new System.Drawing.Size(202, 28);
            this.CmbDiabetic.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(41, 546);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(323, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Does the patient have diabetic history?";
            // 
            // CmbFever
            // 
            this.CmbFever.FormattingEnabled = true;
            this.CmbFever.Items.AddRange(new object[] {
            "NO",
            "YES"});
            this.CmbFever.Location = new System.Drawing.Point(617, 608);
            this.CmbFever.Name = "CmbFever";
            this.CmbFever.Size = new System.Drawing.Size(202, 28);
            this.CmbFever.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(41, 613);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(500, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "Has the patient suffered fever symptoms in the last two day?";
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.Black;
            this.BtnRegister.FlatAppearance.BorderSize = 0;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.Location = new System.Drawing.Point(383, 668);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(190, 43);
            this.BtnRegister.TabIndex = 19;
            this.BtnRegister.Text = "REGISTER";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // LinkToPatientsList
            // 
            this.LinkToPatientsList.AutoSize = true;
            this.LinkToPatientsList.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LinkToPatientsList.ForeColor = System.Drawing.Color.Teal;
            this.LinkToPatientsList.Location = new System.Drawing.Point(689, 723);
            this.LinkToPatientsList.Name = "LinkToPatientsList";
            this.LinkToPatientsList.Size = new System.Drawing.Size(186, 25);
            this.LinkToPatientsList.TabIndex = 20;
            this.LinkToPatientsList.Text = "View All Patients >>";
            this.LinkToPatientsList.Click += new System.EventHandler(this.LinkToPatientsList_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 768);
            this.Controls.Add(this.LinkToPatientsList);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.CmbFever);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CmbDiabetic);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CmbCardiac);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NUDTemperature);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbGender);
            this.Controls.Add(this.NUDHeartRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NUDAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRATION FORM";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHeartRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTemperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUDAge;
        private System.Windows.Forms.NumericUpDown NUDHeartRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NUDTemperature;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbCardiac;
        private System.Windows.Forms.ComboBox CmbDiabetic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbFever;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label LinkToPatientsList;
    }
}

