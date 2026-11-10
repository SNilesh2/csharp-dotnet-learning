
using System;
using System.Linq;

// Employee salary data
int[] salaries = { 20000, 30000, 45000, 50000, 60000 };

// 1. Expression Lambda
Func<int, int> calculateBonus = salary => salary * 10 / 100;

Console.WriteLine("Expression Lambda:");
Console.WriteLine(calculateBonus(40000));

// 2. Statement Lambda
Func<int, int> calculateTotalSalary = salary =>
{
    int bonus = salary * 10 / 100;
    int total = salary + bonus;

    return total;
};

Console.WriteLine("\nStatement Lambda:");
Console.WriteLine(calculateTotalSalary(40000));

// 3. Zero Parameter Lambda
Func<string> getCompanyName = () => "Mobicip";

Console.WriteLine("\nZero Parameter Lambda:");
Console.WriteLine(getCompanyName());

// 4. Multiple Parameter Lambda
Func<int, int, int> addSalary = (basic, bonus) => basic + bonus;

Console.WriteLine("\nMultiple Parameter Lambda:");
Console.WriteLine(addSalary(30000, 5000));

// 5. Variable Capturing
int minimumSalary = 30000;

var eligibleEmployees = salaries.Where(
    salary => salary >= minimumSalary
);

Console.WriteLine("\nCaptured Variable:");

foreach (int salary in eligibleEmployees)
{
    Console.WriteLine(salary);
}

// 6. Static Lambda
Func<int, bool> isEven = static number => number % 2 == 0;

Console.WriteLine("\nStatic Lambda:");
Console.WriteLine(isEven(40000));

// 7. Method Group
var highSalaries = salaries.Where(IsHighSalary);

Console.WriteLine("\nMethod Group:");

foreach (int salary in highSalaries)
{
    Console.WriteLine(salary);
}

static bool IsHighSalary(int salary)
{
    return salary > 40000;
}

// 8. Local Function
void DisplayCompanyDetails()
{
    Console.WriteLine("\nLocal Function:");

    string company = "Mobicip";

    void DisplayName()
    {
        Console.WriteLine(company);
    }

    DisplayName();
}

DisplayCompanyDetails();
