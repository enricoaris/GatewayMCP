namespace GatewayMCP.Api.Options
{
    public class OllamaOptions
    {
        public const string SectionName = "Ollama";
        public required string BaseUrl { get; init; }
        public string ChatEndpoint { get; init; } = "/api/chat";
    }
}
