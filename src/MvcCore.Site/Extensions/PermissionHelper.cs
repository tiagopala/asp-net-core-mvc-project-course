using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Site.Extensions
{

    // Define se o usuário autenticado possui a ClaimType "Permissoes" e a algum Claim Value informado na Policy. ex: PodeAdicionar / PodeExcluir
    public class PermissoesRequirement : IAuthorizationRequirement
    {
        public string Permissao { get; set; }

        public PermissoesRequirement(string permissao)
        {
            Permissao = permissao;
        }
    }

    public class PermissoesRequirementHandler : AuthorizationHandler<PermissoesRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissoesRequirement requisito)
        {
            if(context.User.HasClaim(x => x.Type == "Permissoes" && x.Value.Contains(requisito.Permissao)))
            {
                context.Succeed(requisito);
            }

            return Task.CompletedTask;
        }
    }
}
