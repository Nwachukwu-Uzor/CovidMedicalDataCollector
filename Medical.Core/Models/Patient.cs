using System;
using System.Collections.Generic;
using System.Text;
using Medical.Core.Contracts;

namespace Medical.Core.Models
{
    public class Patient : IPatient
    {
        public IPerson PatientBio { get; private set; }
        public decimal HeartRate { get; set; }
        public decimal BodyTemp  { get; set; }
        public bool HasCardiacIssue { get; set; }
        public bool HasDiabeticHistory { get; set; }
        public bool HasFeverHistory { get; set; }

        public Patient(IPerson person)
        {
            PatientBio = person;
        }
    }
}