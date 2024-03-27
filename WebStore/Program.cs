var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var services = builder.Services;
services.AddControllersWithViews();    //????????

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

//Добавление файла конфигурации
//builder.Configuration.AddJsonFile("anotherconfig.json", true, true);
//builder.Configuration.AddCommandLine(args);

// Загрузка информации из файла конфигуриции
//var configuration = app.Configuration;
//var greetings = configuration["CustomGreetings"];


//app.MapGet("/", () => app.Configuration["CustomGreetings"]);

app.MapGet("/throw", () =>
{
    throw new ApplicationException("Ошибка в программе!");
});

//app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "defult",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();