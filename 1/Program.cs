using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine(f(x));
    }

    static double f(double x)
    {
        if (Math.Pow(x,2) <= 4)
        { 
            return 2; 
        }
        else 
        { 
            return 1 + f(x-((4*Math.Abs(x))/x));
        }
    }
}