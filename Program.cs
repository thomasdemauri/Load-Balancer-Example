var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (ILogger<Program> logger) =>
{
    var name = Environment.GetEnvironmentVariable("HOSTNAME");

    logger.LogInformation($"Request handled by {name}");

    return $"Handled by {name}";
});

app.Run();
