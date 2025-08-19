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
        // Metoda pro vypsání všech pojištěných.
        public IEnumerable<Pojisteny> VypisVsechny()
        {
            return pojisteni;
        }
        //LINQ výraz pro vyhledání pojištěného podle jména a příjmení.
        // "p" je dočasná proměnná pro každý prvek v kolekci
        // .ToLower() převádí text na malá písmena
        public IEnumerable<Pojisteny> VyhledejPojisteneho(string jmeno, string prijmeni)
        {
            return pojisteni.Where(p => p.Jmeno.ToLower() == jmeno.ToLower() && p.Prijmeni.ToLower() == prijmeni.ToLower());
        }
    }
}
