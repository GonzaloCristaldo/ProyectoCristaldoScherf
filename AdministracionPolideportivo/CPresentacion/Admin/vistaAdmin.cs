using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class VistaAdmin : VentanaMenu
    {
        public VistaAdmin() : base()
        {

            InitializeComponent();
        }
        private void InitializeComponent()
        {
            label3 = new Label();
            panelFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // panelFormulario
            // 
            panelFormulario.Controls.Add(label3);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 35);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // VistaAdmin
            // 
            ClientSize = new Size(694, 450);
            Name = "VistaAdmin";
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            ResumeLayout(false);
        }

        private Label label2;
        private Label label3;
        private Label label1;
    }
}