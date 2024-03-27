var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Добавление файла конфигурации
//builder.Configuration.AddJsonFile("anotherconfig.json", true, true);
//builder.Configuration.AddCommandLine(args);

// Загрузка информации из файла конфигуриции
//var configuration = app.Configuration;
//var greetings = configuration["CustomGreetings"];

app.MapGet("/", () => app.Configuration["CustomGreetings"]);

app.Run();