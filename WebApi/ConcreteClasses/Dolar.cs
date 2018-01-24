using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using WebApi.Models;
using WebApi.Strategy;

namespace WebApi.ConcreteClasses
{
    public class Dolar : IMoneda
    {
        public Moneda GetMoneda()
        {
            Moneda Dolar = new Moneda();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://www.bancoprovincia.com.ar");
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("Principal/Dolar").Result;
            if (response.IsSuccessStatusCode)
            {
                // var Monedas = response.Content.ReadAsAsync<IEnumerable<Moneda>>().Result;
                var monedasTxT = response.Content.ReadAsStringAsync().Result;
                List<string> list = new List<string>();
                list = JsonConvert.DeserializeObject<List<string>>(monedasTxT);

                Dolar.Name = "Dolar";
                Dolar.PrecioCompra = list[0];
                Dolar.PrecioVenta = list[1];
                Dolar.FechaActualizacion = list[2];
                //foreach (var Moneda_Original in Monedas)
                //{
                //    Dolar = Moneda_Original;
                //}
            }
            else
            {
                //Something has gone wrong, handle it here
            }

            //Moneda Moneda = new Moneda();

            //Moneda.Id = 1;
            //Moneda.Name = "Dolar";
            //Moneda.PrecioCompra = 19.20;
            //Moneda.PrecioVenta = 19.8;
            //Moneda.FechaActualizacion = DateTime.Now;

            return Dolar;
        }
    }
}