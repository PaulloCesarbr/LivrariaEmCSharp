using LivrariaEmCSharp.Models;
using Microsoft.EntityFrameworkCore;

namespace LivrariaEmCSharp.Data
{
    public class AppDbContext : DbContext
    {
        // Construtor da classe AppDbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }  
    }
}
