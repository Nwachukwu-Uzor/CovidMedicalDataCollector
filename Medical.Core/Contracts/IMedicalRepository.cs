using System;
using System.Collections.Generic;
using System.Text;

namespace Medical.Core.Contracts
{
    interface IMedicalRepository
    {
        List<IPatient> Patients { get; set; }
        ISurvivalRater SurvivalRater { get; set; }

    }
}
