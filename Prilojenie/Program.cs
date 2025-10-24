var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from ASP.NET Core in Docker!");

app.MapGet("/api/info", () => new { Message = "Containerized ASP.NET app", Time = DateTime.UtcNow });

app.Run();