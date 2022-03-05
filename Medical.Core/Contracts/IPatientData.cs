using System;
using System.Collections.Generic;
using System.Text;

namespace Medical.Core.Contracts
{
    interface IPatientData
    { 
        IPatient Patient { get; }
        decimal SurvivalRating { get; }
    }
}
