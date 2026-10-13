using System.Collections.Generic;
using SwaggerPetstoreOpenApi31.Models;
using SwaggerPetstoreOpenApi31.Models.Enums;

namespace SwaggerPetstoreOpenApi31.Requests.PetApi;

/// <summary>
/// The inputs of the UpdatePet operation.
/// </summary>
public sealed record UpdatePetRequest
{
    public required string Name { get; init; }

    public required IReadOnlyList<string> PhotoUrls { get; init; }

    public long? Id { get; init; }

    public Category? Category { get; init; }

    public IReadOnlyList<Tag>? Tags { get; init; }

    /// <summary>
    /// pet status in the store
    /// </summary>
    public Status1? Status { get; init; }
}
