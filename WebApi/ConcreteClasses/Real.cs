using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;
using WebApi.Strategy;

namespace WebApi.ConcreteClasses
{
    public class Real : IMoneda
    {
        public Moneda GetMoneda()
        {
            throw new HttpException(401, "Auth Failed");
        }
    }
}