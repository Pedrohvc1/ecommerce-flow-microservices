var builder = WebApplication.CreateBuilder(args);

// Swagger básico
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.MapGet("/", () => "API Gateway rodando!");

app.Run();
