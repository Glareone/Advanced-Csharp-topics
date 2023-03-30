using PeriodicTimer;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddHostedService<OutdatedRepeatingService>();
builder.Services.AddHostedService<RepeatingServiceWithPeriodicTimer>();

var app = builder.Build();

app.Run();