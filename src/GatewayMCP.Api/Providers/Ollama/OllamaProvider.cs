using GatewayMCP.Api.Contracts.Enums;
using GatewayMCP.Api.Contracts.Requests;
using GatewayMCP.Api.Contracts.Responses;
using GatewayMCP.Api.Providers.Ollama.Models;

namespace GatewayMCP.Api.Providers.Ollama
{
    public sealed class OllamaProvider : IChatProvider
    {
        private readonly HttpClient _httpClient;
        public ChatProvider Provider => ChatProvider.Ollama;
        public OllamaProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ChatResponse> ChatAsync(
            ChatRequest request,
            CancellationToken cancellationToken = default)
        {
            var ollamaRequest = OllamaMapper.ToRequest(request);

            var response = await _httpClient.PostAsJsonAsync(
                "/api/chat",
                ollamaRequest,
                cancellationToken
            );

            response.EnsureSuccessStatusCode();
            
            var ollamaResponse = await response.Content.ReadFromJsonAsync<OllamaChatResponse>(cancellationToken: cancellationToken);

            if (ollamaResponse is null)
            {
                throw new InvalidOperationException("Received null response from Ollama API.");
            }

            return OllamaMapper.ToResponse(ollamaResponse);
        }
    }
}
