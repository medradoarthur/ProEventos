using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proEventos.api.models;

namespace proEventos.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento()
            {
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Ribeirão Preto",
                Lote = "1° Lote",
                QtdPessoas = 255,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/YYYY"),
                ImagemURL = "foto.png"
            },
            new Evento()
            {
                EventoId = 2,
                Tema = "Angular muito louco",
                Local = "Poção",
                Lote = "2° Lote",
                QtdPessoas = 300,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/YYYY"),
                ImagemURL = "foto2.png"
            }
        };

        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }
        
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }


        [HttpPost]
        public string Post()
        {
            return "Exemplo post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo delete com id = {id}";
        }


    }
}
