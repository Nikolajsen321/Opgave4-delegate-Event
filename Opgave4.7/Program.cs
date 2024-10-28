// See https://aka.ms/new-console-template for more information


//delegate bruges til at generalisere forskellige formaterings metoder

using Opgave4._7;

public delegate string FormatPersonName(string firstName, string lastName);

public class Start
{
    public static void Main(string[] args)
    {
        List<Person> people = new List<Person>
        {
            new Person("Alice", "Anderson"),
            new Person("Bob", "Brown"),
            new Person("Charlie", "Clark")
        };
        // Udskriv formateret efter Lastname, Firstname
        people.ForEach(p => p.PrintPersonName((F, L) => PersonUserClass.PrintFullNameLastNameFirst(F, L)));

        // Udskriv formateret i uppercase
        people.ForEach(p => p.PrintPersonName((F, L) => PersonUserClass.PrintFullNameAllCaps(F, L)));

        // Udskriv formateret i lowercase
        people.ForEach(p => p.PrintPersonName((F, L) => PersonUserClass.PrintFullNameLowerCase(F, L)));

        // Udskriv kun fornavn
        people.ForEach(p => p.PrintPersonName((F, L) => PersonUserClass.PrintShortName(F, L)));



        Console.WriteLine("Print people metode der tager sig af formatering i stedet for foreach kald hver gang");
        // Udskriv alle personer formateret efter Lastname, Firstname
        PersonUserClass.PrintPeople(people, (F, L) => PersonUserClass.PrintFullNameLastNameFirst(F, L));

        // Udskriv alle personer formateret i uppercase
        PersonUserClass.PrintPeople(people, (F, L) => PersonUserClass.PrintFullNameAllCaps(F, L));

        // Udskriv alle personer formateret i lowercase
        PersonUserClass.PrintPeople(people, (F, L) => PersonUserClass.PrintFullNameLowerCase(F, L));

        // Udskriv kun fornavn for alle personer
        PersonUserClass.PrintPeople(people, (F, L) => PersonUserClass.PrintShortName(F, L));


    }
   


    
}
