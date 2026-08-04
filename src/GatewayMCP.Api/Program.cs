using GatewayMCP.Api.Providers;
using GatewayMCP.Api.Providers.OpenAI;
using GatewayMCP.Api.Providers.Ollama;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<IChatProvider, OpenAIProvider>();
builder.Services.AddTransient<IChatProvider, OllamaProvider>();
builder.Services.AddSingleton<IProviderResolver, ProviderResolver>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
