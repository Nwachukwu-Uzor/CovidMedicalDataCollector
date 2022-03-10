using System.Collections.Generic;

using Medical.Core.Models;


namespace Medical.Core.Contracts
{
    public interface IMedicalRepository
    {
       IList<Patient> PatientsList { get; }

        void AddPatientToDatabase(Patient PatientData);
    }
}
