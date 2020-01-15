using Microsoft.EntityFrameworkCore;
using SCModelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCData
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<SalaCinema> SalasCinemas { get; set; }
        public DbSet<Filmes> Filmes { get; set; }
        public DbSet<SalaFilme> SalasFilmes { get; set; }
        public DbSet<HDisponivel> HDisponiveis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalaFilme>(entity =>
            {
                entity.HasKey(e => new { e.SalaId, e.FilmeId });
            });
        }
    }
}
