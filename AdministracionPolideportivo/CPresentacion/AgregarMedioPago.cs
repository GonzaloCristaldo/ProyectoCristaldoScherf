using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class BackupBDD : FormularioEstandar
    {

        public BackupBDD()
        {

            InitializeComponent();

        }



        private void InitializeComponent()
        {
            labelFormulario1 = new LabelFormulario();
            SuspendLayout();
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.Font = new Font("Segoe UI", 15F);
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(205, 24);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(222, 28);
            labelFormulario1.TabIndex = 0;
            labelFormulario1.Text = "Agregar medio de pago";
            // 
            // AgregarMedioPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(647, 334);
            Controls.Add(labelFormulario1);
            Name = "AgregarMedioPago";
            Load += AgregarMedioPago_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void AgregarMedioPago_Load(object sender, EventArgs e)
        {

        }

        private LabelFormulario labelFormulario1;
    }
}
