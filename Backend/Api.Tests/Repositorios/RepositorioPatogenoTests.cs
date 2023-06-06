using System.Reflection;
using System;
using Api.Adaptadores.BD;
using Api.Adaptadores.BD.Repositorios;
using Dominio.Portas.Entrada;
using Api.Tests.Setup;
using System.Linq;

namespace Api.Tests.Repositorios
{
    public class RepositorioPatogenoTests
    {
        private readonly ContextoBd _contextoBd;
        private readonly IRepositorioPatogeno _repositorioPatogeno;

        public RepositorioPatogenoTests()
        {
            _contextoBd = InMemoryDbService.GerarContextoBd(Guid.NewGuid().ToString());
            _repositorioPatogeno = new RepositorioPatogeno(_contextoBd);
        }

        [Fact]
        public async Task RepositorioPatogeno_ObterPatogenos_Sucesso()
        {
            var patogenocadastrado = MockDados.GerarEntidadePatogeno();
            await _contextoBd.Patogenos.AddAsync(patogenocadastrado);
            await _contextoBd.SaveChangesAsync();

            var patogenos = await _repositorioPatogeno.ObterPatogenos();

            Assert.NotNull(patogenos);
            Assert.Equal(1, patogenos.Count);
            Assert.Equal(patogenocadastrado.Nome, patogenos.First().Nome);
        }

        [Fact]
        public async Task RepositorioPatogeno_ObterPatogenos_NaoEncontrado()
        {
            var patogenos = await _repositorioPatogeno.ObterPatogenos();

            Assert.Empty(patogenos);
        }

        [Fact]
        public async Task RepositorioPatogeno_ObterPatogeno_Sucesso()
        {
            var patogenocadastrado = MockDados.GerarEntidadePatogeno();
            await _contextoBd.Patogenos.AddAsync(patogenocadastrado);
            await _contextoBd.SaveChangesAsync();

            var patogeno = await _repositorioPatogeno.ObterPatogeno(1);

            Assert.NotNull(patogeno);
            Assert.Equal(patogenocadastrado.Nome, patogeno.Nome);
        }
    }
}