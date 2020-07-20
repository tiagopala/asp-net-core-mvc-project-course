using Microsoft.AspNetCore.Mvc;
using MvcCore.Site.Data;
using MvcCore.Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Site.Controllers
{
    public class CrudController : Controller
    {
        private readonly CustomDbContext _context;

        public CrudController(CustomDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Conceitos de CRUD usando o Entity Framework

            // Create
            var aluno = new Aluno
            {
                Nome = "Tiago",
                DataNascimento = DateTime.Now,
                Email = "tiago@gmail.com"
            };

            _context.Alunos.Add(aluno); // Salvando em memória
            _context.SaveChanges();     // Realizando operação no Banco de Dados

            // Read
            var aluno2 = _context.Alunos.Find(aluno.Id); 
            var aluno3 = _context.Alunos.FirstOrDefault(x => x.Email == aluno.Email); // Recuperando com base em uma propriedade da classe

            // Update
            aluno.Nome = "Tiago Pala";
            _context.Alunos.Update(aluno);
            _context.SaveChanges();

            // Delete
            _context.Alunos.Remove(aluno);
            _context.SaveChanges();

            return View();
        }
    }
}
