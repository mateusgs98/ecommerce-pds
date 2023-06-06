using Dominio.DTOs;

namespace Dominio.Portas.Entrada
{
    public interface IRepositorioSintoma
    {
        Task<Sintoma> ObterSintoma(int id);

        Task<List<Sintoma>> ObterSintomas();
    }
}
