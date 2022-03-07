using Medical.Common;

namespace Medical.Core.Contracts
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; }
        int Age { get; set; }
        Gender Gender { get; set; }
    }
}
