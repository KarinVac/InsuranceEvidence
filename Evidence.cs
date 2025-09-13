using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    public class Evidence
    {
        private List<Pojisteny> pojisteni = new List<Pojisteny>();

        public void PridejPojisteneho(string jmeno, string prijmeni, int vek, string telefon)
        {
            pojisteni.Add(new Pojisteny(jmeno, prijmeni, vek, telefon));
        }       
        public IEnumerable<Pojisteny> VypisVsechny()
        {
            return pojisteni;
        }
        public IEnumerable<Pojisteny> VyhledejPojisteneho(string jmeno, string prijmeni)
        {
            return pojisteni.Where(p =>
                string.Equals(p.Jmeno, jmeno, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(p.Prijmeni, prijmeni, StringComparison.OrdinalIgnoreCase));
        }
    }
}
