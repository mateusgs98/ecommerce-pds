namespace Dominio.DTOs
{
    public class Atendimento
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Data { get; set; }
        public string LocalAtendimento { get; set; }
        public int CodigoLocalAtendimento { get; set; }
        public List<AtendimentoVacina> Vacinas { get; set; }
    }
}