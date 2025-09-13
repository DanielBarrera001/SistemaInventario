using Microsoft.EntityFrameworkCore;
using SistemaInventario.Models;

namespace SistemaInventario
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
                .HasIndex(p => p.CodigoBarras)
                .IsUnique();
        }

        public DbSet<Movimiento> Movimientos { get; set; } 

    }
}