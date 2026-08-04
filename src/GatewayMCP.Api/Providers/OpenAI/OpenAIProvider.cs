using GatewayMCP.Api.Contracts.Enums;
using GatewayMCP.Api.Contracts.Requests;
using GatewayMCP.Api.Contracts.Responses;

namespace GatewayMCP.Api.Providers.OpenAI
{
    public sealed class OpenAIProvider: IChatProvider
    {
        public ChatProvider Provider => ChatProvider.OpenAI;
        
        public Task<ChatResponse> ChatAsync(
            ChatRequest request,
            CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
