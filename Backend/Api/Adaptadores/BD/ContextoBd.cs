using Microsoft.EntityFrameworkCore;
using Api.Adaptadores.BD.Entidades;

namespace Api.Adaptadores.BD
{
    public class ContextoBd : DbContext
    {
        public ContextoBd(DbContextOptions<ContextoBd> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}