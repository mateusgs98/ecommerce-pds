using Dominio.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Portas.Entrada
{
    public interface IRepositorioVacina
    {
        Task<Vacina> ObterVacina(int id);

        Task<Vacina> CadastrarVacina(Vacina vacina);

        Task<IEnumerable<Vacina>> ObterVacinas();
    }
}
