using KissLog;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MvcCore.Site.Data;
using MvcCore.Site.Extensions;
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
            #region [ ApplicationServices ]
            services.AddTransient<IPedidoRepository, PedidoRepository>();
            #endregion

            #region [ KissLoggerServices ]
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped((context) => Logger.Factory.Get());
            #endregion

            #region [ Filters ]
            services.AddScoped<AuditoriaFilter>();
            #endregion

            return services;
        }
    }
}
