using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaBackend.Dominio;

namespace Backend.Acceso_a_Datos.Interfaces
{
    public interface IServiceMascota
    {
        public Mascota OptenerMascotaPorIdYNombre(int id, string nombre);
        public Mascota OptenerMascotaPorId(int id);

        public void AgregarMascota(Mascota mascota);
        public void BorrarMascota(Mascota mascota);
        public void ActualizarMascota(Mascota mascota);

    }
}
