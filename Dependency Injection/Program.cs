using Dependency_Injection.Services;
using Dependency_Injection.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Change this line to test different lifetimes.
builder.Services.AddTransient<IWelcomeService, WelcomeService>();

var app = builder.Build();



app.MapGet("/", (IWelcomeService welcomeService1, IWelcomeService welcomeService2) =>
{
    string msg1 = $"Message 1: {welcomeService1.GetWelcomeMessage()}";
    string msg2 = $"Message 2: {welcomeService2.GetWelcomeMessage()}";

    return $"{msg1}\n{msg2}";

});


app.Run();
