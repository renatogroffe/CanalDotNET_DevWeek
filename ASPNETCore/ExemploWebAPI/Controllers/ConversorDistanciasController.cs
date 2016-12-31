using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExemploWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ConversorDistanciasController : Controller
    {
        [HttpGet("MilhasKm/{distanciaMilhas}")]
        public object Get(double distanciaMilhas)
        {
            return new
            {
                ValorMilhas = distanciaMilhas,
                ValorKm = distanciaMilhas * 1.609
            };
        }
    }
}