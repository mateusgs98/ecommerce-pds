using System.Reflection;
using System;
using Api.Adaptadores.BD;
using Api.Adaptadores.BD.Repositorios;
using Dominio.Portas.Entrada;
using Api.Tests.Setup;
using System.Linq;

namespace Api.Tests.Repositorios
{
    public class RepositorioSintomaTests
    {
        private readonly ContextoBd _contextoBd;
        private readonly IRepositorioSintoma _repositorioSintoma;

        public RepositorioSintomaTests()
        {
            _contextoBd = InMemoryDbService.GerarContextoBd(Guid.NewGuid().ToString());
            _repositorioSintoma = new RepositorioSintoma(_contextoBd);
        }

        [Fact]
        public async Task RepositorioSintoma_ObterSintomas_Sucesso()
        {
            var sintomacadastrado = MockDados.GerarEntidadeSintoma();
            await _contextoBd.Sintomas.AddAsync(sintomacadastrado);
            await _contextoBd.SaveChangesAsync();

            var sintomas = await _repositorioSintoma.ObterSintomas();

            Assert.NotNull(sintomas);
            Assert.Equal(1, sintomas.Count);
            Assert.Equal(sintomacadastrado.Descricao, sintomas.First().Descricao);
        }

        [Fact]
        public async Task RepositorioSintoma_ObterSintomas_NaoEncontrado()
        {
            var sintomas = await _repositorioSintoma.ObterSintomas();

            Assert.Empty(sintomas);
        }

        [Fact]
        public async Task RepositorioSintoma_ObterSintoma_Sucesso()
        {
            var sintomacadastrado = MockDados.GerarEntidadeSintoma();
            await _contextoBd.Sintomas.AddAsync(sintomacadastrado);
            await _contextoBd.SaveChangesAsync();

            var sintoma = await _repositorioSintoma.ObterSintoma(1);

            Assert.NotNull(sintoma);
            Assert.Equal(sintomacadastrado.Descricao, sintoma.Descricao);
        }
    }
}