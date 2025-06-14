using AgendaAPI.Models;
using AgendaAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgendaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactosController : ControllerBase
    {
        private readonly IContactoService _servicio;
        public ContactosController(IContactoService servicio)
        {
            _servicio = servicio;
        }

       
        [HttpGet("{id:int}")]
        public ActionResult<Contacto> Get(int id)
        {
            var contacto = _servicio.ObtenerPorId(id);
            if (contacto == null)
            {
                return NotFound();
            }
            return Ok(contacto);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Contacto>> Get([FromQuery] string? nombre, [FromQuery] string? email)
        {
            var contactos = _servicio.ObtenerTodos();

            if (!string.IsNullOrWhiteSpace(nombre))
                contactos = contactos.Where(c => c.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!string.IsNullOrWhiteSpace(email))
                contactos = contactos.Where(c => c.Email.Contains(email, StringComparison.OrdinalIgnoreCase)).ToList();

            return Ok(contactos);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Contacto nuevo)
        {
            try
            {
                _servicio.Crear(nuevo);
                return CreatedAtAction(nameof(Get), new { id = nuevo.Id }, nuevo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ocurrió un error: {ex.Message}");
            }

        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Contacto actualizado)
        {
            _servicio.Actualizar(id, actualizado);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _servicio.Eliminar(id);
            return NoContent();
        }

    }
}
