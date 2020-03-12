using Examen2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Llamadas> Llamadas { get; set; }

        public DbSet<LlamadasDetalle> LlamadasDetalles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data source = Database\LlamadasData.db");
        }
    }
}
