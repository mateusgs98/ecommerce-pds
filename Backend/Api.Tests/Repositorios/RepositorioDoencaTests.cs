using System.Reflection;
using System;
using Api.Adaptadores.BD;
using Api.Adaptadores.BD.Repositorios;
using Dominio.Portas.Entrada;
using Api.Tests.Setup;
using System.Linq;

namespace Api.Tests.Repositorios
{
    public class RepositorioDoencaTests
    {
        private readonly ContextoBd _contextoBd;
        private readonly IRepositorioDoenca _repositorioDoenca;

        public RepositorioDoencaTests()
        {
            _contextoBd = InMemoryDbService.GerarContextoBd(Guid.NewGuid().ToString());
            _repositorioDoenca = new RepositorioDoenca(_contextoBd);
        }

        [Fact]
        public async Task RepositorioDoenca_ObterDoencas_Sucesso()
        {
            var doencaCadastrada = MockDados.GerarEntidadeDoenca();
            await _contextoBd.Doencas.AddAsync(doencaCadastrada);
            await _contextoBd.SaveChangesAsync();

            var doencas = await _repositorioDoenca.ObterDoencas();

            Assert.NotNull(doencas);
            Assert.Equal(1, doencas.Count);
            Assert.Equal(doencaCadastrada.Nome, doencas.First().Nome);
            Assert.Equal(doencaCadastrada.DataIdentificacao, doencas.First().DataIdentificacao);
            Assert.Equal(doencaCadastrada.Descricao, doencas.First().Descricao);
        }

        [Fact]
        public async Task RepositorioDoenca_ObterDoencas_NaoEncontrado()
        {
            var doencas = await _repositorioDoenca.ObterDoencas();

            Assert.Empty(doencas);
        }

        [Fact]
        public async Task RepositorioDoenca_ObterDoenca_Sucesso()
        {
            var doencaCadastrada = MockDados.GerarEntidadeDoenca();
            await _contextoBd.Doencas.AddAsync(doencaCadastrada);
            await _contextoBd.SaveChangesAsync();

            var doenca = await _repositorioDoenca.ObterDoenca(1);

            Assert.NotNull(doenca);
            Assert.Equal(doencaCadastrada.Nome, doenca.Nome);
            Assert.Equal(doencaCadastrada.DataIdentificacao, doenca.DataIdentificacao);
            Assert.Equal(doencaCadastrada.Descricao, doenca.Descricao);
        }

        [Fact]
        public async Task RepositorioDoenca_CadastrarDoenca_Sucesso()
        {
            var doenca = MockDados.GerarDTODoenca();

            doenca = await _repositorioDoenca.CadastrarDoenca(doenca);
            var doencaBusca = await _contextoBd.Doencas.FindAsync(1);

            Assert.NotNull(doencaBusca);
            Assert.Equal(doenca.Nome, doencaBusca.Nome);
            Assert.Equal(doenca.DataIdentificacao, doencaBusca.DataIdentificacao);
            Assert.Equal(doenca.Descricao, doencaBusca.Descricao);
        }
    }
}