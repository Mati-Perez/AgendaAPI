namespace Agenda.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvContactos = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnBorrar = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            lblContactos = new Label();
            label2 = new Label();
            lblValidarNombre = new Label();
            lblValidarEmail = new Label();
            lblValidarNumero = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).BeginInit();
            SuspendLayout();
            // 
            // dgvContactos
            // 
            dgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactos.Location = new Point(28, 104);
            dgvContactos.Name = "dgvContactos";
            dgvContactos.Size = new Size(399, 187);
            dgvContactos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ActiveCaption;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(556, 312);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 30);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ActiveCaption;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(46, 317);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 38);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = SystemColors.ActiveCaption;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBorrar.ForeColor = Color.White;
            btnBorrar.Location = new Point(153, 317);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 37);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = Color.Gray;
            txtNombre.Location = new Point(515, 104);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(173, 23);
            txtNombre.TabIndex = 5;
            txtNombre.Text = "Nombre";
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // txtApellido
            // 
            txtApellido.ForeColor = Color.Gray;
            txtApellido.Location = new Point(515, 158);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(173, 23);
            txtApellido.TabIndex = 6;
            txtApellido.Text = "Apellido";
            txtApellido.Enter += txtApellido_Enter;
            txtApellido.Leave += txtApellido_Leave;
            // 
            // txtTelefono
            // 
            txtTelefono.ForeColor = Color.Gray;
            txtTelefono.Location = new Point(515, 208);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(173, 23);
            txtTelefono.TabIndex = 7;
            txtTelefono.Text = "Telefono";
            txtTelefono.Enter += txtTelefono_Enter;
            txtTelefono.Leave += txtTelefono_Leave;
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(515, 261);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(173, 23);
            txtEmail.TabIndex = 8;
            txtEmail.Text = "Email";
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(297, 24);
            label1.Name = "label1";
            label1.Size = new Size(235, 28);
            label1.TabIndex = 9;
            label1.Text = "AGENDA DE CONTACTOS";
            // 
            // lblContactos
            // 
            lblContactos.AutoSize = true;
            lblContactos.Font = new Font("Segoe UI", 10F);
            lblContactos.ForeColor = Color.White;
            lblContactos.Location = new Point(28, 77);
            lblContactos.Name = "lblContactos";
            lblContactos.Size = new Size(71, 19);
            lblContactos.TabIndex = 10;
            lblContactos.Text = "Contactos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(547, 77);
            label2.Name = "label2";
            label2.Size = new Size(109, 19);
            label2.TabIndex = 11;
            label2.Text = "Nuevo Contacto";
            // 
            // lblValidarNombre
            // 
            lblValidarNombre.AutoSize = true;
            lblValidarNombre.ForeColor = Color.Red;
            lblValidarNombre.Location = new Point(515, 130);
            lblValidarNombre.Name = "lblValidarNombre";
            lblValidarNombre.Size = new Size(0, 15);
            lblValidarNombre.TabIndex = 12;
            lblValidarNombre.Visible = false;
            // 
            // lblValidarEmail
            // 
            lblValidarEmail.AutoSize = true;
            lblValidarEmail.ForeColor = Color.Red;
            lblValidarEmail.Location = new Point(515, 296);
            lblValidarEmail.Name = "lblValidarEmail";
            lblValidarEmail.Size = new Size(0, 15);
            lblValidarEmail.TabIndex = 15;
            lblValidarEmail.Visible = false;
            // 
            // lblValidarNumero
            // 
            lblValidarNumero.AutoSize = true;
            lblValidarNumero.ForeColor = Color.Red;
            lblValidarNumero.Location = new Point(516, 237);
            lblValidarNumero.Name = "lblValidarNumero";
            lblValidarNumero.Size = new Size(0, 15);
            lblValidarNumero.TabIndex = 16;
            lblValidarNumero.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(466, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 359);
            panel1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(lblValidarNumero);
            Controls.Add(lblValidarEmail);
            Controls.Add(lblValidarNombre);
            Controls.Add(label2);
            Controls.Add(lblContactos);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnBorrar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvContactos);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContactos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvContactos;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnBorrar;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Label label1;
        private Label lblContactos;
        private Label label2;
        private Label lblValidarNombre;
        private Label label4;
        private Label label5;
        private Label lblValidarEmail;
        private Label lblValidarNumero;
        private Panel panel1;
    }
}
