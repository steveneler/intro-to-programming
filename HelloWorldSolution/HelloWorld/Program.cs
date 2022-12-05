using HelloWorld;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

//do some configuration of the services
builder.Services.AddSingleton<DateUtils>();
var app = builder.Build();

app.MapGet("/break/{minutes:int}", (int minutes, DateUtils utils) =>
{
    var response = new BreakTimerResponse(
        minutes,
        DateTime.Now,
        utils.TakeABreak(minutes)
        );
    return Results.Ok(response);
});

app.Run(); //"Blocking


public record BreakTimerResponse(int minutes, DateTime StartTime, DateTime EndTime);