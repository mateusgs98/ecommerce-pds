using Microsoft.AspNetCore.Mvc;
using Dominio.DTOs;
using Dominio.Portas.Entrada;

namespace Api.Adaptadores.Controllers
{
    [ApiController]
    [Route("api/atendimento")]
    public class AtendimentoController
    {
        private readonly IRepositorioAtendimento _repositorioAtendimento;

        public AtendimentoController(IRepositorioAtendimento repositorioAtendimento)
        {
            _repositorioAtendimento = repositorioAtendimento ?? throw new ArgumentNullException(nameof(repositorioAtendimento));
        }

        [HttpGet("ObterAtendimentosUsuario/{idUsuario}")]
        public async Task<IResult> ObterAtendimentosUsuario([FromRoute]int idUsuario)
        {
            var atendimentos = await _repositorioAtendimento.ObterAtendimentosUsuario(idUsuario);

            return Results.Ok(atendimentos);
        }

        [HttpPost("CadastrarAtendimento")]
        public async Task<IResult> CadastrarAtendimento([FromBody]Atendimento atendimento)
        {
            var atendimentoCadastrado = await _repositorioAtendimento.CadastrarAtendimento(atendimento);

            return Results.Ok(atendimentoCadastrado);
        }
    }
}