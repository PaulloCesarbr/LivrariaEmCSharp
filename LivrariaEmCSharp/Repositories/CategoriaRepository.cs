using LivrariaEmCSharp.Data;
using LivrariaEmCSharp.Models;
using Microsoft.EntityFrameworkCore;

namespace LivrariaEmCSharp.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {

        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Categoria>> ListarTodos()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task Adicionar(Categoria categoria)
        {
            await _context.Categorias.AddAsync(categoria);
            await _context.SaveChangesAsync();
        }

    }
}
