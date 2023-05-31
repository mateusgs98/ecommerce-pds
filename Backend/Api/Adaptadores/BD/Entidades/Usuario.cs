using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Adaptadores.BD.Entidades
{
    [Table("Usuario", Schema = "dbo")]
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Paciente { get; set; }
        public DateTime? DataNascimento { get; set; }
    }
}