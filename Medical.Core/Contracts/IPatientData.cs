using System;
using System.Collections.Generic;
using System.Text;

namespace Medical.Core.Contracts
{
    public interface IPatientData
    { 
        IPatient Patient { get; }
        decimal SurvivalRating { get; set; }
    }
}
