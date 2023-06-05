using Dominio.Portas.Entrada;
using DTOs = Dominio.DTOs;

namespace Api.Adaptadores.BD.Repositorios
{
    public class RepositorioVacina : IRepositorioVacina
    {
        private readonly ContextoBd _contextoBd;
        public RepositorioVacina(ContextoBd contextoBd)
        {
            _contextoBd = contextoBd ?? throw new ArgumentNullException(nameof(contextoBd));
        }

        public async Task<DTOs.Vacina> ObterVacina(int id)
        {
            var vacina = await _contextoBd.Vacinas.FindAsync(id);
            var doenca = await _contextoBd.Doencas.FindAsync(id);

            return new DTOs.Vacina
            {
                Id = vacina.Id,
                Nome = vacina.Nome,
                Fabricante = vacina.FabricanteId,
                Doses= vacina.DosesImunizacao,
                DataAprovacao= vacina.DataAprovacao,
                DataFabricacao= vacina.DataFabricacao,
                PeriodoEntreDoses = vacina.PeriodoEntreDoses,
                Patogeno = vacina.PatogenoId

            };
        }

        public async Task<DTOs.Vacina> CadastrarVacina(DTOs.Vacina vacina)
        {
            var entidadeVacina = new Entidades.Vacina
            {
                Nome = vacina.Nome,
                FabricanteId = vacina.Fabricante,
                DosesImunizacao = vacina.Doses,
                DataAprovacao = vacina.DataAprovacao,
                DataFabricacao = vacina.DataFabricacao,
                PeriodoEntreDoses = vacina.PeriodoEntreDoses,
                PatogenoId = vacina.Patogeno


            };

            await _contextoBd.Vacinas.AddAsync(entidadeVacina);
            await _contextoBd.SaveChangesAsync();

            vacina.Id = entidadeVacina.Id;

            return vacina;
        }

        public async Task<IEnumerable<DTOs.Vacina>> ObterVacinas()
        {
            var vacinas = await _contextoBd.Vacinas.FindAsync();

            return (IEnumerable<DTOs.Vacina>)vacinas;

        }

    }
}
