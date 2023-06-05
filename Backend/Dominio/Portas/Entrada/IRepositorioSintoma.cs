using Dominio.DTOs;

namespace Dominio.Portas.Entrada
{
    public interface IRepositorioSintoma
    {
        Task<Sintoma> ObterSintoma(int id);

        Task<Sintoma> CadastrarSintoma(Sintoma sintoma);

        Task<List<Sintoma>> ObterSintomas();
    }
}
