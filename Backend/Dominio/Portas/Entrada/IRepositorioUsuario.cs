using Dominio.DTOs;

namespace Dominio.Portas.Entrada
{
    public interface IRepositorioUsuario
    {
        Task<Usuario> ObterUsuario(int id);
        Task<int> ObterUsuario(string email, string senha);
        Task<Usuario> CadastrarUsuario(Usuario usuario);
    }
}