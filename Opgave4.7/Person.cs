using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4._7
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        /*
         lave en metode i person klassen PrintPersonName der tager delegate som parameter 
        metoden skal bruge delegaten til at formatere personens navn og derefter udskrive resultat 
        til konsolen
         */

        public void PrintPersonName(FormatPersonName formater)
        {
            string formattedName = formater(FirstName,LastName);
            Console.WriteLine(formattedName);
        }

    }
}
