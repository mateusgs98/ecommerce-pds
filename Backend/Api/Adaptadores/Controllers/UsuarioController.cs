using Microsoft.AspNetCore.Mvc;
using Dominio.DTOs;
using Dominio.Portas.Entrada;

namespace Api.Adaptadores.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController
    {
        private readonly IRepositorioUsuario _repositorioUsuario;

        public UsuarioController(IRepositorioUsuario repositorioUsuario)
        {
            _repositorioUsuario = repositorioUsuario ?? throw new ArgumentNullException(nameof(repositorioUsuario));
        }

        [HttpPost("login")]
        public async Task<IResult> Login([FromBody]Usuario usuario)
        {
            var usuarioEncontrado = await _repositorioUsuario.ObterUsuario(usuario.Email, usuario.Senha);
            if (usuarioEncontrado == null)
                return Results.Unauthorized();

            return Results.Ok(usuarioEncontrado);
        }

        [HttpGet("obter/{id}")]
        public async Task<IResult> ObterUsuario([FromRoute]int id)
        {
            var usuario = await _repositorioUsuario.ObterUsuario(id);

            return Results.Ok(usuario);
        }

        [HttpPost("cadastrar")]
        public async Task<IResult> CadastrarUsuario([FromBody]Usuario usuario)
        {
            var usuarioCadastrado = await _repositorioUsuario.CadastrarUsuario(usuario);

            return Results.Ok(usuarioCadastrado);
        }
    }
}