using Dominio.Portas.Entrada;
using DTOs = Dominio.DTOs;

namespace Api.Adaptadores.BD.Repositorios
{
    public class RepositorioDoenca : IRepositorioDoenca
    {
        private readonly ContextoBd _contextoBd;
        public RepositorioDoenca(ContextoBd contextoBd)
        {
            _contextoBd = contextoBd ?? throw new ArgumentNullException(nameof(contextoBd));
        }

        public async Task<DTOs.Doenca> ObterDoenca(int id)
        {
            var doenca = await _contextoBd.Doencas.FindAsync(id);

            return new DTOs.Doenca
            {
                Id = doenca.Id,
                Nome = doenca.Nome,
                Descricao = doenca.Descricao,
                DataIdentificacao = doenca.DataIdentificacao,
                Patogeno = doenca.Patogeno        

            };
        }

        public async Task<DTOs.Doenca> CadastrarDoenca(DTOs.Doenca doenca)
        {
            var entidadeDoenca = new Entidades.Doenca
            {
                Descricao = doenca.Descricao,
                Nome = doenca.Nome,
                DataIdentificacao = doenca.DataIdentificacao,
                Patogeno = doenca.Patogeno
            };

            await _contextoBd.Doencas.AddAsync(entidadeDoenca);
            await _contextoBd.SaveChangesAsync();

            doenca.Id = entidadeDoenca.Id;

            return doenca;
        }

    }
}
