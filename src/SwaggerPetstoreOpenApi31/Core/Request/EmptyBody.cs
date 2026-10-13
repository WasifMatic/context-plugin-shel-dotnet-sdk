using System.Net.Http;
using SwaggerPetstoreOpenApi31.Core.Extensions;

namespace SwaggerPetstoreOpenApi31.Core.Request;

internal sealed class EmptyBody : IRequest
{
    public static EmptyBody Instance { get; } = new();

    private EmptyBody() { }

    public HttpContent Get() => HttpContent.None;

    public bool CanRetry => true;
}
