// See https://aka.ms/new-console-template for more information
using Opgave4._1;

public delegate int Operation(int a, int b);
public class Start
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string test = "Hello";
        Console.WriteLine(test.ChechForStringSizeIsOrUnder5());


        //Opgave 4.1 a
        CalculateAndDisplay(2, 3, Add);

    }


    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Multiplication(int a, int b)
    {
        return (a * b);
    }

    static void CalculateAndDisplay(int a, int b, Operation operation)
    {
        Console.WriteLine($"a = {a}  b = {b}");
        int result = operation(a, b);
        Console.WriteLine($"resultatet af {a} og {b} er = {result}");
    }
}




