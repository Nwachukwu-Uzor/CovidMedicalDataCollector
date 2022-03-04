using System;
using System.Collections.Generic;
using System.Text;

namespace Medical.Core.Contracts
{
    public interface ISurvivalRater
    {
        decimal CalculateSurvivalRate(IPatient patient);
    }
}
