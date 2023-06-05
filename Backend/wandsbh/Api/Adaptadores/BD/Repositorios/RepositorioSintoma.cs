using Dominio.Portas.Entrada;
using DTOs = Dominio.DTOs;

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

        public async Task<DTOs.Sintoma> CadastrarSintoma(DTOs.Sintoma sintoma)
        {
            var entidadeSintoma = new Entidades.Sintoma
            {
                Descricao = sintoma.Descricao
            };

            await _contextoBd.Sintomas.AddAsync(entidadeSintoma);
            await _contextoBd.SaveChangesAsync();

            sintoma.Id = entidadeSintoma.Id;

            return sintoma;
        }

        public async Task<IEnumerable<DTOs.Sintoma>> ObterSintomas()
        {
            var sintomas = await _contextoBd.Sintomas.FindAsync();

            return (IEnumerable<DTOs.Sintoma>)sintomas;

        }

    }
}
