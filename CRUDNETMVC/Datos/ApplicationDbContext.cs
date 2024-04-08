using CRUDNETMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDNETMVC.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        //Agregar los modelos de los aquí (Cada modelo corresponde a una tabla en BD)
        public DbSet<Contacto> Contacto { get; set; }
        public DbSet<Producto> Producto { get; set; }
    }
}
