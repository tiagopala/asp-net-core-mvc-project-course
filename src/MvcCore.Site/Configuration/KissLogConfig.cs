using KissLog.Apis.v1.Listeners;
using KissLog.AspNetCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Diagnostics;
using System.Text;

namespace MvcCore.Site.Configuration
{
    public class KissLogConfig
    {
        public void ConfigureKissLog(IOptionsBuilder options, IConfiguration configuration)
        {
            // register KissLog.net cloud listener
            options.Listeners.Add(new KissLogApiListener(new KissLog.Apis.v1.Auth.Application(
                configuration["KissLog.OrganizationId"],    //  "d7910d65-e18a-43a1-9605-b5084bbeaf37"
                configuration["KissLog.ApplicationId"])     //  "2064ee11-ebce-48c9-9cf0-34bb7c1915bf"
            )
            {
                ApiUrl = configuration["KissLog.ApiUrl"]    //  "https://api.kisslog.net"
            });

            // optional KissLog configuration
            options.Options
                .AppendExceptionDetails((Exception ex) =>
                {
                    StringBuilder sb = new StringBuilder();

                    if (ex is System.NullReferenceException nullRefException)
                    {
                        sb.AppendLine("Important: check for null references");
                    }

                    return sb.ToString();
                });

            // KissLog internal logs
            options.InternalLog = (message) =>
            {
                Debug.WriteLine(message);
            };
        }
    }
}
