namespace Dominio.DTOs
{
    public class Doenca
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public DateTime? DataIdentificacao { get; set; }
        public string? Descricao { get; set; }
        public string? Patogeno { get; set; }
        public IList<Sintoma>? Sintomas { get; protected set; }
        
    }
}
