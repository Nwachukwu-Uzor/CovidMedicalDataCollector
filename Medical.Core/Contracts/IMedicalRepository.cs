using System;
using System.Collections.Generic;
using System.Text;


namespace Medical.Core.Contracts
{
    public interface IMedicalRepository
    {
       IList<IPatientData> PatientsList { get; }

        void AddPatientToDatabase(IPatientData PatientData);
    }
}
