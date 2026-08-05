namespace GatewayMCP.Api.Providers.Ollama.Models
{
    public class OllamaChatRequest
    {
        public required string Model { get; init; }
        public List<OllamaMessage> Messages { get; init; } = [];
        public bool Stream { get; init; } = false;
    }
}
