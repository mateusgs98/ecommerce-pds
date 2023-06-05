using Microsoft.AspNetCore.Mvc;
using Dominio.DTOs;
using Dominio.Portas.Entrada;
using Api.Adaptadores.BD.Repositorios;

namespace Api.Adaptadores.Controllers
{
    [ApiController]
    [Route("api/Vacina")]
    public class VacinaController
    {
        private readonly IRepositorioVacina _repositorioVacina;

        public VacinaController(IRepositorioVacina repositorioVacina)
        {
            _repositorioVacina = repositorioVacina ?? throw new ArgumentNullException(nameof(repositorioVacina));
        }


        [HttpGet("obter/{id}")]
        public async Task<IResult> ObterVacina([FromRoute] int id)
        {
            var Vacina = await _repositorioVacina.ObterVacina(id);

            return Results.Ok(Vacina);
        }

        [HttpPost("cadastrar")]
        public async Task<IResult> CadastrarVacina([FromBody] Vacina Vacina)
        {
            var VacinaCadastrada = await _repositorioVacina.CadastrarVacina(Vacina);

            return Results.Ok(VacinaCadastrada);
        }

        [HttpGet("listar/")]
        public async Task<IEnumerable<Vacina>> ObterVacinas()
        {
            var vacinas = await _repositorioVacina.ObterVacinas();

            return (IEnumerable<Vacina>)Results.Ok(vacinas);

        }

    }
}
