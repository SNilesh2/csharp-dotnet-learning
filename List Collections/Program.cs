using System;

class Program
{
    static void Main()
    {
        List<string> names = ["<name>", "Nilesh", "Siddhaarth"];

        foreach (string name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }
        Console.WriteLine();
        //adding two new names 
        names.Add("Raji");
        names.Add("Nags");

        //remove one name from names
        names.Remove("<name>");

        //print names
        foreach (string name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}");
        }

        Console.WriteLine();

        Console.WriteLine($"My name is {names[0]}");
        Console.WriteLine($"I have added {names[2]} and {names[3]}");


        Console.WriteLine();
        // length of a list
        Console.WriteLine($"The list has {names.Count} names in it");

        Console.WriteLine();
        //search and sort
        int index = names.IndexOf("Nilesh");

        if(index==-1)
        {
            Console.WriteLine($"The index of function return {index} when the name is not found in list");
        }
        else
        {
            Console.WriteLine($"The name {names[index]} is found at index {index}");
        }

        Console.WriteLine();
        index = names.IndexOf("Not found");
        if (index == -1)
        {
            Console.WriteLine($"The index of function return {index} when the name is not found in list");
        }
        else
        {
            Console.WriteLine($"The name {names[index]} is found at index {index}");
        }


        Console.WriteLine();

        names.Sort();

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine();

        // fibonacci numbers
        List<int> fibonacci = [1, 1];
        int previous1 = fibonacci[fibonacci.Count - 1];
        int previous2 = fibonacci[fibonacci.Count - 2];

        fibonacci.Add(previous1 + previous2);

        foreach (int i in fibonacci)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();
        // write the code to generate the first 20 numbers in the sequence.
        List<int> fibo = [1, 1];
        for(int i=2;i<20;i++)
        {
            int prev1 = fibo[i-1];
            int prev2 = fibo[i-2];

            fibo.Add(prev1 + prev2);
        }

        Console.WriteLine("First 20 fibonacci numbers...");
        foreach (int i in fibo)
        {
            Console.WriteLine(i);
        }

    }
}