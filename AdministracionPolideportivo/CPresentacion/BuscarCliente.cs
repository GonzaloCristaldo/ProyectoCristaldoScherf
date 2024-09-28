using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class BuscarCliente : FormularioEstandar
    {
        public BuscarCliente()
        {

            InitializeComponent();

        }

        private BotonFormulario btnBuscar;
        private ComboBoxEstandar cbBuscar;
        private LabelFormulario lblBuscar;
        private Texto txtBuscar;
        private LabelFormulario lblID;
        private LabelFormulario lblDNI;
        private LabelFormulario lblNombre;
        private LabelFormulario lblApellido;
        private LabelFormulario lblTelefono;

        private void InitializeComponent()
        {
            btnBuscar = new BotonFormulario();
            cbBuscar = new ComboBoxEstandar();
            lblBuscar = new LabelFormulario();
            txtBuscar = new Texto();
            lblID = new LabelFormulario();
            lblDNI = new LabelFormulario();
            lblNombre = new LabelFormulario();
            lblApellido = new LabelFormulario();
            lblTelefono = new LabelFormulario();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DimGray;
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(67, 134);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 41);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar Cliente";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // cbBuscar
            // 
            cbBuscar.BackColor = SystemColors.WindowFrame;
            cbBuscar.ForeColor = Color.White;
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Items.AddRange(new object[] { "ID", "DNI", "Nombre", "Apellido", "Telefono" });
            cbBuscar.Location = new Point(49, 47);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(183, 23);
            cbBuscar.TabIndex = 0;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.ForeColor = Color.White;
            lblBuscar.Location = new Point(87, 19);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(106, 15);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar Cliente por:";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.WindowFrame;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(37, 92);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(210, 23);
            txtBuscar.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.ForeColor = Color.White;
            lblID.Location = new Point(37, 194);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 15);
            lblID.TabIndex = 2;
            lblID.Text = "ID: ";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.ForeColor = Color.White;
            lblDNI.Location = new Point(37, 218);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(30, 15);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "DNI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(37, 243);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre: ";
            lblNombre.Click += lblNombre_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.ForeColor = Color.White;
            lblApellido.Location = new Point(37, 270);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(57, 15);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido: ";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(36, 298);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(58, 15);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Telefono: ";
            // 
            // BuscarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(298, 334);
            Controls.Add(lblTelefono);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblDNI);
            Controls.Add(lblID);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(cbBuscar);
            Controls.Add(btnBuscar);
            Name = "BuscarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
