using Medical.Core.Contracts;
using Medical.Core.Delegates;

namespace Medical.Core
{
    public interface IPatient : IPerson
    {
        string PatientID { get; }
        decimal BodyTemp { get; set; }
        decimal HeartRate { get; set; }
        bool HasCardiacIssue { get; set; }
        bool HasDiabeticHistory { get; set; }
        bool HasFeverHistory { get; set; }
        decimal SurvivalRating { get; }

        void CalculateSurvivalRating(SurvivalRatingCalculator survivalRatingCalculator);
    }
}