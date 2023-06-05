using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Adaptadores.BD.Entidades
{
    [Table("Atendimento_Vacinas", Schema = "dbo")]
    public class AtendimentoVacina
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int AtendimentoId { get; set; }
        public int VacinaId { get; set; }

        [ForeignKey("AtendimentoId")]
        public Atendimento Atendimento { get; set; }

        [ForeignKey("VacinaId")]
        public Vacina Vacina { get; set; }
    }
}