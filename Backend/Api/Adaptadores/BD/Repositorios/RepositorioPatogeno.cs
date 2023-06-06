using Dominio.Portas.Entrada;
using DTOs = Dominio.DTOs;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Api.Adaptadores.BD.Repositorios
{
    public class RepositorioPatogeno : IRepositorioPatogeno
    {
        private readonly ContextoBd _contextoBd;
        public RepositorioPatogeno(ContextoBd contextoBd)
        {
            _contextoBd = contextoBd ?? throw new ArgumentNullException(nameof(contextoBd));
        }

        public async Task<DTOs.Patogeno> ObterPatogeno(int id)
        {
            var patogeno = await _contextoBd.Patogenos.FindAsync(id);

            return new DTOs.Patogeno
            {
                Id = patogeno.Id,
                Nome = patogeno.Nome

            };
        }

        public async Task<List<DTOs.Patogeno>> ObterPatogenos()
        {
            var patogenos = await _contextoBd.Patogenos.ToListAsync();
            
            return patogenos.Select(p => new DTOs.Patogeno
            {
                Id = p.Id,
                Nome = p.Nome
            }).ToList();

        }

    }
}
