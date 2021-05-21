using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;
using ProEventos.API.Data;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly DataContext _context;
        public EventsController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _context.EventTable;
        }
        [HttpGet("{id}")]
        public Event GetById(int id)
        {
            return _context.EventTable.FirstOrDefault(e => e.EventId == id);
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
