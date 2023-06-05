using Dominio.DTOs;


namespace Dominio.Portas.Entrada
{
    public interface IRepositorioPatogeno
    {

        Task<Patogeno> ObterPatogeno(int id);

        Task<IEnumerable<Patogeno>> ObterPatogenos();
    }
}
