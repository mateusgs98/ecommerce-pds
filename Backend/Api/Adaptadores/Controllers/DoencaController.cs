using Microsoft.AspNetCore.Mvc;
using Dominio.DTOs;
using Dominio.Portas.Entrada;
using Api.Adaptadores.BD.Repositorios;

namespace Api.Adaptadores.Controllers
{
    [ApiController]
    [Route("api/doenca")]
    public class DoencaController
    {
        private readonly IRepositorioDoenca _repositorioDoenca;

        public DoencaController(IRepositorioDoenca repositorioDoenca)
        {
            _repositorioDoenca = repositorioDoenca ?? throw new ArgumentNullException(nameof(repositorioDoenca));
        }


        [HttpGet("obter/{id}")]
        public async Task<IResult> ObterDoenca([FromRoute] int id)
        {
            var Doenca = await _repositorioDoenca.ObterDoenca(id);

            return Results.Ok(Doenca);
        }

        [HttpPost("cadastrar")]
        public async Task<IResult> CadastrarDoenca([FromBody] Doenca doenca)
        {
            var DoencaCadastrada = await _repositorioDoenca.CadastrarDoenca(doenca);

            return Results.Ok(DoencaCadastrada);
        }

      


    }
}
