using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Adaptadores.BD.Entidades
{
    [Table("Atendimentos", Schema = "dbo")]
    public class Atendimento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Data { get; set; }
        public string LocalAtendimento { get; set; }
        public int CodigoLocalAtendimento { get; set; }
        public virtual ICollection<AtendimentoVacina> AtendimentoVacinas { get; set; }
    }
}