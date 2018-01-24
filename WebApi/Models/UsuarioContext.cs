using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WebApi.Models
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext() : base("name=UsuarioContext")
        {
        }
        public System.Data.Entity.DbSet<WebApi.Models.Usuarios> Usuarios { get; set; }

    }
}
