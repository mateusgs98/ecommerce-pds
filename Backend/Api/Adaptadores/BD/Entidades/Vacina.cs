using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Api.Adaptadores.BD.Entidades
{
    [Table("Doenca", Schema = "dbo")]
    public class Vacina
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string? Nome { get; set; }
        public Doenca DoencaEvitada { get; set; }
        public string? Fabricante { get; set; }
        public int Doses { get; set; }
        public int PeriodoEntreDoses { get; set; }
        public TipoImunizacao TipoImunizacao { get; set; }

        
    }
}
