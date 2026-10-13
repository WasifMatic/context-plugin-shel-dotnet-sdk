using System.Collections.Generic;
using SwaggerPetstoreOpenApi31.Models;

namespace SwaggerPetstoreOpenApi31.Requests.UserApi;

/// <summary>
/// The inputs of the CreateUsersWithListInput operation.
/// </summary>
public sealed record CreateUsersWithListInputRequest
{
    public IReadOnlyList<User>? Body { get; init; }
}
