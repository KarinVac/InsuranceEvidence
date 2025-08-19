using EvidencePojisteni;
using System;
using System.Collections.Generic;

class Program
{   // Vytvoření instance třídy Evidence
    static Evidence evidence = new Evidence();

    static void Main(string[] args)
    {
        int volba = 0;
        // Cyklus 'while' zajistí, že se menu bude opakovat, dokud uživatel nezadá číslo 4
        while (volba != 4)
        {
            Console.Clear();
            Console.WriteLine(new string('-', 29));
            Console.WriteLine("Evidence pojistenych");
            Console.WriteLine(new string('-', 29));
            Console.WriteLine("Vyberte si akci:");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.WriteLine("3 - Vyhledat pojištěného");
            Console.WriteLine("4 - Konec");

            volba = NactiCislo("");

            switch (volba)
            {
                case 1:
                    PridejPojisteneho();
                    break;
                case 2:
                    VypisVsechnyPojistene();
                    break;
                case 3:
                    VyhledejPojisteneho();
                    break;
                case 4:
                    Console.WriteLine("Aplikace se ukončí.");
                    break;
                default:
                    Console.WriteLine("Neplatná volba, stiskněte klávesu a zkuste to znovu.");
                    break;
            }

            if (volba != 4)
            {
                Console.WriteLine("\nPokračujte libovolnou klávesou...");
                Console.ReadKey();
            }
        }
    }

    static void PridejPojisteneho()
    {
        // Volání metody NactiText, která validuje jméno, příjmení a telefon.
        string jmeno = NactiText("Zadejte jméno pojištěného:");
        string prijmeni = NactiText("Zadejte příjmení:");
        string telefon = NactiText("Zadejte telefonní číslo:");

        int vek = NactiCislo("Zadejte vek: ");

        evidence.PridejPojisteneho(jmeno, prijmeni, vek, telefon);
        Console.WriteLine("Data byla uložena.");
    }

    static void VypisVsechnyPojistene()
    {
        var seznam = evidence.VypisVsechny();
        if (!seznam.Any())
        {
            Console.WriteLine("Zatím nejsou evidováni žádní pojištění.");
            return;
        }
        // 'var' automaticky určí, že 'p' je typu Pojisteny.
        foreach (var p in seznam)
        {
            Console.WriteLine(p);
        }
    }

    static void VyhledejPojisteneho()
    {
        string jmeno = NactiText("Zadejte jméno pojištěného:");
        string prijmeni = NactiText("Zadejte příjmení:");

        var vysledky = evidence.VyhledejPojisteneho(jmeno, prijmeni);

        if (!vysledky.Any())
        {
            Console.WriteLine("Pojištěný nebyl nalezen.");
            return;
        }

        foreach (var p in vysledky)
        {
            Console.WriteLine(p);
        }
    }

    // Tato metoda zajišťuje, že uživatel zadá neprázdný textový vstup.    
    static string NactiText(string vyzva)
    {
        string vstup;
        do
        {
            Console.Write(vyzva);
            vstup = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(vstup))
            {
                Console.WriteLine("Vstup nemůže být prázdný. Zkuste to znovu.");
            }
        } while (string.IsNullOrEmpty(vstup));
        return vstup;
    }

    // Tato metoda zajišťuje, že uživatel zadá platné celé číslo.
    // Opakuje se, dokud není vstup správný, a chrání tak program před chybou
    static int NactiCislo(string vyzva)
    {
        int cislo;
        while (true)
        {
            Console.Write(vyzva);            
            if (int.TryParse(Console.ReadLine(), out cislo))
            {
                return cislo;
            }
            if (!string.IsNullOrEmpty(vyzva))
            Console.WriteLine("Neplatné číslo. Zkuste to znovu.");
        }
    }
}