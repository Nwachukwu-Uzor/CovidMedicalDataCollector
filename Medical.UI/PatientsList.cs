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
                    patientData.FullName,
                    patientData.Age,
                    patientData.Gender,
                    patientData.BodyTemp,
                    patientData.HeartRate,
                    patientData.HasDiabeticHistory ? "YES" : "NO",
                    patientData.HasCardiacIssue ? "YES" : "NO",
                    patientData.HasFeverHistory ? "YES" : "NO",
                    patientData.SurvivalRating
                );
            }
        }
    }
}
