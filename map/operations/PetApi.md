<!-- Generated file — do not edit; regenerated with the SDK. -->

# PetApi — operations

Accessor: `client.PetApi` · Source: `src/SwaggerPetstoreOpenApi31/Api/PetApi.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddPet

- **Auth**: `options.PetstoreAuth`
- **Signature**: `AddPet(AddPetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Name`, `PhotoUrls`
- **Returns**: `Pet`
- **Error**: `ApiException<AddPetError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddPetRequest` | `src/SwaggerPetstoreOpenApi31/Requests/PetApi/AddPetRequest.cs` |
| `Category` | `src/SwaggerPetstoreOpenApi31/Models/Category.cs` |
| `Tag` | `src/SwaggerPetstoreOpenApi31/Models/Tag.cs` |
| `Status1` | `src/SwaggerPetstoreOpenApi31/Models/Enums/Status1.cs` |
| `Pet` | `src/SwaggerPetstoreOpenApi31/Models/Pet.cs` |
| `AddPetError` | `src/SwaggerPetstoreOpenApi31/Errors/AddPetError.cs` |

### DeletePet

- **Auth**: `options.PetstoreAuth`
- **Signature**: `DeletePet(DeletePetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PetId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeletePetError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeletePetRequest` | `src/SwaggerPetstoreOpenApi31/Requests/PetApi/DeletePetRequest.cs` |
| `DeletePetError` | `src/SwaggerPetstoreOpenApi31/Errors/DeletePetError.cs` |

### FindPetsByStatus

- **Auth**: `options.PetstoreAuth`
- **Signature**: `FindPetsByStatus(FindPetsByStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `status` ← `Status`
- **Returns**: `IReadOnlyList<Pet>`
- **Error**: `ApiException<FindPetsByStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FindPetsByStatusRequest` | `src/SwaggerPetstoreOpenApi31/Requests/PetApi/FindPetsByStatusRequest.cs` |
| `Status2` | `src/SwaggerPetstoreOpenApi31/Models/Enums/Status2.cs` |
| `Pet` | `src/SwaggerPetstoreOpenApi31/Models/Pet.cs` |
| `FindPetsByStatusError` | `src/SwaggerPetstoreOpenApi31/Errors/FindPetsByStatusError.cs` |

### FindPetsByTags

- **Auth**: `options.PetstoreAuth`
- **Signature**: `FindPetsByTags(FindPetsByTagsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Tags`
- **Query params (wire ← C#)**: `tags` ← `Tags`
- **Returns**: `IReadOnlyList<Pet>`
- **Error**: `ApiException<FindPetsByTagsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FindPetsByTagsRequest` | `src/SwaggerPetstoreOpenApi31/Requests/PetApi/FindPetsByTagsRequest.cs` |
| `Pet` | `src/SwaggerPetstoreOpenApi31/Models/Pet.cs` |
| `FindPetsByTagsError` | `src/SwaggerPetstoreOpenApi31/Errors/FindPetsByTagsError.cs` |

### GetPetById

- **Auth**: `options.ApiKey` OR `options.PetstoreAuth`
- **Signature**: `GetPetById(GetPetByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PetId`
- **Returns**: `Pet`
- **Error**: `ApiException<GetPetByIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPetByIdRequest` | `src/SwaggerPetstoreOpenApi31/Requests/PetApi/GetPetByIdRequest.cs` |
| `Pet` | `src/SwaggerPetstoreOpenApi31/Models/Pet.cs` |
| `GetPetByIdError` | `src/SwaggerPetstoreOpenApi31/Errors/GetPetByIdError.cs` |

### UpdatePet

- **Auth**: `options.PetstoreAuth`
- **Signature**: `UpdatePet(UpdatePetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Name`, `PhotoUrls`
- **Returns**: `Pet`
- **Error**: `ApiException<UpdatePetError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdatePetRequest` | `src/SwaggerPetstoreOpenApi31/Requests/PetApi/UpdatePetRequest.cs` |
| `Category` | `src/SwaggerPetstoreOpenApi31/Models/Category.cs` |
| `Tag` | `src/SwaggerPetstoreOpenApi31/Models/Tag.cs` |
| `Status1` | `src/SwaggerPetstoreOpenApi31/Models/Enums/Status1.cs` |
| `Pet` | `src/SwaggerPetstoreOpenApi31/Models/Pet.cs` |
| `UpdatePetError` | `src/SwaggerPetstoreOpenApi31/Errors/UpdatePetError.cs` |

### UpdatePetWithForm

- **Auth**: `options.PetstoreAuth`
- **Signature**: `UpdatePetWithForm(UpdatePetWithFormRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PetId`
- **Query params (wire ← C#)**: `name` ← `Name`, `status` ← `Status`
- **Returns**: `Pet`
- **Error**: `ApiException<UpdatePetWithFormError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdatePetWithFormRequest` | `src/SwaggerPetstoreOpenApi31/Requests/PetApi/UpdatePetWithFormRequest.cs` |
| `Pet` | `src/SwaggerPetstoreOpenApi31/Models/Pet.cs` |
| `UpdatePetWithFormError` | `src/SwaggerPetstoreOpenApi31/Errors/UpdatePetWithFormError.cs` |

### UploadFile

- **Auth**: `options.PetstoreAuth`
- **Signature**: `UploadFile(UploadFileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PetId`
- **Query params (wire ← C#)**: `additionalMetadata` ← `AdditionalMetadata`
- **Returns**: `ApiResponseModel`
- **Error**: `ApiException<UploadFileError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UploadFileRequest` | `src/SwaggerPetstoreOpenApi31/Requests/PetApi/UploadFileRequest.cs` |
| `ApiResponseModel` | `src/SwaggerPetstoreOpenApi31/Models/ApiResponseModel.cs` |
| `UploadFileError` | `src/SwaggerPetstoreOpenApi31/Errors/UploadFileError.cs` |

