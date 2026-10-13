using System.Net.Http;

namespace SwaggerPetstoreOpenApi31.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}