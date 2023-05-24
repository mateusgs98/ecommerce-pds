using Dominio.Portas.Entrada;
using Api.Adaptadores.BD;
using Entidades = Api.Adaptadores.BD.Entidades;
using DTOs = Dominio.DTOs;

namespace Api.Adaptadores.BD.Repositorios
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private readonly ContextoBd _contextoBd;

        public RepositorioUsuario(ContextoBd contextoBd)
        {
            _contextoBd = contextoBd ?? throw new ArgumentNullException(nameof(contextoBd));
        }

        public async Task<DTOs.Usuario> ObterUsuario(int id)
        {
            var usuario = await _contextoBd.Usuarios.FindAsync(id);

            return new DTOs.Usuario
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Email = usuario.Email,
                Senha = usuario.Senha
            };
        }

        public async Task<DTOs.Usuario> CadastrarUsuario(DTOs.Usuario usuario)
        {
            var entidadeUsuario = new Entidades.Usuario
            {
                Nome = usuario.Nome,
                Email = usuario.Email,
                Senha = usuario.Senha
            };

            await _contextoBd.Usuarios.AddAsync(entidadeUsuario);

            usuario.Id = entidadeUsuario.Id;

            return usuario;
        }
    }
}