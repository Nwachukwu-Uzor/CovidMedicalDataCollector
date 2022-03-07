using Medical.Core.Contracts;

namespace Medical.Core
{
    public interface IPatient
    {
        string PatientID { get; }
        IPerson PatientBio { get; }
        decimal BodyTemp { get; set; }
        decimal HeartRate { get; set; }
        bool HasCardiacIssue { get; set; }
        bool HasDiabeticHistory { get; set; }
        bool HasFeverHistory { get; set; }
    }
}