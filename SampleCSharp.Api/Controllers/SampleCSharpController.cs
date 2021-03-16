using Microsoft.AspNetCore.Mvc;
using SampleCSharp.Api.Commands;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleCSharp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleCSharpController : ControllerBase
    {
        // GET: api/<SampleCSharpController>
        [HttpGet]
        public IEnumerable<object> Get()
        {
            return Repositorios.SampleCSharpRepositorio.Data;
        }

        // GET api/<SampleCSharpController>/5
        [HttpGet("{id}")]
        public object Get(int id)
        {
            return Repositorios.SampleCSharpRepositorio.Data.FirstOrDefault(o => o.Id == id);
        }

        // POST api/<SampleCSharpController>
        [HttpPost]
        public void Post([FromBody] SampleCommand command)
        {
            Repositorios.SampleCSharpRepositorio.Data.Add(command);
        }

        // PUT api/<SampleCSharpController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] SampleCommand command)
        {
            var item = Repositorios.SampleCSharpRepositorio.Data.FirstOrDefault(o => o.Id == command.Id);
            if (item != null)
            {
                item.Id = command.Id;
                item.Color = command.Color;
                item.Shape = command.Shape;
            }
        }

        // DELETE api/<SampleCSharpController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = Repositorios.SampleCSharpRepositorio.Data.FirstOrDefault(o => o.Id == id);
            Repositorios.SampleCSharpRepositorio.Data.Remove(item);
        }
    }
}
