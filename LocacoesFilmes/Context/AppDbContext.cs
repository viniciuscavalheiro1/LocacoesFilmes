using LocacoesFilmes.Models;
using Microsoft.EntityFrameworkCore;

namespace LocacoesFilmes.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Filme> filme { get; set; }

    }
}
