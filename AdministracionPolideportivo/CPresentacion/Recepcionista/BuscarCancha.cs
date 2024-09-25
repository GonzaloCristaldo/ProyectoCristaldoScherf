using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion.Recepcionista
{
    internal class BuscarCancha : FormularioEstandar
    {
        public BuscarCancha()
        {

            InitializeComponent();

        }

        private BotonFormulario btnBuscar;
        private ComboBoxEstandar cbBuscar;
        private LabelFormulario lblBuscar;
        private Texto txtBuscar;
        private LabelFormulario lblID;
        private LabelFormulario lblNumero;
        private LabelFormulario lblTarifa;
        private LabelFormulario lblEstado;
        private LabelFormulario lblUbicacion;
        private LabelFormulario lblTipo;

        private void InitializeComponent()
        {
            btnBuscar = new BotonFormulario();
            cbBuscar = new ComboBoxEstandar();
            lblBuscar = new LabelFormulario();
            txtBuscar = new Texto();
            lblID = new LabelFormulario();
            lblNumero = new LabelFormulario();
            lblTarifa = new LabelFormulario();
            lblEstado = new LabelFormulario();
            lblTipo = new LabelFormulario();
            lblUbicacion = new LabelFormulario();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DimGray;
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(71, 108);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 41);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar Cancha";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // cbBuscar
            // 
            cbBuscar.BackColor = SystemColors.WindowFrame;
            cbBuscar.ForeColor = Color.White;
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Items.AddRange(new object[] { "ID", "Numero de Cancha", "Tarifa por Hora", "Estado", "Tipo de cancha", "Ubicacion" });
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
            lblBuscar.Size = new Size(109, 15);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar Cancha por:";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.WindowFrame;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(40, 79);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(210, 23);
            txtBuscar.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.ForeColor = Color.White;
            lblID.Location = new Point(40, 165);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 15);
            lblID.TabIndex = 2;
            lblID.Text = "ID: ";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.ForeColor = Color.White;
            lblNumero.Location = new Point(40, 189);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(67, 15);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "N° Cancha:";
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.ForeColor = Color.White;
            lblTarifa.Location = new Point(40, 214);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(86, 15);
            lblTarifa.TabIndex = 4;
            lblTarifa.Text = "Tarifa por hora:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.ForeColor = Color.White;
            lblEstado.Location = new Point(40, 238);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(48, 15);
            lblEstado.TabIndex = 5;
            lblEstado.Text = "Estado: ";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.ForeColor = Color.White;
            lblTipo.Location = new Point(40, 262);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(90, 15);
            lblTipo.TabIndex = 6;
            lblTipo.Text = "Tipo de cancha:";
            lblTipo.Click += lblTelefono_Click;
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.ForeColor = Color.White;
            lblUbicacion.Location = new Point(40, 287);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(63, 15);
            lblUbicacion.TabIndex = 7;
            lblUbicacion.Text = "Ubicación:";
            // 
            // BuscarCancha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(298, 334);
            Controls.Add(lblUbicacion);
            Controls.Add(lblTipo);
            Controls.Add(lblEstado);
            Controls.Add(lblTarifa);
            Controls.Add(lblNumero);
            Controls.Add(lblID);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(cbBuscar);
            Controls.Add(btnBuscar);
            Name = "BuscarCancha";
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }
    }
}

