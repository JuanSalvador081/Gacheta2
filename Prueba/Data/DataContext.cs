using Microsoft.EntityFrameworkCore;
using Prueba.Entities;

namespace Prueba.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
           
        }
        public DbSet<Cuarto> Cuartos { get; set; }
        public DbSet<Lavanderia> lavanderias { get; set; }

    }
}
