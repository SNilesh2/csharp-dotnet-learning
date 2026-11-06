using System;
using System.Collections.Concurrent;

// BASIC VARIABLES
string companyName = "Mobicip";
Console.WriteLine($"Welcome to {companyName} Employee Management System");


// COLLECTIONS
Console.WriteLine();
List<Employee> employees =
[
    new Employee(101, "Nilesh", 22, "Android", 30000, true),
    new Employee(102, "Sidharth", 25, "Backend", 45000, true),
    new Employee(103, "Karthi", 23, "Android", 18000, false),
    new Employee(104, "Sridhar", 28, "HR", 35000, true),
    new Employee(105, "Aadhavan", 24, "Backend", 50000, true)
];


// LINQ FILTERING
Console.WriteLine("Employees with salary greater than 30000");

var highSalaryEmployees = employees
    .Where(emp => emp.Salary > 30000);

foreach(var emp in highSalaryEmployees)
{
    Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");
}


// LINQ SORTING
Console.WriteLine();
Console.WriteLine("Employees sorted by salary");

var sortedEmployeed = employees
    .OrderBy(employee => employee.Salary);

foreach (var item in sortedEmployeed)
{
    Console.WriteLine($"Name: {item.Name}, Salary: {item.Salary}");
}


// LINQ GROUPING

Console.WriteLine();
Console.WriteLine("Employees grouped by department");

var departmentGroups = employees
    .GroupBy(emp => emp.Department);

foreach(var group in departmentGroups)
{
    Console.WriteLine($"Department: {group.Key}");
    foreach (var emp in group)
    {
        Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");
    }
    Console.WriteLine();
}


// LINQ AGGREGATION

Console.WriteLine();
Console.WriteLine("Salary Statistics");

int employeeCount = employees.Count();
int totalSalary = employees.Sum(emp => emp.Salary);
double averageSalary = employees.Average(emp => emp.Salary);

Console.WriteLine($"Employee Count: {employeeCount}");
Console.WriteLine($"Total Salary: {totalSalary}");
Console.WriteLine($"Average Salary: {averageSalary:F2}");


// DICTIONARY
Console.WriteLine();
Console.WriteLine("Employee Lookup");

Dictionary<int, Employee> employeeDictionary = employees.ToDictionary(e => e.Id);

if(employeeDictionary.TryGetValue(102, out Employee? foundEmployee))
{
    Console.WriteLine($"Found Employee: {foundEmployee.Name}, Department: {foundEmployee.Department}");

}



    // RECORD
    record Employee(
    int Id,
    string Name,
    int age,
    string Department,
    int Salary,
    bool IsActive
);