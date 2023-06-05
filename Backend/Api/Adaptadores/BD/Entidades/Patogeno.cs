using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Api.Adaptadores.BD.Entidades
{
   
        [Table("Patogenos", Schema = "dbo")]
        public class Patogeno
        {
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Key]
            public int Id { get; set; }

            [Required]
            public string Nome { get; set; }

        }
    
}
