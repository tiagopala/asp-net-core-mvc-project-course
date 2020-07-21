using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MvcCore.Site.Areas.Identity.Data;
using MvcCore.Site.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Site.Configuration
{
    public static class IdentityConfig
    {
        public static IServiceCollection ResolveIdentity(this IServiceCollection services, IConfiguration configuration)
        {
            #region Cookies
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            #endregion

            #region IdentityDb
            services.AddDbContext<MvcCoreSiteContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MvcCoreSiteContextConnection")));
            #endregion

            #region GeneralIdentityConfig
            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<MvcCoreSiteContext>();
            #endregion

            return services;
        }
    }
}
