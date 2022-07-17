using Microsoft.EntityFrameworkCore;
using ProjetoCarbono.Models;

namespace ProjetoCarbono.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<AspectosModel> Aspectos { get; set; }
    }
}
