var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHealthChecks();

var app = builder.Build();
app.MapHealthChecks("/health");
app.MapGet("/hello-world", () => new { message = "Hello World!" });
app.Run();

public partial class Program;
