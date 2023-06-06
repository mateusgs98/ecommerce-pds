using System.Reflection;
using System;
using Api.Adaptadores.BD;
using Api.Adaptadores.BD.Repositorios;
using Dominio.Portas.Entrada;
using Api.Tests.Setup;
using System.Linq;

namespace Api.Tests.Repositorios
{
    public class RepositorioUsuarioTests
    {
        private readonly ContextoBd _contextoBd;
        private readonly IRepositorioUsuario _repositorioUsuario;

        public RepositorioUsuarioTests()
        {
            _contextoBd = InMemoryDbService.GerarContextoBd(Guid.NewGuid().ToString());
            _repositorioUsuario = new RepositorioUsuario(_contextoBd);
        }

        [Fact]
        public async Task RepositorioUsuario_ObterUsuarioPorId_Sucesso()
        {
            var usuarioCadastrado = MockDados.GerarEntidadeUsuario();
            await _contextoBd.Usuarios.AddAsync(usuarioCadastrado);
            await _contextoBd.SaveChangesAsync();

            var usuario = await _repositorioUsuario.ObterUsuario(1);

            Assert.NotNull(usuario);
            Assert.Equal(usuarioCadastrado.Nome, usuario.Nome);
            Assert.Equal(usuarioCadastrado.DataNascimento, usuario.DataNascimento);
            Assert.Equal(usuarioCadastrado.Email, usuario.Email);
        }

        [Fact]
        public async Task RepositorioUsuario_ObterUsuarioPorEmailSenha_Sucesso()
        {
            var usuarioCadastrado = MockDados.GerarEntidadeUsuario();
            await _contextoBd.Usuarios.AddAsync(usuarioCadastrado);
            await _contextoBd.SaveChangesAsync();

            var usuario = await _repositorioUsuario.ObterUsuario("email@email.com", "senha");

            Assert.NotNull(usuario);
            Assert.Equal(usuarioCadastrado.Nome, usuario.Nome);
            Assert.Equal(usuarioCadastrado.DataNascimento, usuario.DataNascimento);
            Assert.Equal(usuarioCadastrado.Email, usuario.Email);
        }

        [Fact]
        public async Task RepositorioUsuario_ObterUsuarioPorEmailSenha_NaoEncontrado()
        {
            var usuario = await _repositorioUsuario.ObterUsuario("email@email.com", "senha");

            Assert.Null(usuario);
        }

        [Fact]
        public async Task RepositorioUsuario_CadastrarUsuario_Sucesso()
        {
            var usuario = MockDados.GerarDTOUsuario();

            usuario = await _repositorioUsuario.CadastrarUsuario(usuario);
            var usuarioBusca = await _contextoBd.Usuarios.FindAsync(1);

            Assert.NotNull(usuarioBusca);
            Assert.Equal(usuario.Nome, usuarioBusca.Nome);
            Assert.Equal(usuario.DataNascimento, usuarioBusca.DataNascimento);
            Assert.Equal(usuario.Email, usuarioBusca.Email);
        }
    }
}