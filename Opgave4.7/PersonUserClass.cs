using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4._7
{
    public class PersonUserClass
    {
        // Format: Lastname, Firstname
        public static string PrintFullNameLastNameFirst(string firstname, string lastname)
        {
            return $"{lastname}, {firstname}";
        }

        // Format: Full name in all caps
        public static string PrintFullNameAllCaps(string firstname, string lastname)
        {
            return $"{firstname.ToUpper()} {lastname.ToUpper()}";
        }

        // Format: Full name in lowercase
        public static string PrintFullNameLowerCase(string firstname, string lastname)
        {
            return $"{firstname.ToLower()} {lastname.ToLower()}";
        }

        // Format: Short name (just firstname)
        public static string PrintShortName(string firstname, string lastname)
        {
            return $"{firstname}";
        }

        public static void PrintPeople(List<Person> people, FormatPersonName formatter)
        {
            people.ForEach(p => p.PrintPersonName(formatter));
        }

    }

 
}

