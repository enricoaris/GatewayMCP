using GatewayMCP.Api.Contracts.Enums;
using GatewayMCP.Api.Contracts.Models;

namespace GatewayMCP.Api.Contracts.Requests
{
    public class ChatRequest
    {
        public required ChatProvider Provider { get; init; }
        public required string Model { get; init; }
        public List<ChatMessage> Messages = [];
        public bool Stream { get; init; } = true;
        public float? Temperature { get; init; }
    }
}
