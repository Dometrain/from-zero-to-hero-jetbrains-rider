using DometrainDebuggingPlayground;
using DometrainDebuggingPlayground.PodcastSource;
using DometrainDebuggingPlayground.PodcastsService;
using DometrainDebuggingPlayground.ThreadDemo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddTransient<IPodcastService, PodcastService>();
builder.Services.AddTransient<IPodcastSource, HardcodedPodcastSource>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

Threads.Execute();

app.Run();

namespace DometrainDebuggingPlayground
{
    public partial class Program
    {
    }
}