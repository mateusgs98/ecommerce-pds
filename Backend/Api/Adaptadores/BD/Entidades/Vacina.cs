using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Adaptadores.BD.Entidades
{
    [Table("Vacinas", Schema = "dbo")]

    public class Vacina
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        
        [Required]
        public string Nome { get; set; }
        public int PatogenoId { get; set; }
        public int FabricanteId { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataAprovacao { get; set; }
        public int DosesImunizacao { get; set; }
        public int PeriodoEntreDoses { get; set; }
        public decimal EficaciaComprovada { get; set; }
    }
}

