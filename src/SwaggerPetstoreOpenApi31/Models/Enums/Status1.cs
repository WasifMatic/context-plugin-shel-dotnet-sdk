using System;
using System.Text.Json.Serialization;
using SwaggerPetstoreOpenApi31.Core.Enum;

namespace SwaggerPetstoreOpenApi31.Models.Enums;

/// <summary>
/// pet status in the store
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status1>))]
public sealed record Status1 : OpenStringEnum<Status1>
{
    private Status1(string value) : base(value)
    {
    }

    public static readonly Status1 Available = new("available");

    public static readonly Status1 Pending = new("pending");

    public static readonly Status1 Sold = new("sold");

    public TResult Match<TResult>(Func<TResult> onAvailable,
        Func<TResult> onPending,
        Func<TResult> onSold,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Available => onAvailable(),
            _ when this == Pending => onPending(),
            _ when this == Sold => onSold(),
            _ => otherwise(Value)
        };

    public void Match(Action onAvailable, Action onPending, Action onSold, Action<string> otherwise)
    {
        if (this == Available) onAvailable();
        else if (this == Pending) onPending();
        else if (this == Sold) onSold();
        else otherwise(Value);
    }
}
