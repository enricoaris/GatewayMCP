using GatewayMCP.Api.Contracts.Enums;
using GatewayMCP.Api.Contracts.Requests;
using GatewayMCP.Api.Contracts.Responses;

namespace GatewayMCP.Api.Providers.Ollama
{
    public sealed class OllamaProvider : IChatProvider
    {
        public ChatProvider Provider => ChatProvider.Ollama;

        public Task<ChatResponse> ChatAsync(
            ChatRequest request,
            CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
