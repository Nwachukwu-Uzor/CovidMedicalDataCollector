using System;
using System.Collections.Generic;
using System.Text;

using Medical.Core.Models;


namespace Medical.Core.Contracts
{
    public interface IMedicalRepository
    {
       List<PatientData> PatientsList { get; }

        void AddPatientToDatabase(PatientData PatientData);
    }
}
