namespace GatewayMCP.Api.Contracts.Models
{
    public class ChatChunk
    {
        public string? Content { get; init; }
        //public ToolCall
        public bool IsCompleted { get; init; }
    }
}
