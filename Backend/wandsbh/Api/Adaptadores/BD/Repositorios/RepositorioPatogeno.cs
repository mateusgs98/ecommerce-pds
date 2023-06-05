using Dominio.Portas.Entrada;
using DTOs = Dominio.DTOs;

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

        public async Task<DTOs.Patogeno> CadastrarPatogeno(DTOs.Patogeno patogeno)
        {
            var entidadePatogeno = new Entidades.Patogeno
            {
                Nome = patogeno.Nome
            };

            await _contextoBd.Patogenos.AddAsync(entidadePatogeno);
            await _contextoBd.SaveChangesAsync();

            patogeno.Id = entidadePatogeno.Id;

            return patogeno;
        }

        public async Task<IEnumerable<DTOs.Patogeno>> ObterPatogenos()
        {
            var patogenos = await _contextoBd.Patogenos.FindAsync();
            
            return (IEnumerable<DTOs.Patogeno>)patogenos;

        }

    }
}
