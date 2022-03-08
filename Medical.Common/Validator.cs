using System;
using System.Collections.Generic;
using System.Text;

namespace Medical.Common
{
    public class Validator
    {
        public static bool ValidatePatientName(string firstName, string lastName )
        {
            return (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName)) ? false : true;
        }
    }
}
