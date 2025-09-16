using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceEvidence
{
    public class EvidenceManager
    {
        private List<InsuredPerson> insuredPersons = new List<InsuredPerson>();

        public void AddInsuredPerson(string firstName, string lastName, int age, string phoneNumber)
        {
            insuredPersons.Add(new InsuredPerson(firstName, lastName, age, phoneNumber));
        }

        public IEnumerable<InsuredPerson> ListAll()
        {
            return insuredPersons;
        }
        public IEnumerable<InsuredPerson> FindInsuredPerson(string firstName, string lastName)
        {
            return insuredPersons.Where(p => p.FirstName.ToLower() == firstName.ToLower() && p.LastName.ToLower() == lastName.ToLower());
        }
    }
}