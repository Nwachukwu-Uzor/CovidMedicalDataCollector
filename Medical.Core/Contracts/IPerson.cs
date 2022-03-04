using System;
using System.Collections.Generic;
using System.Text;

namespace Medical.Core.Contracts
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; }
        int Age { get; set; }
    }
}
