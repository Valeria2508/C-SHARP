using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud_Docente.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_Docente.data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Docente> Docentes { get; set; } //docentes se llama en mi db, docente es mi modelo
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}