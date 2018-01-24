using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class UsuariosController : ApiController
    {
        private UsuarioContext db = new UsuarioContext();

        // GET: api/Usuario
        public IEnumerable<Usuarios> Get()
        {
             List<Usuarios> usuarios = db.Usuarios.ToList();
            return usuarios;

        }

        // GET: api/Usuario/5
        public IHttpActionResult Get(int id)
        {
            List<Usuarios> usuarios = db.Usuarios.ToList();

            var selected_user = (from user in usuarios
                                 where user.Id == id
                                 select user).FirstOrDefault();


            return CreatedAtRoute("Usuarios", new { id = selected_user.Id }, selected_user);

        }

        // POST: api/Usuario
        [ResponseType(typeof(Usuarios))]
        public IHttpActionResult Post(Usuarios usuario)
        {
            db.Usuarios.Add(usuario);
            db.SaveChanges();

            return CreatedAtRoute("Usuarios", new { id = usuario.Id }, usuario);
        }
    
        // PUT: api/Usuario/5
        [ResponseType(typeof(Usuarios))]
        public IHttpActionResult Put(int id, Usuarios usuario)
        {
            List<Usuarios> usuarios = db.Usuarios.ToList();

            var selected_user = (from user in usuarios
                                  where user.Id == id
                                  select user).FirstOrDefault();

            selected_user.Nombre = usuario.Nombre;
            selected_user.Apellido = usuario.Apellido;
            selected_user.Email = usuario.Email;

            db.SaveChanges();
            return CreatedAtRoute("Usuarios", new { id = usuario.Id }, usuario);
        }

        // DELETE: api/Usuario/5
        [ResponseType(typeof(Usuarios))]
        public IHttpActionResult Delete(int id, Usuarios usuario)
        {
            List<Usuarios> usuarios = db.Usuarios.ToList();

            var selected_user = (from user in usuarios
                                 where user.Id == id
            
                     select user).Single<Usuarios>();

            
            db.Usuarios.Remove(selected_user);
            db.SaveChanges();
            return CreatedAtRoute("Usuarios", new { id = usuario.Id }, usuario);

        }
    }
}
