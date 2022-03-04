using System;
using System.Collections.Generic;
using System.Text;
using Medical.Core.Models;
using Medical.Core.Services;
using Xunit;

namespace Medical.Tests.Services
{
    public class SurvivalRaterTest
    {
        [InlineData(41, 40, 90, true, true, true, 47)]
        [InlineData(42, 41, 107, false, true, true, 46)]
        [Theory]
        public void CalculateSurvivalRateCorrectly(int age, int temp, int heartRate, bool isDiabetic, bool hasCardiacArrest, bool visitedHospital, decimal expected )
        {
            // Arrange
            SurvivalRater survivalRater = new SurvivalRater();

            // Act
            var actual = survivalRater.CalculateSurvivalRate(new Patient(new Person() { Age = age })
            {
                HasCardiacIssue = hasCardiacArrest,
                HasDiabeticHistory = isDiabetic,
                HasFeverHistory = visitedHospital,
                BodyTemp = temp,
                HeartRate = heartRate
            });

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
