using Microsoft.EntityFrameworkCore;
using API_MVC_Achados_e_Enchentes.Models;

namespace API_MVC_Achados_e_Enchentes.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Pessoa> Pessoa { get; set; }

        public DbSet<Observacoes> Observacoes { get; set; }
    }
}
