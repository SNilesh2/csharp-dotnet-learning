var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


// Non Terminal Middleware
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("hello from middleware 1\n");

    await next.Invoke();

    await context.Response.WriteAsync("hello from middleware 1 after next\n");

});


// Terminal Middleware
app.Run(async context =>
{
    await context.Response.WriteAsync("hello from middleware 2\n");
});


app.Run();
