﻿using Microsoft.AspNetCore.Mvc;
using Dominio.Portas.Entrada;
using System.Collections.Generic;
using System.Collections;
using Api.Adaptadores.BD.Entidades;

namespace Api.Adaptadores.Controllers
{
    [ApiController]
    [Route("api/patogeno")]
    public class PatogenoController
    {
        private readonly IRepositorioPatogeno _repositorioPatogeno;

        public PatogenoController(IRepositorioPatogeno repositorioPatogeno)
        {
            _repositorioPatogeno = repositorioPatogeno ?? throw new ArgumentNullException(nameof(repositorioPatogeno));
        }


        [HttpGet("obter/")]
        public async Task<IResult> ObterPatogeno([FromRoute] int id)
        {
            var patogeno = await _repositorioPatogeno.ObterPatogeno(id);

            return Results.Ok(patogeno);
        }

        [HttpGet("listar/")]
        public async Task<IEnumerable<Patogeno>> ObterPatogenos()
        {
            var patogenos = await _repositorioPatogeno.ObterPatogenos();

            return (IEnumerable<Patogeno>)Results.Ok(patogenos);

        }

    }
}