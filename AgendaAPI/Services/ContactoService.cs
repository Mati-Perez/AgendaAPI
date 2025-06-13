using AgendaAPI.Data;
using AgendaAPI.Models;

namespace AgendaAPI.Services
{
    public class ContactoService : IContactoService
    {
        //delegados
        public delegate void ContactoCreadoHandler(Contacto nuevo);
        public delegate void ContactoEliminadoHandler(int id);
        public delegate void ContactoActualizadoHandler(Contacto actualizado);

        //eventos
        public event ContactoCreadoHandler ContactoCreado;
        public event ContactoEliminadoHandler ContactoEliminado;
        public event ContactoActualizadoHandler ContactoActualizado;


        private readonly AgendaDbContext _context;
        public ContactoService(AgendaDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Contacto> ObtenerTodos()
        {
            return _context.Contactos.ToList();
        }
        public Contacto ObtenerPorId(int id)
        {
            return _context.Contactos.Find(id);
        }
        public void Crear(Contacto nuevo)
        {
            _context.Contactos.Add(nuevo);
            _context.SaveChanges();
            ContactoCreado?.Invoke(nuevo);
        }
        public void Actualizar(int id, Contacto actualizado)
        {
            var contacto = _context.Contactos.Find(id);
            if (contacto is null) return;

            contacto.Nombre = actualizado.Nombre;
            contacto.Apellido = actualizado.Apellido;
            contacto.Telefono = actualizado.Telefono;
            contacto.Email = actualizado.Email;
            
            _context.SaveChanges();
            ContactoActualizado?.Invoke(contacto);
        }
        public void Eliminar(int id)
        {
            var contacto = _context.Contactos.Find(id);
            if (contacto != null)
            {
                _context.Contactos.Remove(contacto);
                _context.SaveChanges();
                ContactoEliminado?.Invoke(id);
            }
        }
        
    }
}
