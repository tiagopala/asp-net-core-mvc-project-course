using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcCore.Site.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    [Authorize]
    public class CadastroController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Inserir()
        {
            return View();
        }

        [Authorize(Roles = "Admin, Gestor")]
        public IActionResult SecretRole()
        {
            return View();
        }

        [Authorize(Policy = "PodeEditar")]
        public IActionResult SecretClaim()
        {
            return View("SecretRole");
        }

        [Authorize(Policy = "PodeExcluir")]
        public IActionResult SecretClaimValue()
        {
            return View("SecretRole");
        }
    }
}
