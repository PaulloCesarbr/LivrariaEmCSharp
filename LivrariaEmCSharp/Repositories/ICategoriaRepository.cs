using LivrariaEmCSharp.Models;

namespace LivrariaEmCSharp.Repositories
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<Categoria>> ListarTodos();
        Task Adicionar(Categoria categoria);

    }
}
