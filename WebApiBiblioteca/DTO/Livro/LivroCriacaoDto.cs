﻿using WebApiBiblioteca.DTO.Vinculo;
using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.DTO.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
