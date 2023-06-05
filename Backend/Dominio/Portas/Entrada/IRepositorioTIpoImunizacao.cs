using Dominio.DTOs;


namespace Dominio.Portas.Entrada
{
    public interface IRepositorioTipoImunizacao
    {
        Task<TipoImunizacao> ObterTipoImunizacao(int id);
    }
}
