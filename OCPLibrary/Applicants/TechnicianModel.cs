using OCPLibrary.Accounts;
using OCPLibrary.Applicants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    internal class TechnicianModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new Accounts.Accounts();
    }
}
