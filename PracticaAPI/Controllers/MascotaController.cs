using Backend.Acceso_a_Datos.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinariaBackend.Dominio;
using VeterinariaBackend.Negocio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VeterinariaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MascotaController : ControllerBase
    {
        private readonly IServiceMascota service;

        public MascotaController(IServiceMascota service) 
        {
            this.service = service;
        }

        [HttpGet("GetIdMascota/{id}/{nombre}")]
        public ActionResult GetIdMascota(int id, string nombre)
        {
            var mascota = service.OptenerMascotaPorIdYNombre(id, nombre);
            if(mascota!= null)
            {
                return Ok(mascota);
            }
            else
            {
                return BadRequest("Mascota no encontrada");
            }


        }

        [HttpGet("ConsultarMascota/{id}")]
        public ActionResult GetMascota(int id)
        {
          
            var mascota = service.OptenerMascotaPorId(id);
            if (mascota != null)
            {
                return Ok(mascota);
            }
            else
            {
                return BadRequest("Mascota no encontrada");
            }

        }

        [HttpGet("ObtenerMascota/{id}")]
        public ActionResult ObtenerMascota(int id)
        {
            var mascota = service.OptenerMascotaPorId(id);
            if (mascota != null)
            {
                return Ok(mascota);
            }
            else
            {
                return BadRequest("Mascota no encontrada");
            }
        }




        [HttpPost("AgregarMascota")]
        public IActionResult PostMascota(Mascota oMascota)
        {
            try
            {
                service.AgregarMascota(oMascota);
                return Ok();

            }
            catch (Exception)
            {

                return BadRequest();
            }
               
           
        }


        // DELETE
        [HttpDelete("DeleteMascota/{id}")]
        public IActionResult DeleteMascota(int id)
        {
            try
            {
                var mascota = service.OptenerMascotaPorId(id);
                service.BorrarMascota(mascota);
                return Ok(mascota);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }


        // PUT api/<MascotaController>/5
        [HttpPut("UpdateMascota")]
        public IActionResult PutMascota(Mascota oMascota)
        {
            try
            {

                service.ActualizarMascota(oMascota);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

     
    }
}
