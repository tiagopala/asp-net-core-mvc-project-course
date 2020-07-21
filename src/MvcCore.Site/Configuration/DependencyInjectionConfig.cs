using Microsoft.Extensions.DependencyInjection;
using MvcCore.Site.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Site.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IPedidoRepository, PedidoRepository>();

            return services;
        }
    }
}
