using System;

namespace SwaggerPetstoreOpenApi31.Core.Exceptions;

public class SdkConnectionException(string message, Exception? innerException = null)
    : SdkException(message, innerException);
