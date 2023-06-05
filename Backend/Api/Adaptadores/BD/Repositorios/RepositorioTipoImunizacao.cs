using Dominio.Portas.Entrada;
using Api.Adaptadores.BD;
using Entidades = Api.Adaptadores.BD.Entidades;
using DTOs = Dominio.DTOs;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Api.Adaptadores.BD.Repositorios
{
    public class RepositorioTipoImunizacao : IRepositorioTipoImunizacao
    {
         private readonly ContextoBd _contextoBd;
        public RepositorioTipoImunizacao(ContextoBd contextoBd)
        {
            _contextoBd = contextoBd ?? throw new ArgumentNullException(nameof(contextoBd));
        }

        public async Task<DTOs.TipoImunizacao> ObterTipoImunizacao(int id)
        {
            var tipoImunizacao = await _contextoBd.TiposImunizacao.FindAsync(id);

            return new DTOs.TipoImunizacao
            {
                Id = tipoImunizacao.Id,
                Nome = tipoImunizacao.Descricao
                
            };
        }

     }
}
