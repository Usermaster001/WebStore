var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Загрузка информации из файла конфигуриции

//var configuration = app.Configuration;
//var greetings = configuration["CustomGreetings"];

app.MapGet("/", () => app.Configuration["CustomGreetings"]);

app.Run();