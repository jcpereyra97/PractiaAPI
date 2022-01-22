using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaBackend.Dominio;

namespace Backend.Acceso_a_Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Atencion> Atenciones { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
    }
}
