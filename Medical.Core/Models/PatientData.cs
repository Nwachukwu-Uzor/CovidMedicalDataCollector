using System;
using System.Collections.Generic;
using System.Text;
using Medical.Core.Contracts;

namespace Medical.Core.Models
{
    public class PatientData : IPatientData
    {
        public IPatient Patient { get; }
        public decimal SurvivalRating { get; }

        public PatientData(IPatient patient, ISurvivalRater survivalRater)
        {
            Patient = patient;
            SurvivalRating = survivalRater.CalculateSurvivalRate(Patient);
        }
    }
}
