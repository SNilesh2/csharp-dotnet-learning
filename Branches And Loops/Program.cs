using System;
using System.Collections.Concurrent;

class Program
{
    static void Main()
    {
        // If Else
        int a = 5;
        int b = 3;


        if (a + b > 10)
        {
            Console.WriteLine("The sum is greater than 10");
        }
        else
        {
            Console.WriteLine("The sum is not greater than 10");
        }


        int x = 2;
        int y = 2;
        int z = 7;

        // && and operator
        if ((x + y + z) > 10 && (a == b))
        {
            Console.WriteLine("The sum is greater than 10 and a is equal to b");
        }
        else
        {
            Console.WriteLine("The sum is not greater than 10 or a and b are not equal");
        }


        // || or opreator
        if ((x + y + z) > 10 || (a > b))
        {
            Console.WriteLine("The sum is greater than 10 or a is greater than b");
        }
        else
        {
            Console.WriteLine("The sum is not greater than 10 and a is not greater than b");
        }


        Console.WriteLine("While Loop");

        int counter = 0;
        while(counter < 10)
        {
            Console.WriteLine($"The counter is {counter}");
            counter++;
        }

        Console.WriteLine("Do While");

        counter = 0;
        do
        {
            Console.WriteLine($"The counter is {counter}");
            counter++;
        } while (counter < 10);


        for(int i=0;i<5;i++)
        {
            Console.WriteLine("The value of i is " + i);
        }


        for(int row =  1; row <= 10; row++)
        {
            Console.WriteLine($"The row is {row}");
        }

        for(char col = 'a'; col <= 'j';col++)
        {
            Console.WriteLine($"The col is {col}");
        }


        for(int row = 1;row <= 10; row++)
        {
            for(char col = 'a'; col <= 'j'; col++)
            {
                Console.WriteLine($"The cell is ({row},{col})");
            }
        }


        //combine branches and loops 
        //write C# code to find the sum of all integers 1 through 20 that are divisible by 3.
        for(int i=1;i<20;i++)
        {
            if(i%3 == 0)
            {
                Console.WriteLine($"The number {i} is divisible by 3");
            }
        }
    }
}