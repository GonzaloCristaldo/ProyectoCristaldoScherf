using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class VerDetalle : FormularioEstandar
    {

        public VerDetalle() {
            InitializeComponent();
        }

        override public void RefrescarCB()
        {
            //TODO
        }
        public void InitializeComponent()
        {
            tabla = new TablaDatos();
            lblDetalle = new LabelFormulario();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // tabla
            // 
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Location = new Point(12, 104);
            tabla.Name = "tabla";
            tabla.Size = new Size(776, 334);
            tabla.TabIndex = 0;
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("Segoe UI", 15F);
            lblDetalle.ForeColor = Color.White;
            lblDetalle.Location = new Point(26, 32);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(161, 28);
            lblDetalle.TabIndex = 1;
            lblDetalle.Text = "labelFormulario1";
            // 
            // VerDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(800, 450);
            Controls.Add(lblDetalle);
            Controls.Add(tabla);
            Name = "VerDetalle";
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public TablaDatos tabla;
        public LabelFormulario lblDetalle;
    }
}
