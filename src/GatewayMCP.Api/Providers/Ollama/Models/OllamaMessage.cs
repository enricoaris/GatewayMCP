namespace GatewayMCP.Api.Providers.Ollama.Models
{
    public class OllamaMessage
    {
        public required string Role { get; init; }
        public required string Content { get; init; }
    }
}
