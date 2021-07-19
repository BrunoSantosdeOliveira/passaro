using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using passaro.models;

namespace passaro.Controllers
{
    [ApiController]

    public class ClientesController : ControllerBase
    {
        [Route("/clientes")]
        [HttpGet]
        public List<Cliente> Index()
        {    
            return Cliente.Lista();
        }

        [Route("/clientes/{id}")]
        [HttpGet]
        public Cliente Show(int id)
        {
            return Cliente.BuscaPorId(id);
        }






    }
}
