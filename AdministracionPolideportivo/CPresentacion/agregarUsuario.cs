using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class agregarUsuario : FormularioEstandar
    {
        public agregarUsuario()
        {

            InitializeComponent();

        }

        private LabelFormulario lblDNI;
        private LabelFormulario lblNombre;
        public Texto txtNombre;
        private LabelFormulario lblApellido;
        public Texto txtApellido;
        private LabelFormulario lblTelefono;
        public TextoNumerico txtTelefono;
        private BotonFormulario btnAgregarCliente;
        public ComboBoxEstandar cbTipo;
        private LabelFormulario labelFormulario1;
        private PictureBox pictureBox1;
        public ComboBoxEstandar cbSexo;
        private LabelFormulario labelFormulario2;
        public TextoNumerico txtDNI;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarUsuario));
            lblDNI = new LabelFormulario();
            txtDNI = new TextoNumerico();
            lblNombre = new LabelFormulario();
            txtNombre = new Texto();
            lblApellido = new LabelFormulario();
            txtApellido = new Texto();
            lblTelefono = new LabelFormulario();
            txtTelefono = new TextoNumerico();
            btnAgregarCliente = new BotonFormulario();
            cbTipo = new ComboBoxEstandar();
            labelFormulario1 = new LabelFormulario();
            pictureBox1 = new PictureBox();
            cbSexo = new ComboBoxEstandar();
            labelFormulario2 = new LabelFormulario();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 18F);
            lblDNI.ForeColor = Color.White;
            lblDNI.Location = new Point(22, 32);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(70, 32);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "D.N.I.";
            // 
            // txtDNI
            // 
            txtDNI.BackColor = SystemColors.WindowFrame;
            txtDNI.ForeColor = Color.White;
            txtDNI.Location = new Point(146, 41);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(117, 23);
            txtDNI.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 18F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(22, 80);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(102, 32);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.WindowFrame;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(146, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 23);
            txtNombre.TabIndex = 0;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 18F);
            lblApellido.ForeColor = Color.White;
            lblApellido.Location = new Point(22, 135);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(102, 32);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = SystemColors.WindowFrame;
            txtApellido.ForeColor = Color.White;
            txtApellido.Location = new Point(146, 144);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(210, 23);
            txtApellido.TabIndex = 0;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 18F);
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(17, 241);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(107, 32);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.WindowFrame;
            txtTelefono.ForeColor = Color.White;
            txtTelefono.Location = new Point(146, 250);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(151, 23);
            txtTelefono.TabIndex = 1;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = Color.LimeGreen;
            btnAgregarCliente.Font = new Font("Segoe UI", 10F);
            btnAgregarCliente.ForeColor = Color.White;
            btnAgregarCliente.Location = new Point(233, 299);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(146, 41);
            btnAgregarCliente.TabIndex = 0;
            btnAgregarCliente.Text = "Agregar Usuario";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // cbTipo
            // 
            cbTipo.BackColor = SystemColors.WindowFrame;
            cbTipo.ForeColor = Color.White;
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Recepcionista", "Administrador (No apto para el admin)" });
            cbTipo.Location = new Point(146, 200);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(210, 23);
            cbTipo.TabIndex = 0;
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.Font = new Font("Segoe UI", 18F);
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(22, 177);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(95, 64);
            labelFormulario1.TabIndex = 5;
            labelFormulario1.Text = "Tipo de\r\nUsuario\r\n";
            labelFormulario1.Click += labelFormulario1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(403, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // cbSexo
            // 
            cbSexo.BackColor = SystemColors.WindowFrame;
            cbSexo.ForeColor = Color.White;
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Hombre", "Mujer" });
            cbSexo.Location = new Point(406, 200);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(144, 23);
            cbSexo.TabIndex = 0;
            // 
            // labelFormulario2
            // 
            labelFormulario2.AutoSize = true;
            labelFormulario2.Font = new Font("Segoe UI", 18F);
            labelFormulario2.ForeColor = Color.White;
            labelFormulario2.Location = new Point(406, 165);
            labelFormulario2.Name = "labelFormulario2";
            labelFormulario2.Size = new Size(70, 32);
            labelFormulario2.TabIndex = 7;
            labelFormulario2.Text = "Sexo:";
            // 
            // agregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(586, 363);
            Controls.Add(labelFormulario2);
            Controls.Add(cbSexo);
            Controls.Add(pictureBox1);
            Controls.Add(labelFormulario1);
            Controls.Add(cbTipo);
            Controls.Add(btnAgregarCliente);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            Name = "agregarUsuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelFormulario1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones de los campos
                if (string.IsNullOrEmpty(txtDNI.Text) || !int.TryParse(txtDNI.Text, out int dni) || dni <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un DNI válido.");
                    return;
                }

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Por favor, ingrese un nombre.");
                    return;
                }

                if (string.IsNullOrEmpty(txtApellido.Text))
                {
                    MessageBox.Show("Por favor, ingrese un apellido.");
                    return;
                }

                if (string.IsNullOrEmpty(textoNumerico1.Text) || !int.TryParse(textoNumerico1.Text, out int telefono) || telefono <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un número de teléfono válido.");
                    return;
                }

                // Verificar si se seleccionó un tipo de usuario
                if (comboBoxEstandar1.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un tipo de usuario.");
                    return;
                }

                // Verificar si se seleccionó un sexo
                if (comboBoxEstandar2.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un sexo.");
                    return;
                }

               //Para la BDD, 2da entrega
                // Usuario nuevoUsuario = new Usuario(dni, txtNombre.Text, txtApellido.Text, telefono, comboBoxEstandar1.SelectedItem.ToString(), comboBoxEstandar2.SelectedItem.ToString());
                // baseDeDatos.AgregarUsuario(nuevoUsuario);

                // Mensaje de éxito
                MessageBox.Show("Usuario agregado exitosamente.");

                // Limpiar los campos después de agregar el usuario
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        // Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            textoNumerico1.Clear();
            comboBoxEstandar1.SelectedIndex = -1; // Desmarcar selección
            comboBoxEstandar2.SelectedIndex = -1; // Desmarcar selección
        }
    }
}
