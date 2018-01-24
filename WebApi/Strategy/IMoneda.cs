using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.Strategy
{
    public interface IMoneda
    {
        Moneda GetMoneda();
    }
}