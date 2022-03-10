using System;
using System.Collections.Generic;
using System.Text;
using Medical.Core.Contracts;
using Medical.Core.Models;

namespace Medical.Core.Persistence
{
    public class MedicalRepository : IMedicalRepository
    {
        public IList<Patient> PatientsList { get; }
        public ISurvivalRater SurvivalRater { get; }
        public MedicalRepository(IList<Patient> patientsList, ISurvivalRater survivalRater)
        {
            PatientsList = patientsList;
            SurvivalRater = survivalRater;
        }


        public void AddPatientToDatabase(Patient patient)
        {
            patient.CalculateSurvivalRating(SurvivalRater.CalculateSurvivalRate);
            PatientsList.Add(patient);
        }
    }
}
