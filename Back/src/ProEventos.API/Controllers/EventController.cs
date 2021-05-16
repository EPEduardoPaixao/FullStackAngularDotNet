using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        public EventController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return(
                 "Teste Get"
            );
        }
        [HttpPost]
        public string Post()
        {
            return(
                 "Teste Post"
            );
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return(
                 $"Teste Put id={id}"
            );
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return(
                 $"Teste Delete id={id}"
            );
        }
    }
}
