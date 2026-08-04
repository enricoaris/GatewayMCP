using GatewayMCP.Api.Contracts.Enums;

namespace GatewayMCP.Api.Contracts.Models
{
    public sealed class ChatMessage
    {
        public required string Role { get; init; }
        public required string Content { get; init; }
    }
}
