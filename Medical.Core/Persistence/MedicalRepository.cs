using System;
using System.Collections.Generic;
using System.Text;
using Medical.Core.Contracts;

namespace Medical.Core.Persistence
{
    public class MedicalRepository : IMedicalRepository
    {
        public IList<IPatientData> PatientsList { get; }

        public MedicalRepository(IList<IPatientData> patientsList)
        {
            PatientsList = patientsList;
        }

        public void AddPatientToDatabase(IPatientData patient)
        {
            PatientsList.Add(patient);
        }
    }
}
