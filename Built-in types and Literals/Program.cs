using System;

string name = "Nilesh";
int age = 22;
long views = 5_000_000_000L;
double height = 165.3;
decimal salary = 53600.50m;
bool isEmployed = true;
char grade = 'A';


//String Interpolation
Console.WriteLine("My informations...");
Console.WriteLine($"Name : {name}"); 
Console.WriteLine($"Age : {age}"); 
Console.WriteLine($"Total Views : {views}"); 
Console.WriteLine($"Height : {height:F2}"); 
Console.WriteLine($"Salary : {salary}"); 
Console.WriteLine($"IsEmployed : {isEmployed}"); 
Console.WriteLine($"Grade : {grade}");


//Type information
Console.WriteLine();
Console.WriteLine("Type Information...");
Console.WriteLine(age.GetType());
Console.WriteLine(salary.GetType());
Console.WriteLine(grade.GetType());


// Target typed new 
List<string> list = new()
{
    "Nilesh",
    "Sid",
    "Raji"
};


foreach(string str in list)
{
    Console.WriteLine($"{str}");
}