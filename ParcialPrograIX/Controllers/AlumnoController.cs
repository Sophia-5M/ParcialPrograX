using Microsoft.AspNetCore.Mvc;
using ParcialPrograIX.Models;
using ParcialPrograIX.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ParcialPrograIX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {

        // GET api/<AlumnoController>/5

        [HttpGet("{id}")]
        public ActionResult<Alumno> Get(int id)
        {
            var alumnoService = new AlumnoServices();
            {
                var alumno = alumnoService.GetClientById(id);
                if (alumno != null)
                {
                    return Ok(alumno);
                }
                return NotFound("Mensaje: There are not client with id: " + id);
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Alumno>> Get()
        {
            var alumnoService = new AlumnoServices();
            {
                var alumno = alumnoService.GetClient();
                if (alumno != null)
                {
                    return Ok(alumno);
                }
                return NotFound("Mensaje: There are not clients");
            }
        }

        // POST api/<AlumnoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AlumnoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlumnoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
