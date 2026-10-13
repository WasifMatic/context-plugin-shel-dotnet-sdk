using SwaggerPetstoreOpenApi31.Core.Authentication;
using SwaggerPetstoreOpenApi31.Core.Authentication.ApiKey;

namespace SwaggerPetstoreOpenApi31;

internal sealed class AuthSchemes
{
    public IAuthScheme PetstoreAuth { get; }
    public IAuthScheme ApiKey { get; }

    public AuthSchemes(SwaggerPetstoreOpenApi31ClientOptions options)
    {
        PetstoreAuth = ApiKeyHeaderScheme.Create("Authorization", options.PetstoreAuth);
        ApiKey = ApiKeyHeaderScheme.Create("api_key", options.ApiKey);
    }
}
