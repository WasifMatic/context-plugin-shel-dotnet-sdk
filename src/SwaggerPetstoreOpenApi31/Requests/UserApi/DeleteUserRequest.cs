namespace SwaggerPetstoreOpenApi31.Requests.UserApi;

/// <summary>
/// The inputs of the DeleteUser operation.
/// </summary>
public sealed record DeleteUserRequest
{
    /// <summary>
    /// The name that needs to be deleted
    /// </summary>
    public required string Username { get; init; }
}
