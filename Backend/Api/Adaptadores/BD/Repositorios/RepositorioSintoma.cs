using Dominio.Portas.Entrada;
using DTOs = Dominio.DTOs;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Api.Adaptadores.BD.Repositorios
{
    public class RepositorioSintoma : IRepositorioSintoma
    {
        private readonly ContextoBd _contextoBd;
        public RepositorioSintoma(ContextoBd contextoBd)
        {
            _contextoBd = contextoBd ?? throw new ArgumentNullException(nameof(contextoBd));
        }

        public async Task<DTOs.Sintoma> ObterSintoma(int id)
        {
            var sintoma = await _contextoBd.Sintomas.FindAsync(id);

            return new DTOs.Sintoma
            {
                Id = sintoma.Id,
                Descricao = sintoma.Descricao

            };
        }

        public async Task<List<DTOs.Sintoma>> ObterSintomas()
        {
            var sintomas = await _contextoBd.Sintomas.ToListAsync();

            return sintomas.Select(s => new DTOs.Sintoma
            {
                Id = s.Id,
                Descricao = s.Descricao
            }).ToList();

        }

    }
}
