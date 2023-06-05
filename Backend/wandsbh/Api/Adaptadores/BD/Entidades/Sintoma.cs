using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Api.Adaptadores.BD.Entidades
{
    
       [Table("Sintoma", Schema = "dbo")]
        public class Sintoma
        {
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Key]
            public int Id { get; set; }
            
            [Required]
            public string Descricao { get; set; }
            
        }
   
}
