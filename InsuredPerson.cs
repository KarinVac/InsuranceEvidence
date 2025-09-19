using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InsuredPerson
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }
    public string PhoneNumber { get; private set; }

    public InsuredPerson(string firstName, string lastName, int age, string phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        PhoneNumber = phoneNumber;
    }
       
    public override string ToString()
    {
        return $"{FirstName.PadRight(15)} {LastName.PadRight(15)} {Age} \t{PhoneNumber}";
    }
}