using System.Reflection;
using System;
using Api.Adaptadores.BD;
using Api.Adaptadores.BD.Repositorios;
using Dominio.Portas.Entrada;
using Api.Tests.Setup;
using System.Linq;

namespace Api.Tests.Repositorios
{
    public class RepositorioAtendimentoTests
    {
        private readonly ContextoBd _contextoBd;
        private readonly IRepositorioAtendimento _repositorioAtendimento;

        public RepositorioAtendimentoTests()
        {
            _contextoBd = InMemoryDbService.GerarContextoBd(Guid.NewGuid().ToString());
            _repositorioAtendimento = new RepositorioAtendimento(_contextoBd);
        }

        [Fact]
        public async Task RepositorioAtendimento_ObterAtendimentosUsuario_Sucesso()
        {
            var atendimentoCadastrado = MockDados.GerarEntidadeAtendimento();
            await _contextoBd.Atendimentos.AddAsync(atendimentoCadastrado);
            await _contextoBd.SaveChangesAsync();

            var atendimentos = await _repositorioAtendimento.ObterAtendimentosUsuario(1);

            Assert.NotNull(atendimentos);
            Assert.Equal(1, atendimentos.Count);
            Assert.Equal(atendimentoCadastrado.LocalAtendimento, atendimentos.First().LocalAtendimento);
            Assert.Equal(atendimentoCadastrado.Data, atendimentos.First().Data);
        }

        [Fact]
        public async Task RepositorioAtendimento_ObterAtendimentosUsuario_NaoEncontrado()
        {
            var atendimentos = await _repositorioAtendimento.ObterAtendimentosUsuario(1);

            Assert.Empty(atendimentos);
        }

        [Fact]
        public async Task RepositorioAtendimento_CadastrarAtendimento_Sucesso()
        {
            var atendimento = MockDados.GerarDTOAtendimento();

            atendimento = await _repositorioAtendimento.CadastrarAtendimento(atendimento);
            var atendimentoBusca = await _contextoBd.Atendimentos.FindAsync(1);

            Assert.NotNull(atendimentoBusca);
            Assert.Equal(atendimento.LocalAtendimento, atendimentoBusca.LocalAtendimento);
            Assert.Equal(atendimento.Data, atendimentoBusca.Data);
        }
    }
}