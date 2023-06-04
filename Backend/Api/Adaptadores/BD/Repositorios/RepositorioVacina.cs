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
                //DoencaEvitada = vacina.DoencaEvitada,
                Fabricante = vacina.Fabricante,
                Doses= vacina.Doses,
                PeriodoEntreDoses = vacina.PeriodoEntreDoses,
                //TipoImunizacao = vacina.TipoImunizacao

            };
        }

        public async Task<DTOs.Vacina> CadastrarVacina(DTOs.Vacina vacina)
        {
            var entidadeVacina = new Entidades.Vacina
            {
                Nome = vacina.Nome,
                Fabricante= vacina.Fabricante,
                //DoencaEvitada = vacina.DoencaEvitada,
                Doses = vacina.Doses,
                PeriodoEntreDoses = vacina.PeriodoEntreDoses,
                //TipoImunizacao = vacina.TipoImunizacao


            };

            await _contextoBd.Vacinas.AddAsync(entidadeVacina);
            await _contextoBd.SaveChangesAsync();

            vacina.Id = entidadeVacina.Id;

            return vacina;
        }

    }
}
