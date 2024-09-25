using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion.Recepcionista
{
    internal class BuscarPartido : FormularioEstandar
    {
        public BuscarPartido()
        {

            InitializeComponent();

        }

        private void InitializeComponent()
        {
            labelFormulario1 = new LabelFormulario();
            cbBuscar = new ComboBoxEstandar();
            texto1 = new Texto();
            btnBuscar = new BotonFormulario();
            SuspendLayout();
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(95, 14);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(104, 15);
            labelFormulario1.TabIndex = 0;
            labelFormulario1.Text = "Buscar Partido por";
            // 
            // cbBuscar
            // 
            cbBuscar.BackColor = SystemColors.WindowFrame;
            cbBuscar.ForeColor = Color.White;
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Location = new Point(45, 41);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(210, 23);
            cbBuscar.TabIndex = 0;
            // 
            // texto1
            // 
            texto1.BackColor = SystemColors.WindowFrame;
            texto1.ForeColor = Color.White;
            texto1.Location = new Point(25, 87);
            texto1.Name = "texto1";
            texto1.Size = new Size(249, 23);
            texto1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DimGray;
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(77, 130);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 41);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar Partido";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // BuscarPartido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(303, 203);
            Controls.Add(btnBuscar);
            Controls.Add(texto1);
            Controls.Add(cbBuscar);
            Controls.Add(labelFormulario1);
            Name = "BuscarPartido";
            ResumeLayout(false);
            PerformLayout();
        }

        private LabelFormulario labelFormulario1;
        private ComboBoxEstandar cbBuscar;
        private Texto texto1;
        private BotonFormulario btnBuscar;
    }
}
