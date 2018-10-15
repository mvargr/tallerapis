using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TallerAPI.API.Models;

namespace TallerAPI.API.Controllers
{
    public class PublicacionController : ApiController
    {
        [HttpGet]
        public IEnumerable<Publicaciones> Get()
        {
            using (var context = new PublicacionContext())
            {
                return context.Publicacion.ToList();

            }
        }

        [HttpGet]
        public Publicaciones Get(int id)
        {
            using (var context = new PublicacionContext())
            {
                return context.Publicacion.FirstOrDefault(x => x.Id == id);
            }
        }

        [HttpPost]
        public IHttpActionResult Post(Publicaciones publicaciones)
        {

            using (var context = new PublicacionContext())
            {
                context.Publicacion.Add(publicaciones);
                context.SaveChanges();
                return Ok(publicaciones);
            }
        }

        [HttpPut]
        public Publicaciones Put(Publicaciones publicaciones)
        {
            using (var context = new PublicacionContext())
            {
                var publicacionActualizar = context.Publicacion.FirstOrDefault(x => x.Id == publicaciones.Id);
                publicacionActualizar.Usuario = publicaciones.Usuario;
                publicacionActualizar.Descripcion = publicaciones.Descripcion;
                publicacionActualizar.Fechapublicacion = publicaciones.Fechapublicacion;
                publicacionActualizar.Megusta = publicaciones.Megusta;
                publicacionActualizar.Medisgusta = publicaciones.Medisgusta;
                publicacionActualizar.Vecescompartido = publicaciones.Vecescompartido;
                publicacionActualizar.Esprivada = publicaciones.Esprivada;
                context.SaveChanges();
                return publicaciones;
            }
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            using (var context = new PublicacionContext())
            {
                var publicacionEliminar = context.Publicacion.FirstOrDefault(x => x.Id == id);
                context.Publicacion.Remove(publicacionEliminar);
                context.SaveChanges();
                return true;
            }
        }






    }
}
