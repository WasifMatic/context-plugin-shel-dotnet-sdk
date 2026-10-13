using SwaggerPetstoreOpenApi31.Servers;

namespace SwaggerPetstoreOpenApi31;

public class ServerOptions
{
    public DefaultOptions Default { get; set; } = new();
    public AuthServerOptions AuthServer { get; set; } = new();
}
