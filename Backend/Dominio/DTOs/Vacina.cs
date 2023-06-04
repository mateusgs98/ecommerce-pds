

namespace Dominio.DTOs
{
    public class Vacina
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public Doenca DoencaEvitada { get; set; }
        public string? Fabricante { get; set; }
        public int Doses { get; set; }
        public int PeriodoEntreDoses { get; set; }
        public TipoImunizacao TipoImunizacao { get; set; }

    }
}
