using System.ComponentModel.DataAnnotations;

namespace LivrariaEmCSharp.Models
{
    public class Livro
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]

        public string Titulo { get; set; } = string.Empty;

        [Required]
        [MaxLength(60)]
        public string Autor { get; set; } = string.Empty;

        public int AnoLancamento { get; set; }
        public int CategoriaId { get; set; } // Chave estrangeira para a categoria
        public Categoria? Categoria { get; set; } // Propriedade de navegação/busca para a categoria
    }
}
