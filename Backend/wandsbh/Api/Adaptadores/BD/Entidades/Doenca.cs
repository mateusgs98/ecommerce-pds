using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Adaptadores.BD.Entidades
{
    [Table("Doenca", Schema = "dbo")]
    public class Doenca
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public  DateTime? DataIdentificacao { get; set; }
        public  string? Descricao { get; set; }
        public  int PatogenoId { get; set; }
    }

}
