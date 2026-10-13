using System.Threading;
using System.Threading.Tasks;
using SwaggerPetstoreOpenApi31.Core.ErrorResponse;
using SwaggerPetstoreOpenApi31.Core.Models;

namespace SwaggerPetstoreOpenApi31.Core.Response;

internal sealed class RawErrorBodyResponse : IResponse<RawError>
{
    public static RawErrorBodyResponse Instance { get; } = new();

    private RawErrorBodyResponse() { }

    public ValueTask<RawError> Map(ResponseContext context, CancellationToken cancellationToken) =>
        new(RawError.Create(context.Response, cancellationToken));
}
