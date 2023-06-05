using Microsoft.AspNetCore.Mvc;
using Dominio.Portas.Entrada;
using System.Collections.Generic;
using System.Collections;
using Api.Adaptadores.BD.Entidades;

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

        
        [HttpGet("obter/")]
        public async Task<IResult> ObterTipoImunizacao([FromRoute] int id)
        {
            var tipoImunizacao = await _repositorioTipoImunizacao.ObterTipoImunizacao(id);

            return Results.Ok(tipoImunizacao);
        }

       

    }
}
