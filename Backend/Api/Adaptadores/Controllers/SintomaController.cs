using Dominio.Portas.Entrada;
using Microsoft.AspNetCore.Mvc;
using Api.Adaptadores.BD.Entidades;

namespace Api.Adaptadores.Controllers
{
    [ApiController]
    [Route("api/sintoma")]
    public class SintomaController
    {
        private readonly IRepositorioSintoma _repositorioSintoma;

        public SintomaController(IRepositorioSintoma repositorioSintoma)
        {
            _repositorioSintoma = repositorioSintoma ?? throw new ArgumentNullException(nameof(repositorioSintoma));
        }


        [HttpGet("obter/")]
        public async Task<IResult> ObterSintoma([FromRoute] int id)
        {
            var Sintoma = await _repositorioSintoma.ObterSintoma(id);

            return Results.Ok(Sintoma);
        }

      

    }
}
