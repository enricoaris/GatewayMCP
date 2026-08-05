using GatewayMCP.Api.Contracts.Models;

namespace GatewayMCP.Api.Contracts.Responses
{
    public class ChatResponse
    {
        public string Id { get; init; }
        public string Provider { get; init; }
        public string Model { get; init; }
        public required ChatMessage Message { get; init; }
        public Usage? Usage { get; init; }
    }
}
