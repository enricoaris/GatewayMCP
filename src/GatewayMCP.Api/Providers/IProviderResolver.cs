using GatewayMCP.Api.Contracts.Enums;

namespace GatewayMCP.Api.Providers
{
    public interface IProviderResolver
    {
        IChatProvider Resolve(ChatProvider provider);
    }
}
