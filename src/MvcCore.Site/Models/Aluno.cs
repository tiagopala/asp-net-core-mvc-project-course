using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Site.Models
{
    public class Aluno
    {
        public Guid Id { get; private set; }
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public Aluno()
        {
            Id = Guid.NewGuid();
        }
    }
}
