namespace Agenda.WinForms.Forms
{
    partial class FormEditarContacto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = Color.Gray;
            txtNombre.Location = new Point(191, 103);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(166, 23);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "Nombre";
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // txtApellido
            // 
            txtApellido.ForeColor = Color.Gray;
            txtApellido.Location = new Point(191, 144);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(166, 23);
            txtApellido.TabIndex = 1;
            txtApellido.Text = "Apellido";
            txtApellido.Enter += txtApellido_Enter;
            txtApellido.Leave += txtApellido_Leave;
            // 
            // txtTelefono
            // 
            txtTelefono.ForeColor = Color.Gray;
            txtTelefono.Location = new Point(191, 189);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(166, 23);
            txtTelefono.TabIndex = 2;
            txtTelefono.Text = "Telefono";
            txtTelefono.Enter += txtTelefono_Enter;
            txtTelefono.Leave += txtTelefono_Leave;
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(191, 235);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(166, 23);
            txtEmail.TabIndex = 3;
            txtEmail.Text = "Email";
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(203, 69);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 4;
            label1.Text = "EDITAR CONTACTO";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(191, 297);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(83, 36);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(280, 297);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(83, 36);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormEditarContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(571, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "FormEditarContacto";
            Text = "FormEditarContacto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Label label1;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}