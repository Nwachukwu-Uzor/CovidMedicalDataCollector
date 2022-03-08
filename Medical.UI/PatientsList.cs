using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Medical.Core.Contracts;

namespace Medical.UI
{
    public partial class PatientsList : Form
    {
        public IMedicalRepository MedicalRepository { get; }
        public PatientsList(IMedicalRepository medicalRepository)
        {
            InitializeComponent();
            MedicalRepository = medicalRepository;
            RenderPatients();
        }

        public void RenderPatients()
        {
            foreach(var patientData in MedicalRepository.PatientsList)
            {
                DgvPatientsList.Rows.Add(
                    patientData.Patient.PatientBio.FullName,
                    patientData.Patient.PatientBio.Age,
                    patientData.Patient.PatientBio.Gender,
                    patientData.Patient.BodyTemp,
                    patientData.Patient.HeartRate,
                    patientData.Patient.HasDiabeticHistory ? "YES" : "NO",
                    patientData.Patient.HasCardiacIssue ? "YES" : "NO",
                    patientData.Patient.HasFeverHistory ? "YES" : "NO",
                    patientData.SurvivalRating
                );
            }
        }
    }
}
