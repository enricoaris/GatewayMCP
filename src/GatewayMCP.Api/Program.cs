using GatewayMCP.Api.Providers;
using GatewayMCP.Api.Providers.OpenAI;
using GatewayMCP.Api.Providers.Ollama;
using GatewayMCP.Api.Options;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<IChatProvider, OpenAIProvider>();
builder.Services.AddTransient<IChatProvider, OllamaProvider>();
builder.Services.AddSingleton<IProviderResolver, ProviderResolver>();

builder.Services.AddHttpClient<OllamaProvider>(client =>
{
    client.BaseAddress = new Uri("http://localhost:11434");
});

builder.Services.Configure<OllamaOptions>(
    builder.Configuration.GetSection(OllamaOptions.SectionName));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
