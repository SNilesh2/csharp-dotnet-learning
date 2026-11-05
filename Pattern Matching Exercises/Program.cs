using System;

// Basic Data
string employeeName = "Nilesh";
int age = 22;
int leaveDays = 3;
object employeeStatus = "Active";

string[] leaveRequest = { "CASUAL", "Nilesh", "3" };


// 1.Declaration Pattern
if(employeeStatus is string status)
{
    Console.WriteLine($"Declaration Pattern: {status}");
}

// 2. CONSTANT Pattern
if(employeeStatus is "Active")
{
    Console.WriteLine("Constant pattern: Employee is Active");
}

// 3. VAR pattern + WHEN guard
if (leaveDays is var days && days<=3)
{
    Console.WriteLine($"Var pattern: Short Leave ({days} days)");
}

// 4. DISCARD pattern
string result = employeeStatus switch
{
    _ => "Discard Pattern: Value accpeted"
};

Console.WriteLine(result);


// 5. TYPE pattern
object employee = employeeName;

string employeeType = employee switch
{
    string => "Type Pattern: Employee Name is string",
    int => "Type Pattern: Employee value is an integer",
    _ => "Type Pattern: Unknown Type"
};

Console.WriteLine(employeeType);


// 6. PROPERTY pattern
var employeeDetails = new { Name = "Nilesh", Age = 22, isActive = true };

string eligibility = employeeDetails switch
{
    { Age: >= 18, isActive: true } => "Property Pattern: Eligible for Leave",
    { Age: < 18 } => "Property Pattern: Under Age",
    _ => "Property Pattern: Not Eligible"
};

Console.WriteLine(eligibility);


// 7. POSITIONAL pattern
var employeeTuple = (employeeName, age);

string employeeInfo = employeeTuple switch
{
    ("Nilesh",22) => "Employee Matched",
    (_,<18) => "Minor Employee",
    _ => "Employee Not Matched"
};

Console.WriteLine($"Positional Pattern: {employeeInfo}");


// 8. RELATIONAL pattern
string leaveCategory = leaveDays switch
{
    <=0 => "Invalid",
    <3 => "Short Leave",
    >=3 and <=5 => "Medium Leave",
    > 5 => "Long Leave"
};


Console.WriteLine($"Relational Pattern: {leaveCategory}");

// 9. LOGICAL pattern
if(age is >= 18 and <= 60)
{
    Console.WriteLine("Logical AND: Valid working age ");
}

if (leaveDays is 1 or 2 or 3)
{
    Console.WriteLine("Logical OR: Short Leave duration");
}

if(employeeStatus is not "Inactive")
{
    Console.WriteLine("Logical NOT: Employee is not InActive");
}


// 10. PARENTHESES pattern
if(leaveDays is (>= 1 and <= 3) or >10)
{
    Console.WriteLine("Parentheses Pattern: Special Leave");
}

// 11. WHEN GUARD 
string approval = leaveDays switch
{ 
    var d when d >0 && d<=3 => "Manager approval",
    var d when d > 3 => "HR approval",
    _ => "Invalid leave days"
};

Console.WriteLine($"When Guard: {approval}");


// 12. LIST pattern
if(leaveRequest is ["CASUAL","Nilesh","3"])
{
    Console.WriteLine("List Pattern: Leave Request Matched");
}


// 13. LIST pattern with var and discard
if (leaveRequest is [var type, _ , var duration])
{
    Console.WriteLine($"List Pattern: {type} leave requested for {duration} days");
}

// 14. SLICE pattern
string[] command = { "APPROVE", "LR101", "Nilesh" };

if (command is ["APPROVE", .. , var emp])
{
    Console.WriteLine($"Slice Pattern: Leave Approved for {emp}");
}


// 15. SLICE with PROPERTY pattern
string[] entries = { "BEGIN", "Hello", "World", "END" };

if(entries is ["BEGIN", .. { Length: > 0 }, "END"])
{
    Console.WriteLine("Slice property pattern: content found"); 
}

// 16.DECONSTRUCTION 
var (name, empAge) = employeeTuple;

Console.WriteLine($"Deconstruction: {name},{empAge}");