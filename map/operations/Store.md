<!-- Generated file — do not edit; regenerated with the SDK. -->

# Store — operations

Accessor: `client.Store` · Source: `src/SwaggerPetstoreOpenApi31/Api/Store.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteOrder

- **Signature**: `DeleteOrder(DeleteOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteOrderRequest` | `src/SwaggerPetstoreOpenApi31/Requests/Store/DeleteOrderRequest.cs` |
| `DeleteOrderError` | `src/SwaggerPetstoreOpenApi31/Errors/DeleteOrderError.cs` |

### GetInventory

- **Auth**: `options.ApiKey`
- **Signature**: `GetInventory(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyDictionary<string, int>`
- **Error**: `ApiException<RawError>` — **Case B**

### GetOrderById

- **Signature**: `GetOrderById(GetOrderByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderId`
- **Returns**: `Order`
- **Error**: `ApiException<GetOrderByIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetOrderByIdRequest` | `src/SwaggerPetstoreOpenApi31/Requests/Store/GetOrderByIdRequest.cs` |
| `Order` | `src/SwaggerPetstoreOpenApi31/Models/Order.cs` |
| `GetOrderByIdError` | `src/SwaggerPetstoreOpenApi31/Errors/GetOrderByIdError.cs` |

### PlaceOrder

- **Signature**: `PlaceOrder(PlaceOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `Order`
- **Error**: `ApiException<PlaceOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PlaceOrderRequest` | `src/SwaggerPetstoreOpenApi31/Requests/Store/PlaceOrderRequest.cs` |
| `Status` | `src/SwaggerPetstoreOpenApi31/Models/Enums/Status.cs` |
| `Order` | `src/SwaggerPetstoreOpenApi31/Models/Order.cs` |
| `PlaceOrderError` | `src/SwaggerPetstoreOpenApi31/Errors/PlaceOrderError.cs` |

