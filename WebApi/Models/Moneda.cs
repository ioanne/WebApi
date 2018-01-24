using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Moneda 
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PrecioVenta { get; set; }

        public string PrecioCompra { get; set; }

        public string FechaActualizacion { get; set; }
    }

}