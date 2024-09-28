using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class BuscarRecinto : FormularioEstandar
    {
        public BuscarRecinto()
        {

            InitializeComponent();

        }

        private BotonFormulario btnBuscar;
        private ComboBoxEstandar cbBuscar;
        private LabelFormulario lblBuscar;
        private DataGridView dataGridView1;
        private Texto txtBuscar;

        private void InitializeComponent()
        {
            btnBuscar = new BotonFormulario();
            cbBuscar = new ComboBoxEstandar();
            lblBuscar = new LabelFormulario();
            txtBuscar = new Texto();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DimGray;
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(250, 108);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 41);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar Recinto";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // cbBuscar
            // 
            cbBuscar.BackColor = SystemColors.WindowFrame;
            cbBuscar.ForeColor = Color.White;
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Items.AddRange(new object[] { "ID", "Numero de Cancha", "Tarifa por Hora", "Estado", "Tipo de cancha", "Ubicacion" });
            cbBuscar.Location = new Point(228, 47);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(183, 23);
            cbBuscar.TabIndex = 0;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.ForeColor = Color.White;
            lblBuscar.Location = new Point(266, 19);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(109, 15);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar Recinto por:";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.WindowFrame;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(219, 79);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(210, 23);
            txtBuscar.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(659, 150);
            dataGridView1.TabIndex = 2;
            // 
            // BuscarRecinto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(683, 334);
            Controls.Add(dataGridView1);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(cbBuscar);
            Controls.Add(btnBuscar);
            Name = "BuscarRecinto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }
    }
}

