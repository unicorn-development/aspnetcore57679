var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "�n �ml��t");

app.Run();
