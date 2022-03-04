using System;
using Medical.Core.Contracts;

namespace Medical.Core.Services
{
    public class SurvivalRater : ISurvivalRater
    {
        const int HEARTRATETHRESHOLD = 85;
        const int TEMPERATURETHRESHOLD = 38;

        public decimal CalculateSurvivalRate(IPatient patient)
        {
            decimal survivalRate = 1m;

            if (patient.HasCardiacIssue && patient.PatientBio.Age > 40)
            {
                survivalRate += 7;
            }

            if (patient.HasDiabeticHistory)
            {
                survivalRate += 12;
            }

            if (patient.HasFeverHistory)
            {
                survivalRate += 15;
            }

            if (patient.BodyTemp > TEMPERATURETHRESHOLD)
            {
                survivalRate += (patient.BodyTemp - TEMPERATURETHRESHOLD) * 5;
            }

            if (patient.HeartRate > HEARTRATETHRESHOLD)
            {
                survivalRate += Math.Truncate((patient.HeartRate - HEARTRATETHRESHOLD)/5) * 2;
            }

            return survivalRate;
        }
    }
}
