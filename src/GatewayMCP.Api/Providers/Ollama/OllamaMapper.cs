using GatewayMCP.Api.Contracts.Enums;
using GatewayMCP.Api.Contracts.Models;
using GatewayMCP.Api.Contracts.Requests;
using GatewayMCP.Api.Contracts.Responses;
using GatewayMCP.Api.Providers.Ollama.Models;

namespace GatewayMCP.Api.Providers.Ollama
{
    public static class OllamaMapper
    {
        public static OllamaChatRequest ToRequest(ChatRequest request) {
            return new OllamaChatRequest
            {
                Model = request.Model,
                Messages = request.Messages.Select(m => ToMessage(m)).ToList(),
                Stream = request.Stream
            };
        }

        public static OllamaMessage ToMessage(ChatMessage message)
        {
            return new OllamaMessage
            {
                Role = message.Role,
                Content = message.Content
            };
        }

        private static ChatMessage ToMessage(OllamaMessage message)
        {
            return new ChatMessage
            {
                Role = message.Role,
                Content = message.Content
            };
        }

        public static ChatResponse ToResponse(OllamaChatResponse response)
        {
            return new ChatResponse
            {
                Provider = ChatProvider.Ollama.ToString(),
                Model = response.Model,
                Message = ToMessage(response.Message),
                Usage = null
            };
        }
    }
}
