
# Electrical Properties

Electrical Properties of the Connector

## Structure

`ElectricalProperties`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PowerType` | [`ElectricalPropertiesPowerTypeEnum?`](../../doc/models/electrical-properties-power-type-enum.md) | Optional | - |
| `Voltage` | `double?` | Optional | Voltage in Volts for this connector |
| `Amperage` | `double?` | Optional | Electric Current in Amperes for this connector |
| `MaxElectricPower` | `double?` | Optional | Power in Kilowatts for this connector |

## Example

```csharp
using ShellEV.Standard.Models;

ElectricalProperties electricalProperties = new ElectricalProperties
{
    PowerType = ElectricalPropertiesPowerTypeEnum.AC1Phase,
    Voltage = 230,
    Amperage = 16,
    MaxElectricPower = 3.7,
};
```

