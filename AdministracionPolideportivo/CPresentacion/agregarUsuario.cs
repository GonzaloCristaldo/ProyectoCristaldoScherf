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
        private Texto txtNombre;
        private LabelFormulario lblApellido;
        private Texto txtApellido;
        private LabelFormulario lblTelefono;
        private TextoNumerico textoNumerico1;
        private BotonFormulario btnAgregarCliente;
        private ComboBoxEstandar comboBoxEstandar1;
        private LabelFormulario labelFormulario1;
        private PictureBox pictureBox1;
        private ComboBoxEstandar comboBoxEstandar2;
        private LabelFormulario labelFormulario2;
        private TextoNumerico txtDNI;

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
            textoNumerico1 = new TextoNumerico();
            btnAgregarCliente = new BotonFormulario();
            comboBoxEstandar1 = new ComboBoxEstandar();
            labelFormulario1 = new LabelFormulario();
            pictureBox1 = new PictureBox();
            comboBoxEstandar2 = new ComboBoxEstandar();
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
            // textoNumerico1
            // 
            textoNumerico1.BackColor = SystemColors.WindowFrame;
            textoNumerico1.ForeColor = Color.White;
            textoNumerico1.Location = new Point(146, 250);
            textoNumerico1.Name = "textoNumerico1";
            textoNumerico1.Size = new Size(151, 23);
            textoNumerico1.TabIndex = 1;
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
            // 
            // comboBoxEstandar1
            // 
            comboBoxEstandar1.BackColor = SystemColors.WindowFrame;
            comboBoxEstandar1.ForeColor = Color.White;
            comboBoxEstandar1.FormattingEnabled = true;
            comboBoxEstandar1.Items.AddRange(new object[] { "Recepcionista", "Administrador (No apto para el admin)" });
            comboBoxEstandar1.Location = new Point(146, 200);
            comboBoxEstandar1.Name = "comboBoxEstandar1";
            comboBoxEstandar1.Size = new Size(210, 23);
            comboBoxEstandar1.TabIndex = 0;
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
            pictureBox1.Location = new Point(406, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // comboBoxEstandar2
            // 
            comboBoxEstandar2.BackColor = SystemColors.WindowFrame;
            comboBoxEstandar2.ForeColor = Color.White;
            comboBoxEstandar2.FormattingEnabled = true;
            comboBoxEstandar2.Items.AddRange(new object[] { "Hombre", "Mujer" });
            comboBoxEstandar2.Location = new Point(406, 200);
            comboBoxEstandar2.Name = "comboBoxEstandar2";
            comboBoxEstandar2.Size = new Size(144, 23);
            comboBoxEstandar2.TabIndex = 0;
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
            Controls.Add(comboBoxEstandar2);
            Controls.Add(pictureBox1);
            Controls.Add(labelFormulario1);
            Controls.Add(comboBoxEstandar1);
            Controls.Add(btnAgregarCliente);
            Controls.Add(textoNumerico1);
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
    }
}
