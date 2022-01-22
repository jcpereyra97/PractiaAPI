using Backend.Acceso_a_Datos;
using Backend.Acceso_a_Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaBackend.Dominio;

namespace Backend.Dominio
{
    public class ServiceMascota : IServiceMascota
    {
        private readonly IGenericRepository _repository;
        private readonly ApplicationDbContext context;

        public ServiceMascota(IGenericRepository repository, ApplicationDbContext context)
        {
            _repository = repository;
            this.context = context;
        }

        public void ActualizarMascota(Mascota mascota)
        {
            _repository.Update(mascota);
        }

        public void AgregarMascota(Mascota mascota)
        {
            _repository.Add(mascota);
        }

        public void BorrarMascota(Mascota mascota)
        {
            _repository.Delete(mascota);
        }

        public Mascota OptenerMascotaPorId(int id)
        {
            return (from x in context.Mascotas where x.id == id select x).FirstOrDefault<Mascota>();
             
        }

        public Mascota OptenerMascotaPorIdYNombre(int id, string nombre)
        {
            return (from x in context.Mascotas where x.id == id & x.Nombre == nombre select x).FirstOrDefault<Mascota>();
        }
    }
}
