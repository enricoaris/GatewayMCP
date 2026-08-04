namespace GatewayMCP.Api.Contracts.Models
{
    public class Usage
    {
        public int PromptTokens { get; init; }
        public int CompletionTokens { get; init; }
        public int TotalTokens { get; init; }
    }
}
