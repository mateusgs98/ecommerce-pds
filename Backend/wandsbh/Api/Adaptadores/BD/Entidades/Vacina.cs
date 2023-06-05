using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


       namespace Api.Adaptadores.BD.Entidades
    {
        [Table("Vacinas", Schema = "dbo")]
        public class Vacina
        {
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Key]
            public int Id { get; set; }
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




