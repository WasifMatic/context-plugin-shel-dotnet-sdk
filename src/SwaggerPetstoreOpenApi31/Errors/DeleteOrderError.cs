using System.Threading.Tasks;
using SwaggerPetstoreOpenApi31.Core.ErrorResponse;
using SwaggerPetstoreOpenApi31.Core.Models;

namespace SwaggerPetstoreOpenApi31.Errors;

public sealed class DeleteOrderError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private DeleteOrderError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static DeleteOrderError AsNoContent(RawError value) => new(Optional<RawError>.Some(value), default);

    private static DeleteOrderError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    private static Task<DeleteOrderError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 404 => response.RawBody().As(AsNoContent),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<DeleteOrderError> Response { get; } = new(Create);
}
