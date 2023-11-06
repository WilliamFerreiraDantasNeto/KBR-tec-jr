using KRB_tec_jr.Models;
using Microsoft.EntityFrameworkCore;

namespace KRB_tec_jr.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<CampeonatosModel> Campeonatos { get; set; }
    }
}
