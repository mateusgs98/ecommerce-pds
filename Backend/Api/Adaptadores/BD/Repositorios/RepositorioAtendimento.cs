using System.Diagnostics;
using Dominio.Portas.Entrada;
using Api.Adaptadores.BD;
using Entidades = Api.Adaptadores.BD.Entidades;
using DTOs = Dominio.DTOs;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Api.Adaptadores.BD.Repositorios
{
    public class RepositorioAtendimento : IRepositorioAtendimento
    {
        private readonly ContextoBd _contextoBd;

        public RepositorioAtendimento(ContextoBd contextoBd)
        {
            _contextoBd = contextoBd ?? throw new ArgumentNullException(nameof(contextoBd));
        }

        public async Task<List<DTOs.Atendimento>> ObterAtendimentosUsuario(int idUsuario)
        {
            return await _contextoBd.Atendimentos.Where(a => a.UsuarioId == idUsuario).Select(a => new DTOs.Atendimento
            {
                CodigoLocalAtendimento = a.CodigoLocalAtendimento,
                Data = a.Data,
                Id = a.Id,
                LocalAtendimento = a.LocalAtendimento,
                UsuarioId = a.UsuarioId,
                Vacinas = a.AtendimentoVacinas.Select(av => new DTOs.AtendimentoVacina
                {
                    AtendimentoId = av.AtendimentoId,
                    Id = av.Id,
                    VacinaId = av.VacinaId,
                    NomeVacina = av.Vacina.Nome
                }).ToList()
            }).ToListAsync();
        }

        public async Task<DTOs.Atendimento> CadastrarAtendimento(DTOs.Atendimento atendimento)
        {
            var entidadeAtendimento = new Entidades.Atendimento
            {
                CodigoLocalAtendimento = atendimento.CodigoLocalAtendimento,
                Data = atendimento.Data,
                LocalAtendimento = atendimento.LocalAtendimento,
                UsuarioId = atendimento.UsuarioId,
                AtendimentoVacinas = atendimento.Vacinas.Select(a => new Entidades.AtendimentoVacina
                {
                    VacinaId = a.VacinaId
                }).ToList()
            };

            _contextoBd.Atendimentos.AddAsync(entidadeAtendimento);
            await _contextoBd.SaveChangesAsync();

            atendimento.Id = entidadeAtendimento.Id;

            return atendimento;
        }
    }
}