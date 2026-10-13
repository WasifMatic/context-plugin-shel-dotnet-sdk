using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace SwaggerPetstoreOpenApi31;

public static class ServiceCollectionExtensions
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddSwaggerPetstoreOpenApi31Client(Action<SwaggerPetstoreOpenApi31ClientOptions>? configure = null)
        {
            services.AddHttpClient();
            services.AddSingleton(sp =>
            {
                var options = new SwaggerPetstoreOpenApi31ClientOptions
                {
                    TimeProvider = sp.GetService<TimeProvider>() ?? TimeProvider.System,
                };
                configure?.Invoke(options);
                options.Logging =
                    options.Logging with
                    {
                        LoggerFactory = options.Logging.LoggerFactory ?? sp.GetService<ILoggerFactory>()
                    };
                var httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
                var httpClient = httpClientFactory.CreateClient();
                return new SwaggerPetstoreOpenApi31Client(httpClient, options);
            });
            return services;
        }
    }
}
