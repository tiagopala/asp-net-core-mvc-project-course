using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using MvcCore.Site.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Site.Configuration
{
    public static class AuthorizationConfig
    {
        public static IServiceCollection ResolverAuthorization(this IServiceCollection services)
        {
            #region AuthConfig

            services.AddAuthorization(options =>
            {
                options.AddPolicy("PodeEditar", policy => policy.RequireClaim("PodeEditar"));

                options.AddPolicy("PodeExcluir", policy => policy.AddRequirements(new PermissoesRequirement("PodeExcluir")));
                options.AddPolicy("PodeAdicionar", policy => policy.AddRequirements(new PermissoesRequirement("PodeAdicionar")));
            });

            #endregion

            #region

            services.AddSingleton<IAuthorizationHandler, PermissoesRequirementHandler>();

            #endregion

            return services;
        }
    }
}
