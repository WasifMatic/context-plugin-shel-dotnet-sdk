namespace SwaggerPetstoreOpenApi31.Requests.UserApi;

/// <summary>
/// The inputs of the GetUserByName operation.
/// </summary>
public sealed record GetUserByNameRequest
{
    /// <summary>
    /// The name that needs to be fetched. Use user1 for testing
    /// </summary>
    public required string Username { get; init; }
}
