
# Evse VO

Each Location will contain one or more EVSEs (Electric Vehicle Supply Equipment). Each EVSE is capable of charging one car at a time.

## Structure

`EvseVO`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `int?` | Optional | Internal identifier used to refer to single individual  EVSE unit. |
| `ExternalId` | `string` | Optional | Identifier of the Evse as given by the Operator, unique for that Operator |
| `EvseId` | `string` | Optional | Standard EVSEId identifier (ISO-IEC-15118) |
| `Status` | [`EvseVOStatusEnum?`](../../doc/models/evse-vo-status-enum.md) | Optional | The current status of the EVSE units availability |
| `Connectors` | [`List<ConnectorVO>`](../../doc/models/connector-vo.md) | Optional | List of all connectors available on this EVSE unit. |
| `AuthorizationMethods` | [`EvseVOAuthorizationMethodsEnum?`](../../doc/models/evse-vo-authorization-methods-enum.md) | Optional | Methods that can be used to Authorize sessions on this EVSE |
| `Updated` | `string` | Optional | ISO8601-compliant UTC datetime of the last update of the EVSE |
| `Deleted` | `string` | Optional | optional  ISO8601-compliant UTC deletion timestamp of the Evse |
| `PhysicalReference` | `string` | Optional | An optional number/string printed on the outside of the EVSE for visual identification |

## Example

```csharp
using ShellEV.Standard.Models;
using System.Collections.Generic;

EvseVO evseVO = new EvseVO
{
    Uid = 4,
    ExternalId = "01001188_1",
    EvseId = "NL*TNM*E01000401*0",
    Status = EvseVOStatusEnum.Available,
    Connectors = new List<ConnectorVO>
    {
        new ConnectorVO
        {
            Uid = 60,
            ExternalId = "externalId6",
            ConnectorType = ConnectorVOConnectorTypeEnum.Tesla,
            ElectricalProperties = new ElectricalProperties
            {
                PowerType = ElectricalPropertiesPowerTypeEnum.AC1Phase,
                Voltage = 110.62,
                Amperage = 46.4,
                MaxElectricPower = 232.04,
            },
            FixedCable = false,
        },
        new ConnectorVO
        {
            Uid = 60,
            ExternalId = "externalId6",
            ConnectorType = ConnectorVOConnectorTypeEnum.Tesla,
            ElectricalProperties = new ElectricalProperties
            {
                PowerType = ElectricalPropertiesPowerTypeEnum.AC1Phase,
                Voltage = 110.62,
                Amperage = 46.4,
                MaxElectricPower = 232.04,
            },
            FixedCable = false,
        },
        new ConnectorVO
        {
            Uid = 60,
            ExternalId = "externalId6",
            ConnectorType = ConnectorVOConnectorTypeEnum.Tesla,
            ElectricalProperties = new ElectricalProperties
            {
                PowerType = ElectricalPropertiesPowerTypeEnum.AC1Phase,
                Voltage = 110.62,
                Amperage = 46.4,
                MaxElectricPower = 232.04,
            },
            FixedCable = false,
        },
    },
    AuthorizationMethods = EvseVOAuthorizationMethodsEnum.NewMotionApp,
    Updated = "2021-10-06T10:44:24Z",
    Deleted = "2021-10-06T10:44:24Z",
    PhysicalReference = "Green",
};
```

