using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pojisteny
{
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
      
    public string GetFormattedInfo()
    {
        return $"Jméno: {Jmeno} {Prijmeni}, Věk: {Vek}, Telefon: {Telefon}";
    }

    public override string ToString()
    {
        return $"{Jmeno.PadRight(15)} {Prijmeni.PadRight(15)} {Vek} \t{Telefon}";        
    }
}