using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    public class Pojisteny
    {   //vlastnosti mají public get a private set - lze je číst z jiných tříd, ale měnit jen uvnitř této třídy
        // - data jsou nastavena pouze při vytvoření objektu.
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public int Vek { get; private set; }
        public string Telefon { get; private set; }

        public Pojisteny(string jmeno, string prijmeni, int vek, string telefon)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Telefon = telefon;
        }
        // Výpis dat o pojištěném ve snadno čitelném formátu.
        public override string ToString()
        {
            return $"{Jmeno} {Prijmeni} {Vek} {Telefon}";
        }
    }
}
