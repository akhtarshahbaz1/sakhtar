using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ConsoleTemplate;
using ConsoleTemplate.Common;
using ConsoleTemplate.WeatherForecasts;
using Spectre.Console;
using Spectre.Console.Cli;

AnsiConsole.Write(new FigletText("ConsoleTemplate"));
AnsiConsole.WriteLine("Command-line Tools 1.1.0");
AnsiConsole.WriteLine();

var builder = Host.CreateDefaultBuilder(args);

// Add services to the container
builder.ConfigureServices(services =>
    services.AddSingleton<WeatherForecastService>());

var registrar = new TypeRegistrar(builder);

var app = new CommandApp(registrar);

app.Configure(config =>
{
    // Register available commands
    config.AddCommand<WeatherForecastCommand>("forecasts")
        .WithDescription("Display local weather forecasts.")
        .WithExample(new[] { "forecasts", "5" });
});

return app.Run(args);