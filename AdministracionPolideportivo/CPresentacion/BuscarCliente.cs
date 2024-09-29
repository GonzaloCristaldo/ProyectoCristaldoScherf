using AdministracionPolideportivo.CNegocio;
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
        private DataGridViewEstandar tablaClientes;
        private Panel panel1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Texto txtBuscar;

        private void InitializeComponent()
        {
            btnBuscar = new BotonFormulario();
            cbBuscar = new ComboBoxEstandar();
            lblBuscar = new LabelFormulario();
            txtBuscar = new Texto();
            tablaClientes = new DataGridViewEstandar(new Cliente(0,0,"a","b","c"));
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)tablaClientes).BeginInit();
            panel1.SuspendLayout();
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
            btnBuscar.Click += btnBuscar_Click;
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
            // tablaClientes
            // 
            tablaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaClientes.Dock = DockStyle.Fill;
            tablaClientes.Location = new Point(0, 0);
            tablaClientes.Name = "tablaClientes";
            tablaClientes.Size = new Size(584, 116);
            tablaClientes.TabIndex = 2;
            
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(tablaClientes);
            panel1.Location = new Point(13, 206);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 116);
            panel1.TabIndex = 3;
            // 
            // BuscarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(609, 334);
            Controls.Add(panel1);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(cbBuscar);
            Controls.Add(btnBuscar);
            Name = "BuscarCliente";
            ((System.ComponentModel.ISupportInitialize)tablaClientes).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            new Cliente(1,43822713,"Lucas Daniel","Scherf","3794 - 123456").CargarEnTabla(tablaClientes);

        }
    }
}
