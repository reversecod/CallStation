using CallStation.Models;
using Microsoft.EntityFrameworkCore;

namespace CallStation.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {

        }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Chamados> Chamados { get; set; }
        public DbSet<ToDo> ToDo { get; set; } 

    }
}
