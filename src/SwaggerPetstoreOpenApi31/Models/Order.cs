using System;
using System.Text.Json.Serialization;
using SwaggerPetstoreOpenApi31.Core.Models;
using SwaggerPetstoreOpenApi31.Models.Enums;

namespace SwaggerPetstoreOpenApi31.Models;

public record Order
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public long? Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("petId")]
    public long? PetId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity")]
    public int? Quantity { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipDate")]
    public DateTimeOffset? ShipDate { get; init; }

    /// <summary>
    /// Order Status
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status? Status { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("complete")]
    public bool? Complete { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
