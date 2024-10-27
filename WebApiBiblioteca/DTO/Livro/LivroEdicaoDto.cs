using WebApiBiblioteca.DTO.Vinculo;
using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.DTO.Livro
{
    public class LivroEdicaoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public AutorVinculoDto Autor { get; set; }
    }
}
