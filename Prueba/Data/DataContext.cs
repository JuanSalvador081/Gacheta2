using Microsoft.EntityFrameworkCore;
using Prueba.Entities;

namespace Prueba.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
           
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Lavanderia> Lavanderias { get; set; }
        public DbSet<Cuarto> Cuartos { get; set; }
        public DbSet<Historia_Cliente> Historia_Clientes { get; set; }




    }
}
