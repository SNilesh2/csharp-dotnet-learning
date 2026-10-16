using System;

class Program
{
    static void Main()
    {
        string textInt = "4503";
        int Int = Convert.ToInt32(textInt);
        Console.WriteLine(Int);

        string textLong = "2333330294209";
        long Long = Convert.ToInt64(textLong);
        Console.WriteLine(Long);

        string textDouble = "23.4342";
        double Double = Convert.ToDouble(textDouble);
        Console.WriteLine(Double);

        string textFloat = "34.54";
        float Float = Convert.ToSingle(textFloat);
        Console.WriteLine(Float);

        string textDecimal = "234.32";
        decimal Decimal = Convert.ToDecimal(textDecimal);
        Console.WriteLine(Decimal);
    }
}