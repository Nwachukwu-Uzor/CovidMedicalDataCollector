using System;
using System.Collections.Generic;
using System.Text;
using Medical.Core.Contracts;
using Medical.Core.Models;

namespace Medical.Core.Persistence
{
    public class MedicalRepository : IMedicalRepository
    {
        public List<PatientData> PatientsList { get; }
        public ISurvivalRater SurvivalRater { get; }

        public MedicalRepository(List<PatientData> patientsList, ISurvivalRater survivalRater)
        {
            PatientsList = patientsList;
            SurvivalRater = survivalRater;
        }


        public void AddPatientToDatabase(PatientData patient)
        {
            patient.SurvivalRating = SurvivalRater.CalculateSurvivalRate(patient.Patient);
            PatientsList.Add(patient);
        }
    }
}
