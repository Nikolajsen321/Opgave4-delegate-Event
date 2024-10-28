// See https://aka.ms/new-console-template for more information


using Opgave4._3;

public class Start
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Factroial(5));
        Console.WriteLine((5.FactorialEx()));

    }

    static int Factroial(int n )
    {
        if(n == 0)
        {
            return 1;
        }
        else 
        {
            return n * Factroial(n - 1);
        }

    }
}
