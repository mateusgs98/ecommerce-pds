using System.Reflection;
using System;
using Api.Adaptadores.BD;
using Api.Adaptadores.BD.Repositorios;
using Dominio.Portas.Entrada;
using Api.Tests.Setup;
using System.Linq;

namespace Api.Tests.Repositorios
{
    public class RepositorioVacinaTests
    {
        private readonly ContextoBd _contextoBd;
        private readonly IRepositorioVacina _repositorioVacina;

        public RepositorioVacinaTests()
        {
            _contextoBd = InMemoryDbService.GerarContextoBd(Guid.NewGuid().ToString());
            _repositorioVacina = new RepositorioVacina(_contextoBd);
        }

        [Fact]
        public async Task RepositorioVacina_ObterVacinas_Sucesso()
        {
            var vacinaCadastrada = MockDados.GerarEntidadeVacina();
            await _contextoBd.Vacinas.AddAsync(vacinaCadastrada);
            await _contextoBd.SaveChangesAsync();

            var vacinas = await _repositorioVacina.ObterVacinas();

            Assert.NotNull(vacinas);
            Assert.Equal(1, vacinas.Count);
            Assert.Equal(vacinaCadastrada.Nome, vacinas.First().Nome);
            Assert.Equal(vacinaCadastrada.DataFabricacao, vacinas.First().DataFabricacao);
            Assert.Equal(vacinaCadastrada.DataAprovacao, vacinas.First().DataAprovacao);
            Assert.Equal(vacinaCadastrada.DosesImunizacao, vacinas.First().Doses);
            Assert.Equal(vacinaCadastrada.PeriodoEntreDoses, vacinas.First().PeriodoEntreDoses);
            Assert.Equal(vacinaCadastrada.EficaciaComprovada, vacinas.First().EficaciaComprovada);
        }

        [Fact]
        public async Task RepositorioVacina_ObterVacinas_NaoEncontrado()
        {
            var vacinas = await _repositorioVacina.ObterVacinas();

            Assert.Empty(vacinas);
        }

        [Fact]
        public async Task RepositorioVacina_ObterVacina_Sucesso()
        {
            var vacinaCadastrada = MockDados.GerarEntidadeVacina();
            await _contextoBd.Vacinas.AddAsync(vacinaCadastrada);
            await _contextoBd.SaveChangesAsync();

            var vacina = await _repositorioVacina.ObterVacina(1);

            Assert.NotNull(vacina);
            Assert.Equal(vacinaCadastrada.Nome, vacina.Nome);
            Assert.Equal(vacinaCadastrada.DataFabricacao, vacina.DataFabricacao);
            Assert.Equal(vacinaCadastrada.DataAprovacao, vacina.DataAprovacao);
            Assert.Equal(vacinaCadastrada.DosesImunizacao, vacina.Doses);
            Assert.Equal(vacinaCadastrada.PeriodoEntreDoses, vacina.PeriodoEntreDoses);
            Assert.Equal(vacinaCadastrada.EficaciaComprovada, vacina.EficaciaComprovada);
        }

        [Fact]
        public async Task RepositorioVacina_CadastrarVacina_Sucesso()
        {
            var vacina = MockDados.GerarDTOVacina();

            vacina = await _repositorioVacina.CadastrarVacina(vacina);
            var vacinaBusca = await _contextoBd.Vacinas.FindAsync(1);

            Assert.NotNull(vacinaBusca);
            Assert.Equal(vacina.Nome, vacinaBusca.Nome);
            Assert.Equal(vacina.DataFabricacao, vacinaBusca.DataFabricacao);
            Assert.Equal(vacina.DataAprovacao, vacinaBusca.DataAprovacao);
            Assert.Equal(vacina.Doses, vacinaBusca.DosesImunizacao);
            Assert.Equal(vacina.PeriodoEntreDoses, vacinaBusca.PeriodoEntreDoses);
            Assert.Equal(vacina.EficaciaComprovada, vacinaBusca.EficaciaComprovada);
        }
    }
}