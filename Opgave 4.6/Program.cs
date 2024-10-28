// See https://aka.ms/new-console-template for more information

using Opgave_4._6;
using System.Diagnostics.Metrics;

public class Start
{
    public static void Main(string[] args)
    {
        List<Person> people = new List<Person>()
        { new Person(25,30.5,"Hans"),
          new Person(30, 85.0, "Bob"),
          new Person(22, 65.0, "Charlie"),
          new Person(35, 90.5, "David")
        };

        // Sortér efter alder
        people.Sort(new ByAgeSorter());
        Console.WriteLine("Sorteret efter alder:");
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }

        // Sortér efter vægt
        people.Sort(new ByWeightSorter());
        Console.WriteLine("---------Sorteret efter vægt:--------");
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }

        // Sortér efter navn
        people.Sort(new ByNameSorter());
        Console.WriteLine("------Sorteret efter navn:---------");
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }



        /*
         Man kan i stedet for at lave 3 forskellige klasser med en comparer interface 
         kan man burge lambda funktioner til at stå for sortering logikken 
         */

        Console.WriteLine("----Lambda sortering ----");
        people.Sort((x,y) => x.Age.CompareTo(y.Age));

        Console.WriteLine("Sorteret efter alder (lambda):");
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }

    }
}