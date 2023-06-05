namespace Dominio.DTOs
{
    public class AtendimentoVacina
    {
        public int Id { get; set; }
        public int AtendimentoId { get; set; }
        public int VacinaId { get; set; }
        public string? NomeVacina { get; set; }
    }
}