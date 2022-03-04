using Medical.Core.Contracts;

namespace Medical.Core
{
    public interface IPatient
    {
        decimal BodyTemp { get; set; }
        decimal HeartRate { get; set; }
        IPerson PatientBio { get; }
        bool HasCardiacIssue { get; set; }
        bool HasDiabeticHistory { get; set; }
        bool HasFeverHistory { get; set; }
    }
}