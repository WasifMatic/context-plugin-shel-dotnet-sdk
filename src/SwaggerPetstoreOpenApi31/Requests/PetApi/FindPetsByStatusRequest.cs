using SwaggerPetstoreOpenApi31.Models.Enums;

namespace SwaggerPetstoreOpenApi31.Requests.PetApi;

/// <summary>
/// The inputs of the FindPetsByStatus operation.
/// </summary>
public sealed record FindPetsByStatusRequest
{
    /// <summary>
    /// Status values that need to be considered for filter
    /// </summary>
    public Status2 Status { get; init; } = Status2.Available;
}
