using System;


int[] salaries = { 50000, 60000,27000, 15000, 70000, 7000, 80000,-1, 90000 };
IEnumerable<int> eligibleSalaries = GetHighSalaries(salaries);


Console.WriteLine("Sequence Created");


var highSalaries = eligibleSalaries
    .Where(salary => salary >= 30000);

Console.WriteLine("Eligible Salaries:");
foreach(int salary in highSalaries)
{
    Console.WriteLine(salary);
}

static IEnumerable<int> GetHighSalaries(int[] salaries)
{
    foreach(int salary in salaries)
    {
        Console.WriteLine($"Checking salary : {salary}");
        if(salary == -1)
        {
            yield break;
        }

        if(salary >= 25000)
        {
            yield return salary;
        }
    }
}