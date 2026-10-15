using Microsoft.VisualBasic;
using System;

class Program
{
    static void Main()
    {
        String name = "Nilesh";
        Console.Write("My name is ");
        Console.WriteLine(name);

        //use + to build a string from variables and constants
        Console.WriteLine("Hello " + name);

        //String Interpolation {}
        Console.WriteLine($"Hi {name},How are you!");

        //Work with strings
        String friend1 = "Siddhaarth";
        String friend2 = "Bharaninath";

        Console.WriteLine($"My friends are {friend1} and {friend2}");

        //String Length
        Console.WriteLine($"The name {friend1} has {friend1.Length} characters");
        Console.WriteLine($"The name {friend2} has {friend2.Length} characters");


        //String Functions
        Console.WriteLine(friend2.Contains("a"));
        Console.WriteLine(friend2.ToUpper());

        //Remove whitespace from strings
        String str = "           Nilesh.        ";

        String trimStart = str.TrimStart();
        Console.WriteLine($"[{trimStart}]");

        String trimEnd = str.TrimEnd();
        Console.WriteLine($"[{trimEnd}]");

        String trim = str.Trim();
        Console.WriteLine($"[{trim}]");


        //Search and replace text in strings
        String sayHello = "Hello world!";
        Console.WriteLine(sayHello);

        sayHello = sayHello.Replace("world!", "Nilesh!");
        Console.WriteLine(sayHello);


        //Challenge
        string songLyrics = "You say goodbye, and I say hello";
        Console.WriteLine(songLyrics.StartsWith("You"));
        Console.WriteLine(songLyrics.StartsWith("goodbye"));
        Console.WriteLine(songLyrics.EndsWith("hello"));
        Console.WriteLine(songLyrics.EndsWith("goodbye"));
    }
}