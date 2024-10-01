using AdministracionPolideportivo.CNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class BuscarUsuario : FormularioEstandar
    {

        public BuscarUsuario()
        {
            InitializeComponent();
            tablaDatos1.setDatoModelo(new Usuario());
        }

       
        private TablaDatos tablaDatos1;


        private void InitializeComponent()
        {
            tablaDatos1 = new TablaDatos();
            btnBuscar = new BotonFormulario();
            cbBuscar = new ComboBoxEstandar();
            txtBuscar = new Texto();
            labelFormulario1 = new LabelFormulario();
            ((System.ComponentModel.ISupportInitialize)tablaDatos1).BeginInit();
            SuspendLayout();
            // 
            // tablaDatos1
            // 
            tablaDatos1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaDatos1.Location = new Point(12, 159);
            tablaDatos1.Name = "tablaDatos1";
            tablaDatos1.Size = new Size(776, 279);
            tablaDatos1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DimGray;
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(336, 112);
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
            cbBuscar.Location = new Point(303, 40);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(210, 23);
            cbBuscar.TabIndex = 0;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.WindowFrame;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(267, 72);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(291, 23);
            txtBuscar.TabIndex = 0;
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.Font = new Font("Segoe UI", 15F);
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(321, 9);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(173, 28);
            labelFormulario1.TabIndex = 1;
            labelFormulario1.Text = "Buscar Cliente por:";
            // 
            // BuscarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(800, 450);
            Controls.Add(labelFormulario1);
            Controls.Add(txtBuscar);
            Controls.Add(cbBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(tablaDatos1);
            Name = "BuscarUsuario";
            ((System.ComponentModel.ISupportInitialize)tablaDatos1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private BotonFormulario btnBuscar;
        private ComboBoxEstandar cbBuscar;
        private Texto txtBuscar;
        private LabelFormulario labelFormulario1;
    }
}
