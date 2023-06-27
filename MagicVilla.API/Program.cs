using MagicVilla.API.Logging;
using MagicVilla.API.Logging.Interfaces;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File("debugLog/villaLogs.text", rollingInterval: RollingInterval.Day)
    .WriteTo.Console(theme: AnsiConsoleTheme.Literate)
    .CreateLogger();

/*Log.Logger = new LoggerConfiguration()
    .WriteTo.Console().CreateLogger();*/

builder.Host.UseSerilog();

//builder.Logging.ClearProviders().AddConsole();

builder.Services.AddControllers(option =>
{
    option.ReturnHttpNotAcceptable = false;

}).AddNewtonsoftJson();


//DI
builder.Services.AddSingleton<IGenerationLogging, ConsoleLog>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseSerilogRequestLogging();

app.Run();

