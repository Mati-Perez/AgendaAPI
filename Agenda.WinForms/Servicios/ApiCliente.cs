using Agenda.WinForms.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.WinForms.Servicios
{
    public class ApiCliente
    {
        private readonly HttpClient _http;

        public ApiCliente()
        {
            _http = new HttpClient
            {
                // BaseAddress = new Uri("http://localhost:5000/api/")
                BaseAddress = new Uri("https://agendaapi-production.up.railway.app/api/")
            };
        }

        public async Task<List<ContactoDTO>> ObtenerContactosAsync()
        {
            try
            {
                var contactos = await _http.GetFromJsonAsync<List<ContactoDTO>>("contactos");
                return contactos ?? new List<ContactoDTO>();
            }
            catch (Exception ex)
            {
                return new List<ContactoDTO>();
            }

        }
        public async Task CrearContactoAsync(ContactoDTO nuevo)
        {
            await _http.PostAsJsonAsync("contactos", nuevo);
        }
        public async Task ActualizarContactoAsync(int id, ContactoDTO contacto)
        {
            var response = await _http.PutAsJsonAsync($"contactos/{id}", contacto);
            response.EnsureSuccessStatusCode();
        }
        public async Task EliminarContactoAsync(int id)
        {
            var response = await _http.DeleteAsync($"contactos/{id}");
            response.EnsureSuccessStatusCode();
        }
        public async Task<ContactoDTO> ObtenerContactoPorIdAsync(int id)
        {
            var response = await _http.GetAsync($"contactos/{id}");
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<ContactoDTO>();

            return null;
        }
        public async Task<List<ContactoDTO>> BuscarContactosAsync(string termino)
        {
            return await _http.GetFromJsonAsync<List<ContactoDTO>>($"contactos/buscar?termino={Uri.EscapeDataString(termino)}");
        }

    }
}
