
namespace Medical.UI
{
    partial class PatientsList
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
            this.DgvPatientsList = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeartRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDiabetic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HasCardiacIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasFever = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riskRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPatientsList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(467, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "PATIENTS";
            // 
            // DgvPatientsList
            // 
            this.DgvPatientsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPatientsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvPatientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPatientsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.Age,
            this.Gender,
            this.Temperature,
            this.HeartRate,
            this.IsDiabetic,
            this.HasCardiacIssue,
            this.hasFever,
            this.riskRate});
            this.DgvPatientsList.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DgvPatientsList.Location = new System.Drawing.Point(22, 181);
            this.DgvPatientsList.Name = "DgvPatientsList";
            this.DgvPatientsList.RowHeadersWidth = 51;
            this.DgvPatientsList.RowTemplate.Height = 29;
            this.DgvPatientsList.Size = new System.Drawing.Size(1231, 234);
            this.DgvPatientsList.TabIndex = 1;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "FULL NAME";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            // 
            // Age
            // 
            this.Age.HeaderText = "AGE";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "GENDER";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            // 
            // Temperature
            // 
            this.Temperature.HeaderText = "BODY TEMPERATURE";
            this.Temperature.MinimumWidth = 6;
            this.Temperature.Name = "Temperature";
            // 
            // HeartRate
            // 
            this.HeartRate.HeaderText = "HEART RATE (BMP)";
            this.HeartRate.MinimumWidth = 6;
            this.HeartRate.Name = "HeartRate";
            // 
            // IsDiabetic
            // 
            this.IsDiabetic.HeaderText = "IS PATIENT DIABETIC";
            this.IsDiabetic.MinimumWidth = 6;
            this.IsDiabetic.Name = "IsDiabetic";
            // 
            // HasCardiacIssue
            // 
            this.HasCardiacIssue.HeaderText = "DOES PATIENT HAVE CARDIAC ISSUE";
            this.HasCardiacIssue.MinimumWidth = 6;
            this.HasCardiacIssue.Name = "HasCardiacIssue";
            // 
            // hasFever
            // 
            this.hasFever.HeaderText = "DOES PATIENT HAVE FEVER";
            this.hasFever.MinimumWidth = 6;
            this.hasFever.Name = "hasFever";
            // 
            // riskRate
            // 
            this.riskRate.HeaderText = "RISK RATE";
            this.riskRate.MinimumWidth = 6;
            this.riskRate.Name = "riskRate";
            // 
            // PatientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1317, 569);
            this.Controls.Add(this.DgvPatientsList);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "PatientsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PATIENTS LIST";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPatientsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvPatientsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeartRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDiabetic;
        private System.Windows.Forms.DataGridViewTextBoxColumn HasCardiacIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasFever;
        private System.Windows.Forms.DataGridViewTextBoxColumn riskRate;
    }
}