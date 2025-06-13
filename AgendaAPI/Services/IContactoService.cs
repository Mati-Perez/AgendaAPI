using AgendaAPI.Models;

namespace AgendaAPI.Services
{
    public interface IContactoService
    {
        IEnumerable<Contacto> ObtenerTodos();
        Contacto ObtenerPorId(int id);
        void Crear(Contacto nuevo);
        void Actualizar(int id, Contacto actualizado);
        void Eliminar(int id);
    }
}
