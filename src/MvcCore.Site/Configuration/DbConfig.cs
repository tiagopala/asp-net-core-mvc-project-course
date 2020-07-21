using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MvcCore.Site.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Site.Configuration
{
    public static class DbConfig
    {
        public static IServiceCollection ResolveDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CustomDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("CustomDbContext")));

            return services;
        }
    }
}
