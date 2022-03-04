using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Medical.Core.Models;

namespace Medical.Tests.Models
{
    public class PersonTest
    {
        [InlineData("Uzor", "Nwachukwu", "Uzor Nwachukwu")]
        [InlineData("", "Nwachukwu", "Nwachukwu")]
        [InlineData("Uzor", "", "Uzor")]
        [Theory]
        public void PersonFullNameValidFirstAndLastName(string firstName, string lastName, string expected)
        {
            // Arrange
            Person person = new Person() { FirstName = firstName, LastName = lastName };

            // Act
            var actual = person.FullName;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}