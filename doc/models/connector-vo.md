
# Connector VO

An EVSE can have one or many Connectors. Each Connector will normally have a different socket / cable and only one can be used to charge at a time.

## Structure

`ConnectorVO`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `int?` | Optional | Internal identifier used to refer to this Connector |
| `ExternalId` | `string` | Optional | Identifier of the Evse as given by the Operator, unique for the containing EVSE' |
| `ConnectorType` | [`ConnectorVOConnectorTypeEnum?`](../../doc/models/connector-vo-connector-type-enum.md) | Optional | - |
| `ElectricalProperties` | [`ElectricalProperties`](../../doc/models/electrical-properties.md) | Optional | Electrical Properties of the Connector |
| `FixedCable` | `bool?` | Optional | Indicates whether Connector has a fixed cable attached. False by default (not sent in this case) |
| `Tariff` | [`Tariff`](../../doc/models/tariff.md) | Optional | - |
| `Updated` | `string` | Optional | ISO8601-compliant UTC datetime of the last update of the Connector’s data |
| `UpdatedBy` | [`ConnectorVOUpdatedByEnum?`](../../doc/models/connector-vo-updated-by-enum.md) | Optional | - |
| `Deleted` | `string` | Optional | optional  ISO8601-compliant UTC deletion timestamp of the connector |

## Example

```csharp
using ShellEV.Standard.Models;

ConnectorVO connectorVO = new ConnectorVO
{
    Uid = 2,
    ExternalId = "01000861_1_21",
    ConnectorType = ConnectorVOConnectorTypeEnum.Nema520,
    ElectricalProperties = new ElectricalProperties
    {
        PowerType = ElectricalPropertiesPowerTypeEnum.AC1Phase,
        Voltage = 110.62,
        Amperage = 46.4,
        MaxElectricPower = 232.04,
    },
    FixedCable = true,
    Updated = "2021-10-06T10:44:24Z",
    Deleted = "2021-12-06T10:44:24Z",
};
```

