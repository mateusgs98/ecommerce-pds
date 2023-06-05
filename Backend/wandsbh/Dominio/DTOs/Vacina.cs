

namespace Dominio.DTOs
{
    public class Vacina
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Fabricante { get; set; }
        public int Patogeno { get; set; }
        public int Doses { get; set; }
        public int PeriodoEntreDoses { get; set; }
        public TipoImunizacao TipoImunizacao { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataAprovacao { get; set; }
        public decimal? EficaciaComprovada { get; set;}

    }
}
