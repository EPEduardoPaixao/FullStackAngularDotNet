using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        public IEnumerable<Event> _event =  new Event[]{

            new Event(){
                EventId = 1,
                Theme = "Angular 11 e .Net 5",
                Local = "Fortaleza",
                Batch = "1° Lote",
                QtdPeople = 250,
                DateEvent = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImageUrl = "foto.png",
            },
            new Event(){
                EventId = 2,
                Theme = "Angular 11 e .Net 5",
                Local = "Canada",
                Batch = "1° Lote",
                QtdPeople = 250,
                DateEvent = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImageUrl = "foto1.png",
            }
        };

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _event;
        }
        [HttpGet("{id}")]
        public IEnumerable<Event> GetById(int id)
        {
            return _event.Where(e => e.EventId == id);
        }
        [HttpPost]
        public string Post()
        {
            return (
                 "Teste Post"
            );
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return (
                 $"Teste Put id={id}"
            );
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return (
                 $"Teste Delete id={id}"
            );
        }
    }
}
