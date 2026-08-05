namespace GatewayMCP.Api.Providers.Ollama.Models
{
    public class OllamaChatResponse
    {
        public required string Model { get; init; }

        public required OllamaMessage Message { get; init; }

        public bool Done { get; init; }
    }
}
