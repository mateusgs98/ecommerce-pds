using Dominio.DTOs;

namespace Dominio.Portas.Entrada
{
    public interface IRepositorioAtendimento
    {
        Task<List<Atendimento>> ObterAtendimentosUsuario(int idUsuario);
        Task<Atendimento> CadastrarAtendimento(Atendimento atendimento);
    }
}