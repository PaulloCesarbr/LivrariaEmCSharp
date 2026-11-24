using LivrariaEmCSharp.Data;
using LivrariaEmCSharp.Models;
using Microsoft.EntityFrameworkCore;

namespace LivrariaEmCSharp.Repositories
{
    public class LivroRepository : ILivroRepository
    {

        // Variavel para acesso ao banco de dados
        private readonly AppDbContext _context;

        public LivroRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Livro>> ListarTodos()
        {
            return await _context.Livros.Include(I => I.Categoria).ToListAsync();
        }

        public async Task Adicionar(Livro livro)
        {
            await _context.Livros.AddAsync(livro);
            await _context.SaveChangesAsync();
        }
    }
}
