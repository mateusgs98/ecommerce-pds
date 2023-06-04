using Microsoft.AspNetCore.Mvc;
using Dominio.Portas.Entrada;

namespace Api.Adaptadores.Controllers
{
    [ApiController]
    [Route("api/tipoimunizacao")]
    public class TipoImunizacaoController
    {
        private readonly IRepositorioTipoImunizacao _repositorioTipoImunizacao;

        public TipoImunizacaoController(IRepositorioTipoImunizacao repositorioTipoImunizacao)
        {
            _repositorioTipoImunizacao = repositorioTipoImunizacao ?? throw new ArgumentNullException(nameof(repositorioTipoImunizacao));
        }

        
        [HttpGet("obter/{id}")]
        public async Task<IResult> ObterTipoImunizacao([FromRoute] int id)
        {
            var tipoImunizacao = await _repositorioTipoImunizacao.ObterTipoImunizacao(id);

            return Results.Ok(tipoImunizacao);
        }

    }
}
