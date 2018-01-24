using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class CotizacionController : ApiController
    {
        Moneda[] monedas = new Moneda[] {
        new Moneda { Id = 1, Name = "Dolar", PrecioVenta = 19.20, PrecioCompra = 18.98, FechaActualizacion = DateTime.Now },
        new Moneda { Id = 2, Name = "Pesos", PrecioVenta = 19.20, PrecioCompra = 18.98, FechaActualizacion = DateTime.Now },
        new Moneda { Id = 3, Name = "Real", PrecioVenta = 19.20, PrecioCompra = 18.98, FechaActualizacion = DateTime.Now } };

        // GET: api/Cotizacion
        public IEnumerable<Moneda> Get()
        {
            return monedas;
        }

        // GET: api/Cotizacion/5
        public IEnumerable<Moneda> Get(string id)
        {
            var SelectMoneda = from moneda in monedas
                           where moneda.Name == id
                           select moneda;

            if (SelectMoneda.FirstOrDefault().Name == "Pesos" || SelectMoneda.FirstOrDefault().Name == "Real")
            {
                throw new HttpException(401, "Auth Failed");
            }
            

            return SelectMoneda;
        }

        // POST: api/Cotizacion
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cotizacion/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cotizacion/5
        public void Delete(int id)
        {
        }
    }
}
