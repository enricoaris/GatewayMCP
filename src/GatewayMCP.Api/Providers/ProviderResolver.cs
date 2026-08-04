using GatewayMCP.Api.Contracts.Enums;
using GatewayMCP.Api.Providers.OpenAI;

namespace GatewayMCP.Api.Providers
{
    public sealed class ProviderResolver: IProviderResolver
    {
        private readonly Dictionary<ChatProvider, IChatProvider> _providers;

        public ProviderResolver(IEnumerable<IChatProvider> providers)
        {
            _providers = providers.ToDictionary(p => p.Provider);
        }

        public IChatProvider Resolve (ChatProvider provider)
        {
            if (_providers.TryGetValue(provider, out IChatProvider? chatProvider))
            {
                return chatProvider;
            }

            throw new ArgumentException($"Unsupported provider: {provider}");
        }
    }
}
