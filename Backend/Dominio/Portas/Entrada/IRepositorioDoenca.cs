using Dominio.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Portas.Entrada
{
    public interface IRepositorioDoenca
    {
        Task<Doenca> ObterDoenca(int id);

        Task<Doenca> CadastrarDoenca(Doenca doenca);

        Task<IEnumerable<Vacina>> ObterVacinas();
    }
}
