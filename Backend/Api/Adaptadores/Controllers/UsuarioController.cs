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

        [HttpGet("obter/{id}")]
        public async Task<Usuario> ObterUsuario([FromRoute]int id)
        {
            return await _repositorioUsuario.ObterUsuario(id);
        }

        [HttpPost("cadastrar")]
        public async Task<Usuario> CadastrarUsuario([FromBody]Usuario usuario)
        {
            return await _repositorioUsuario.CadastrarUsuario(usuario);
        }
    }
}