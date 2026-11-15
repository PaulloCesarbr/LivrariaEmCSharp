using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaEmCSharp.Controllers
{
    [Route("api/[controller]")] // /api/livros
    [ApiController]
    public class LivrosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetLivros()
        {
        var livrosBancoFalso = new List<string>
        {
            "Varity",
            "Os elefantes não esquecem",
            "Beladonna",
            "Hetty Potter"
        };
        
            return Ok(livrosBancoFalso);
        }
    }
}
