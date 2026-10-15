using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Normal operations");
        WorkWithIntegers();

        Console.WriteLine("Precendence");
        Precendence();

        Console.WriteLine("Limits");
        Limits();

    }
    static void WorkWithIntegers()
    {
        int a = 10;
        int b = 5;

        int c = a + b;
        Console.WriteLine(c);

        c = a - b;
        Console.WriteLine(c);

        c = a * b;
        Console.WriteLine(c);

        c = a / b;
        Console.WriteLine(c);

    }

    static void Precendence()
    {
        int a = 2;
        int b = 3;
        int c = 4;

        int d = a + b * c;
        Console.WriteLine(d);

        //forcing different order using paranthesis
        d = (a + b) * c;  
        Console.WriteLine(d);
    }

    static void Limits()
    {
        //Int
        int min = int.MinValue;
        int max = int.MaxValue;
        Console.WriteLine($"Integer : {min} to {max}");

        int what = max + 3;
        Console.WriteLine($"An example for overflow : {what} ");

        //Float
        float fmin = float.MinValue;
        float fmax = float.MaxValue;
        Console.WriteLine($"Float : {fmin} to {fmax}");

        //Double
        double dmin = double.MinValue;
        double dmax = double.MaxValue;
        Console.WriteLine($"Double : {dmin} to {dmax}");

        double a = 5;
        double b = 4;
        double c = 2;
        double d = (a + b) / c;

        Console.WriteLine(d);


        double third = 1.0 / 3.0;
        Console.WriteLine(third);

        //Decimal
        decimal decMin = decimal.MinValue;
        decimal decMax = decimal.MaxValue;

        Console.WriteLine($"Decimal : {decMin} to {decMax}");

        decimal x = 1.0M;
        decimal y = 3.0M;

        Console.WriteLine(x / y);
    }
}