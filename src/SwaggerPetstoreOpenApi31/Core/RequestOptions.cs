using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using SwaggerPetstoreOpenApi31.Core.Hooks;

namespace SwaggerPetstoreOpenApi31.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
