// See https://aka.ms/new-console-template for more information
using Opgave4._2;

public delegate void Warning();
public class Start
{
    public static void Main(string[] args)
    {
        Powerplant powerplant = new Powerplant();
        powerplant.SetWarnning(WarrningToConsole);
        powerplant.SetWarnning(AdditionalWarningToConsole);
        powerplant.HeatUp();

    }
    static void WarrningToConsole()
    {
        Console.WriteLine("Advarsel temperatur for høj");

    }

    static void AdditionalWarningToConsole()
    {
        Console.WriteLine("Yderlige advarsel ");
    }
    }

