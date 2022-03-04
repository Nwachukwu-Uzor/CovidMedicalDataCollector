using System;
using Medical.Core.Contracts;

namespace Medical.Core.Models
{
    public class Person : IPerson
    {
        private string _fullName;
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string FullName {
            get
            {
                _fullName = FirstName;
                if (!string.IsNullOrWhiteSpace(_fullName))
                {

                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        _fullName += $" {LastName}";
                    }
                } else
                {
                    _fullName = LastName;
                }

                return _fullName.Trim();
            }
        }

        public int Age { get; set; }

        
    }
}
