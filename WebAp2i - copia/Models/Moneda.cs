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

        public double PrecioVenta { get; set; }

        public double PrecioCompra { get; set; }

        public DateTime FechaActualizacion { get; set; }
    }


}