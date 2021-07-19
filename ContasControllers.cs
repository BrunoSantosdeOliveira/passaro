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

    public class ContasController : ControllerBase
    {
       
        [Route("/contas")]
        [HttpGet]
        public List<Conta> Index()
        {    
            return Conta.Lista();
        }

        [Route("/contas/{id}")]
        [HttpGet]
        public Conta Show(int id)
        {
            return Conta.BuscaPorId(id);
        }




    }
}
