using System;
using System.Collections.Generic;
using System.Text;
using Medical.Core.Models;
using Medical.Core.Services;
using Xunit;

namespace Medical.Tests.Models
{
    public class PatientDataTest
    {
        [InlineData(41, 40, 90, true, true, true, 47)]
        [InlineData(42, 41, 107, false, true, true, 46)]
        [Theory]
        public void PatientDataCorrectlyCalculatesSurvivalRatingForAPatient(int age, int temp, int heartRate, bool isDiabetic, bool hasCardiacArrest, bool visitedHospital, decimal expected)
        {
            // Arrange
            

            var person = new Person() { Age = age };

            var patient = new Patient(person)
            {
                HasCardiacIssue = hasCardiacArrest,
                HasDiabeticHistory = isDiabetic,
                HasFeverHistory = visitedHospital,
                BodyTemp = temp,
                HeartRate = heartRate
            };


            var survivalRater = new SurvivalRater();

            var patientData = new PatientData(patient, survivalRater);
            // Act
            var actual = patientData.SurvivalRating;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
