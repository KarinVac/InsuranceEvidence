using InsuranceEvidence;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static EvidenceManager evidence = new EvidenceManager();

    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine(new string('-', 29));
            Console.WriteLine("Insured Persons Database");
            Console.WriteLine(new string('-', 29));
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1 - Add a new insured person");
            Console.WriteLine("2 - List all insured persons");
            Console.WriteLine("3 - Find an insured person");
            Console.WriteLine("4 - Exit");

            choice = ReadNumber("");

            switch (choice)
            {
                case 1:
                    AddInsuredPerson();
                    break;
                case 2:
                    ListAllInsuredPersons();
                    break;
                case 3:
                    FindInsuredPerson();
                    break;
                case 4:
                    Console.WriteLine("The application will now close.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    break;
            }

            if (choice != 4)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }

    static void AddInsuredPerson()
    {
        string firstName = ReadText("Enter first name:");
        string lastName = ReadText("Enter last name:");
        string phoneNumber = ReadText("Enter phone number:");

        int age = ReadNumber("Enter age: ");

        evidence.AddInsuredPerson(firstName, lastName, age, phoneNumber);
        Console.WriteLine("Data has been saved.");
    }

    static void ListAllInsuredPersons()
    {
        var list = evidence.ListAll();
        if (!list.Any())
        {
            Console.WriteLine("No insured persons are currently registered.");
            return;
        }

        foreach (var p in list)
        {
            Console.WriteLine(p);
        }
    }

    static void FindInsuredPerson()
    {
        string firstName = ReadText("Enter first name:");
        string lastName = ReadText("Enter last name:");

        var results = evidence.FindInsuredPerson(firstName, lastName);

        if (!results.Any())
        {
            Console.WriteLine("Insured person was not found.");
            return;
        }

        foreach (var p in results)
        {
            Console.WriteLine(p);
        }
    }

    static string ReadText(string prompt)
    {
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input cannot be empty. Please try again.");
            }
        } while (string.IsNullOrEmpty(input));
        return input;
    }

    static int ReadNumber(string prompt)
    {
        int number;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            if (!string.IsNullOrEmpty(prompt))
                Console.WriteLine("Invalid number. Please try again.");
        }
    }
}