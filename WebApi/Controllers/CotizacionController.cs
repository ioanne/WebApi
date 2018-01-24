using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApi.Context;
using WebApi.ConcreteClasses;
using WebApi.Models;

namespace WebApi.Controllers
{
    public partial class CotizacionController : ApiController
    {
        //datos de prueba
        Moneda[] monedas = new Moneda[] {
        new Moneda { Id = 1, Name = "Dolar", PrecioVenta = "19.20", PrecioCompra = "18.98", FechaActualizacion = DateTime.Now.ToString() },
        new Moneda { Id = 2, Name = "Pesos", PrecioVenta = "19.20", PrecioCompra = "18.98", FechaActualizacion = DateTime.Now.ToString() },
        new Moneda { Id = 3, Name = "Real", PrecioVenta = "19.20", PrecioCompra = "18.98", FechaActualizacion = DateTime.Now.ToString() } };


        // GET: api/Cotizacion
        public IEnumerable<Moneda> Get()
        {
            return monedas;
        }

        // GET: api/Cotizacion/5
        public Moneda Get(string id)
        {
            MonedaContext monedaContext;
            Moneda moneda;
            switch (id.ToLower())
            {
                case "dolar":
                    monedaContext = new MonedaContext(new Dolar());
                    moneda = monedaContext.GetMoneda();
                    break;
                case "real":
                    monedaContext = new MonedaContext(new Real());
                    moneda = monedaContext.GetMoneda();
                    break;
                case "pesos":
                    monedaContext = new MonedaContext(new Pesos());
                    moneda = monedaContext.GetMoneda();
                    break;

                default:
                    throw new HttpException(401, "Auth Failed");
            }          

            return moneda;
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
