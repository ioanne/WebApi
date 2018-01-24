using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;
using WebApi.Strategy;

namespace WebApi.Context
{
    public class MonedaContext
    {
        IMoneda _IMoneda;

        public MonedaContext(IMoneda IMoneda)
        {
            this._IMoneda = IMoneda;
        }

        public Moneda GetMoneda()
        {
            return _IMoneda.GetMoneda();
        }
    }
}