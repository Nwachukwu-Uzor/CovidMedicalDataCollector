using Medical.Core.Contracts;
using Medical.Core.Delegates;

namespace Medical.Core.Models
{
    public class Patient : Person, IPatient
    {
        public string PatientID { get; }
        public decimal HeartRate { get; set; }
        public decimal BodyTemp  { get; set; }
        public bool HasCardiacIssue { get; set; }
        public bool HasDiabeticHistory { get; set; }
        public bool HasFeverHistory { get; set; }

        public decimal SurvivalRating { get; private set; }

        public Patient(IPerson person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            Gender = person.Gender;
            Age = person.Age;
        }

        public void CalculateSurvivalRating(SurvivalRatingCalculator survivalRatingCalculator)
        {
            SurvivalRating = survivalRatingCalculator(this);
        }
    }
}