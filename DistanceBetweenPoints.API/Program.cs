using DistanceBetweenPoints.API.Middleware;
using DistanceBetweenPoints.API.ServiceCollection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<GlobalExceptionHandler>(app.Logger);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
