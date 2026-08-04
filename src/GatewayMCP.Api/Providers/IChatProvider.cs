using GatewayMCP.Api.Contracts.Enums;
using GatewayMCP.Api.Contracts.Models;
using GatewayMCP.Api.Contracts.Requests;
using GatewayMCP.Api.Contracts.Responses;

namespace GatewayMCP.Api.Providers
{
    public interface IChatProvider
    {
        ChatProvider Provider { get; }
        Task<ChatResponse> ChatAsync(ChatRequest request, CancellationToken cancellationToken = default);
    }
}
