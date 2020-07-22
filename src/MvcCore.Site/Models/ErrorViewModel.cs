using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Site.Models
{
    public class ErrorViewModel
    {
        public int CodigoErro { get; set; }
        public string Titulo { get; set; }
        public string Mensagem { get; set; }
    }
}