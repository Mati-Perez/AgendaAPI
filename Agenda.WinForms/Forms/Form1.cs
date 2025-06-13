using Agenda.WinForms.DTOs;
using Agenda.WinForms.Forms;
using Agenda.WinForms.Servicios;

namespace Agenda.WinForms
{
    public partial class Form1 : Form
    {
        private ApiCliente _apiCliente = new ApiCliente();
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                var contactos = await _apiCliente.ObtenerContactosAsync();
                dgvContactos.DataSource = null;
                dgvContactos.DataSource = contactos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar contactos: {ex.Message}");
            }
            if (dgvContactos.Columns["Id"] != null)
                dgvContactos.Columns["Id"].Visible = false;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarNuevoContacto())
                return;

            try
            {
                var nuevoContacto = new ContactoDTO
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text
                };

                if (nuevoContacto.Apellido == "Apellido")
                    nuevoContacto.Apellido = string.Empty;

                if (nuevoContacto.Email == "Email")
                    nuevoContacto.Email = string.Empty;

                await _apiCliente.CrearContactoAsync(nuevoContacto);
                MessageBox.Show("¡Contacto agregado con éxito!");

                await CargarContactosAsync(); // recarga el grid
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar contacto: {ex.Message}");
            }

        }

        private async Task CargarContactosAsync()
        {
            var contactos = await _apiCliente.ObtenerContactosAsync();
            dgvContactos.DataSource = null;
            dgvContactos.DataSource = contactos;

            if (dgvContactos.Columns["Id"] != null)
                dgvContactos.Columns["Id"].Visible = false;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un contacto primero.");
                return;
            }

            var fila = dgvContactos.CurrentRow.DataBoundItem as ContactoDTO;

            if (fila == null)
            {
                MessageBox.Show("No se pudo obtener el contacto seleccionado.");
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Estás seguro que querés eliminar a {fila.Nombre} {fila.Apellido}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion != DialogResult.Yes)
                return;

            try
            {
                await _apiCliente.EliminarContactoAsync(fila.Id);
                MessageBox.Show("Contacto eliminado exitosamente.");
                await CargarContactosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}");
            }

        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un contacto.");
                return;
            }

            var contacto = dgvContactos.CurrentRow.DataBoundItem as ContactoDTO;
            if (contacto is null)
            {
                MessageBox.Show("No se pudo leer el contacto.");
                return;
            }

            var formEditar = new FormEditarContacto(contacto, _apiCliente);
            var resultado = formEditar.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                await CargarContactosAsync();
            }

        }

        private bool ValidarNuevoContacto()
        {
            // Limpiar colores previos
            txtNombre.BackColor = SystemColors.Window;
            txtApellido.BackColor = SystemColors.Window;
            txtTelefono.BackColor = SystemColors.Window;
            txtEmail.BackColor = SystemColors.Window;
            lblValidarNombre.Visible = false;
            lblValidarNumero.Visible = false;
            lblValidarEmail.Visible = false;

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || txtNombre.Text == "Nombre")
            {
                txtNombre.BackColor = Color.MistyRose;
                lblValidarNombre.Text = "El nombre es obligatorio.";
                lblValidarNombre.Visible = true;
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !txtEmail.Text.Contains("@"))
            {
                txtEmail.BackColor = Color.MistyRose;
                lblValidarEmail.Text = "El email no parece válido.";
                lblValidarEmail.Visible = true;
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtTelefono.Text) && !txtTelefono.Text.All(char.IsDigit) || txtTelefono.Text == "Telefono")
            {
                txtTelefono.BackColor = Color.MistyRose;
                lblValidarNumero.Text = "El teléfono debe contener solo números.";
                lblValidarNumero.Visible = true;
                return false;
            }

            return true;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Gray;
            }

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await CargarContactosAsync();

        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
                txtApellido.ForeColor = Color.Gray;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Telefono";
                txtTelefono.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Gray;
            }
        }
    }
}
