using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionPolideportivo.CDatos;
using AdministracionPolideportivo.CNegocio;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class AgregarCliente : FormularioEstandar
    {
        public AgregarCliente()
        {

            InitializeComponent();

        }

        private LabelFormulario lblDNI;
        private LabelFormulario lblNombre;
        private Texto txtNombre;
        private LabelFormulario lblApellido;
        private Texto txtApellido;
        private LabelFormulario lblTelefono;
        private TextoNumerico txtTelefono;
        private BotonFormulario btnAgregarCliente;
        private TextoNumerico txtDNI;

        private void InitializeComponent()
        {
            lblDNI = new LabelFormulario();
            txtDNI = new TextoNumerico();
            lblNombre = new LabelFormulario();
            txtNombre = new Texto();
            lblApellido = new LabelFormulario();
            txtApellido = new Texto();
            lblTelefono = new LabelFormulario();
            txtTelefono = new TextoNumerico();
            btnAgregarCliente = new BotonFormulario();
            SuspendLayout();
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 13F);
            lblDNI.ForeColor = Color.White;
            lblDNI.Location = new Point(22, 21);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(55, 25);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "D.N.I.";
            // 
            // txtDNI
            // 
            txtDNI.BackColor = SystemColors.WindowFrame;
            txtDNI.ForeColor = Color.White;
            txtDNI.Location = new Point(99, 24);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(117, 23);
            txtDNI.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 13F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(22, 67);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.WindowFrame;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(106, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 23);
            txtNombre.TabIndex = 0;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 13F);
            lblApellido.ForeColor = Color.White;
            lblApellido.Location = new Point(22, 118);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 25);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = SystemColors.WindowFrame;
            txtApellido.ForeColor = Color.White;
            txtApellido.Location = new Point(106, 118);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(210, 23);
            txtApellido.TabIndex = 0;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 13F);
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(21, 167);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(79, 25);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.WindowFrame;
            txtTelefono.ForeColor = Color.White;
            txtTelefono.Location = new Point(106, 169);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(151, 23);
            txtTelefono.TabIndex = 1;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = Color.DimGray;
            btnAgregarCliente.Font = new Font("Segoe UI", 10F);
            btnAgregarCliente.ForeColor = Color.White;
            btnAgregarCliente.Location = new Point(70, 227);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(146, 41);
            btnAgregarCliente.TabIndex = 0;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // AgregarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(336, 300);
            Controls.Add(btnAgregarCliente);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            Name = "AgregarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            bool validacion = true;

            if (validacion)
            {
                Cliente cliente = new Cliente(Int32.Parse(txtDNI.Text),txtNombre.Text,txtApellido.Text,txtTelefono.Text);
                System.Console.WriteLine("Registros afectados: "+DALCliente.AgregarCliente(cliente));
            }
            
        }
    }
}
