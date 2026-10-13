using System;
using System.Text.Json.Serialization;
using SwaggerPetstoreOpenApi31.Core.Enum;

namespace SwaggerPetstoreOpenApi31.Models.Enums;

/// <summary>
/// Order Status
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status>))]
public sealed record Status : OpenStringEnum<Status>
{
    private Status(string value) : base(value)
    {
    }

    public static readonly Status Placed = new("placed");

    public static readonly Status Approved = new("approved");

    public static readonly Status Delivered = new("delivered");

    public TResult Match<TResult>(Func<TResult> onPlaced,
        Func<TResult> onApproved,
        Func<TResult> onDelivered,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Placed => onPlaced(),
            _ when this == Approved => onApproved(),
            _ when this == Delivered => onDelivered(),
            _ => otherwise(Value)
        };

    public void Match(Action onPlaced, Action onApproved, Action onDelivered, Action<string> otherwise)
    {
        if (this == Placed) onPlaced();
        else if (this == Approved) onApproved();
        else if (this == Delivered) onDelivered();
        else otherwise(Value);
    }
}
