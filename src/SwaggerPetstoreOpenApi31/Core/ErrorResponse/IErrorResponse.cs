using System.Threading;
using System.Threading.Tasks;
using SwaggerPetstoreOpenApi31.Core.Models;

namespace SwaggerPetstoreOpenApi31.Core.ErrorResponse;

internal interface IErrorResponse<TError>
{
    Task<TError> Map(ResponseContext context, CancellationToken cancellationToken);
}