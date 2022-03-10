using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medical.Core.Services;
using Medical.Core.Models;
using Medical.Core.Persistence;
using Medical.Common;

namespace Medical.UI
{
    public partial class RegistrationForm : Form
    {
        public MedicalRepository PatientMedicalRepository { get; } 
        public RegistrationForm()
        {
            InitializeComponent();
            SetStartUpValuesForComboBoxes();
            var PatientsList = new List<Patient>();
            var SurvivalRater = new SurvivalRater();
            PatientMedicalRepository = new MedicalRepository(PatientsList, SurvivalRater);
        }

        public void SetStartUpValuesForComboBoxes()
        {
            CmbCardiac.SelectedIndex = 0;
            CmbDiabetic.SelectedIndex = 0;
            CmbGender.SelectedIndex = 0;
            CmbFever.SelectedIndex = 1;
        }

        public void ClearInputs()
        {
            SetStartUpValuesForComboBoxes();
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            NUDAge.Value = 20;
            NUDHeartRate.Value = 60;
            NUDTemperature.Value = 35;
        }

        public void RegisterNewPatient()
        {
            string firstName = TxtFirstName.Text;
            string lastName = TxtLastName.Text;

            if (!Validator.ValidatePatientName(firstName, lastName))
            {
                MessageBox.Show("Please provide a valid first and/or last name for patient", "Invalid PatientName");
                return;
            }

            var person = new Person()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = (int)NUDAge.Value,
                Gender = CmbGender.SelectedItem.ToString() == Gender.MALE.ToString() ? Gender.MALE : Gender.FEMALE
            };

            var patient = new Patient(person)
            {
                HeartRate = (int)NUDHeartRate.Value,
                BodyTemp = (int)NUDTemperature.Value,
                HasCardiacIssue = CmbCardiac.SelectedItem.ToString() == "YES" ? true : false,
                HasDiabeticHistory = CmbDiabetic.SelectedItem.ToString() == "YES" ? true : false,
                HasFeverHistory = CmbFever.SelectedItem.ToString() == "YES" ? true : false
            };
            PatientMedicalRepository.AddPatientToDatabase(patient);

            MessageBox.Show("Patient successfully added", "Registration success!");
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterNewPatient();
            ClearInputs();
        }

        private void LinkToPatientsList_Click(object sender, EventArgs e)
        {
            var patientList = new PatientsList(PatientMedicalRepository);
            patientList.Show();
        }
    }
}
