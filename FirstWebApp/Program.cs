var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//root endpoint
app.MapGet("/", () => "Hello World!");

//About endpoint
app.MapGet("/about", () => "This is my First Web App in C#");

//User endpoint
app.MapGet("/user", () => "I'm Nilesh");

app.Run();
