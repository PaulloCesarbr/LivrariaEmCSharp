using LivrariaEmCSharp.Models;

namespace LivrariaEmCSharp.Repositories
{
    public interface ILivroRepository
    {
        //Prometa que vai me devolver uma lista de objetos do tipo Livro
        Task<IEnumerable<Livro>> ListarTodos();

        //Metodo para adicionar novos registros de livros
        Task Adicionar(Livro livro);
    }
}
