// See https://aka.ms/new-console-template for more information

using Opgave4._4;

public class Start
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Power(2, 3));
        Console.WriteLine(2.PowerExten(2));

    }
    static int Power(int n, int p)
    {
        if (p == 0)
        {
            return 1;
        }
        else
        {
            return n * Power(n,(p - 1));
        }
    }

}