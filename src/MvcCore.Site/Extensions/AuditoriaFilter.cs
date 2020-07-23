using KissLog;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MvcCore.Site.Extensions
{
    public class AuditoriaFilter : IActionFilter
    {
        private readonly ILogger _logger;

        public AuditoriaFilter(ILogger logger)
        {
            _logger = logger;
        }

        public void OnActionExecuted(ActionExecutedContext context){}

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                var message = $"Usuário {context.HttpContext.User.Identity.Name} acessou {context.HttpContext.Request.Host}{context.HttpContext.Request.Path}";

                _logger.Info(message);
            }
        }
    }
}
