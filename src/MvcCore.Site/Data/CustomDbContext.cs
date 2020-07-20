using Microsoft.EntityFrameworkCore;
using MvcCore.Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Site.Data
{
    public class CustomDbContext : DbContext
    {
        public CustomDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Aluno> Alunos { get; set; }

    }
}
