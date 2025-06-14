using Agenda.WinForms.DTOs;
using Agenda.WinForms.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.WinForms.Forms
{
    public partial class FormEditarContacto : Form
    {
        private readonly ContactoDTO _contacto;
        private readonly ApiCliente _apiCliente;

        public event EventHandler ContactoActualizado;

        public FormEditarContacto(ContactoDTO contacto, ApiCliente apiCliente)
        {
            InitializeComponent();
            _contacto = contacto;
            _apiCliente = apiCliente;

            // Cargar datos en los TextBox
            txtNombre.Text = _contacto.Nombre;
            txtApellido.Text = _contacto.Apellido;
            txtTelefono.Text = _contacto.Telefono;
            txtEmail.Text = _contacto.Email;

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                _contacto.Nombre = txtNombre.Text;
                _contacto.Apellido = txtApellido.Text;
                _contacto.Telefono = txtTelefono.Text;
                _contacto.Email = txtEmail.Text;

                await _apiCliente.ActualizarContactoAsync(_contacto.Id, _contacto);
                ContactoActualizado?.Invoke(this, EventArgs.Empty);

                MessageBox.Show("Contacto actualizado con éxito.");
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar: {ex.Message}");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private bool ValidarCampos()
        {
            // Restaurar colores
            txtNombre.BackColor = SystemColors.Window;
            txtApellido.BackColor = SystemColors.Window;
            txtTelefono.BackColor = SystemColors.Window;
            txtEmail.BackColor = SystemColors.Window;


            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' no puede estar vacío.");
                txtNombre.BackColor = Color.MistyRose;
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtTelefono.Text) && !txtTelefono.Text.All(char.IsDigit))
            {
                MessageBox.Show("El teléfono debe contener solo números.");
                txtTelefono.BackColor = Color.MistyRose;
                return false;
            }



            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("El campo 'Email' no parece válido.");
                txtEmail.BackColor = Color.MistyRose;

                return false;
            }

            return true;
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
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

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
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
            if (txtEmail.Text == "Apellido")
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
