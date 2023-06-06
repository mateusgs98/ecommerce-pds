using System.Reflection;
using System;
using Api.Adaptadores.BD;
using Api.Adaptadores.BD.Repositorios;
using Dominio.Portas.Entrada;
using Api.Tests.Setup;
using System.Linq;

namespace Api.Tests.Repositorios
{
    public class RepositorioTipoImunizacaoTests
    {
        private readonly ContextoBd _contextoBd;
        private readonly IRepositorioTipoImunizacao _repositorioTipoImunizacao;

        public RepositorioTipoImunizacaoTests()
        {
            _contextoBd = InMemoryDbService.GerarContextoBd(Guid.NewGuid().ToString());
            _repositorioTipoImunizacao = new RepositorioTipoImunizacao(_contextoBd);
        }

        [Fact]
        public async Task RepositorioTipoImunizacao_ObterTiposImunizacao_Sucesso()
        {
            var tipoImunizacaocadastrado = MockDados.GerarEntidadeTipoImunizacao();
            await _contextoBd.TiposImunizacao.AddAsync(tipoImunizacaocadastrado);
            await _contextoBd.SaveChangesAsync();

            var tipoImunizacaos = await _repositorioTipoImunizacao.ObterTiposImunizacao();

            Assert.NotNull(tipoImunizacaos);
            Assert.Equal(1, tipoImunizacaos.Count);
            Assert.Equal(tipoImunizacaocadastrado.Nome, tipoImunizacaos.First().Nome);
        }

        [Fact]
        public async Task RepositorioTipoImunizacao_ObterTiposImunizacao_NaoEncontrado()
        {
            var tipoImunizacaos = await _repositorioTipoImunizacao.ObterTiposImunizacao();

            Assert.Empty(tipoImunizacaos);
        }

        [Fact]
        public async Task RepositorioTipoImunizacao_ObterTipoImunizacao_Sucesso()
        {
            var tipoImunizacaocadastrado = MockDados.GerarEntidadeTipoImunizacao();
            await _contextoBd.TiposImunizacao.AddAsync(tipoImunizacaocadastrado);
            await _contextoBd.SaveChangesAsync();

            var tipoImunizacao = await _repositorioTipoImunizacao.ObterTipoImunizacao(1);

            Assert.NotNull(tipoImunizacao);
            Assert.Equal(tipoImunizacaocadastrado.Nome, tipoImunizacao.Nome);
        }
    }
}