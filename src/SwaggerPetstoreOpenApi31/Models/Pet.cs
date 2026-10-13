using System.Collections.Generic;
using System.Text.Json.Serialization;
using SwaggerPetstoreOpenApi31.Core.Models;
using SwaggerPetstoreOpenApi31.Models.Enums;

namespace SwaggerPetstoreOpenApi31.Models;

public record Pet
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public long? Id { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    public Category? Category { get; init; }

    [JsonPropertyName("photoUrls")]
    public required IReadOnlyList<string> PhotoUrls { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tags")]
    public IReadOnlyList<Tag>? Tags { get; init; }

    /// <summary>
    /// pet status in the store
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status1? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
