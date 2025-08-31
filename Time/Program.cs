using Time.Services;
using TimeProvider = Time.Services.TimeProvider;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ITimeProvider, TimeProvider>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.MapGet("/time", (ITimeProvider timeProvider) =>
{
    var currentTime = timeProvider.GetCurrentTime();
    return Results.Ok($"The current time is: {currentTime}");
})
.WithName("GetTime")
.WithOpenApi();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
