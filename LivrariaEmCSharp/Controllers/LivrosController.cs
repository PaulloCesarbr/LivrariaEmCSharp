using LivrariaEmCSharp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaEmCSharp.Controllers
{
    [Route("api/[controller]")] // /api/livros
    [ApiController]
    public class LivrosController : ControllerBase
    {

        private readonly ILivroRepository _repository;

        public LivrosController(ILivroRepository livroRepository)
        {
            _repository = livroRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _repository.ListarTodos());


        [HttpGet("boasvindas")] // /api/livros/boasvindas
        public IActionResult GetBoasVindas()
        {
            return Ok("Bem-vindos ao sistema de livraria!");
        }
    }
}
