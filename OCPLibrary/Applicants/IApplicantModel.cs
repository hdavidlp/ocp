using OCPLibrary.Accounts;

namespace OCPLibrary.Applicants
{
    public interface IApplicantModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; }
    }
}