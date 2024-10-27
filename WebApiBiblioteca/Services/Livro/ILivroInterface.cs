using Azure;
using WebApiBiblioteca.DTO.Livro;
using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.Services.Livro
{
    public interface ILivroInterface
    {
        Task<ResponseModel<List<LivroModel>>> ListarLivros();
        Task<ResponseModel<LivroModel>> BuscarLivroPorId(int idLivro);
        Task<ResponseModel<List<LivroModel>>> BuscarLivroPorIdAutor(int idLivro);
        Task<ResponseModel<List<LivroModel>>> CriarLivro(LivroCriacaoDto LivroCriacaoDto);
        Task<ResponseModel<List<LivroModel>>> EditarLivro(LivroEdicaoDto LivroEdicaoDto);
        Task<ResponseModel<List<LivroModel>>> ExcluirLivro(int idLivro);
    }
}
