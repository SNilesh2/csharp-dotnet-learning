using System;
using System.Security.Cryptography.X509Certificates;

public record Point(int X, int Y)
{
    public double Slope() => (double)Y / (double)X;
}


class Program
{
    static void Main()
    {
        //tuples
        int X = 10;
        int Y = 20;

        var points = (X, Y);

        Console.WriteLine(points.X + " " + points.Y);

        var pt = (X : 1, Y : 2);

        var slope = (double)pt.X / (double)pt.Y;

        Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}");

        //change X value in tuple
        pt.X = pt.X + 5;
        Console.WriteLine(pt);

        //create a new copy of the existing tuple
        var pt2 = pt with { Y = 8 };
        Console.WriteLine(pt2);

        var subscript = (A:0, B:1);
        Console.WriteLine(subscript);
        subscript = pt;
        Console.WriteLine(subscript);


        //different tuples
        var person = (Name: "Nilesh", Age: 22, Profession: "It");
        Console.WriteLine(person);
        var product = (name: "Guitar picks", style: "Triangle", Quantity: "105", Price: "0.10M");
        Console.WriteLine(product);

        //Record types

        Point p3 = new Point(5, 10);

        var p4 = p3 with { Y = 20 };

        Console.WriteLine(p3);
        Console.WriteLine(p4);

        //accessing record member
        Console.WriteLine(p3.Slope());
        Console.WriteLine(p4.Slope());

    }
}