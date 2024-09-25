using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion.Recepcionista
{
    internal class AgregarServicioAdicional : FormularioEstandar
    {

        public AgregarServicioAdicional()
        {

            InitializeComponent();

        }

        private void InitializeComponent()
        {
            lblNombre = new LabelFormulario();
            lblDescripcion = new LabelFormulario();
            lblTarifa = new LabelFormulario();
            texto1 = new Texto();
            texto2 = new Texto();
            textoNumerico1 = new TextoNumerico();
            btnAgregar = new BotonFormulario();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(31, 21);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(114, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del Servicio";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = Color.White;
            lblDescripcion.Location = new Point(76, 50);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción";
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.ForeColor = Color.White;
            lblTarifa.Location = new Point(48, 76);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(97, 15);
            lblTarifa.TabIndex = 2;
            lblTarifa.Text = "Tarifa del servicio";
            // 
            // texto1
            // 
            texto1.BackColor = SystemColors.WindowFrame;
            texto1.ForeColor = Color.White;
            texto1.Location = new Point(151, 18);
            texto1.Name = "texto1";
            texto1.Size = new Size(210, 23);
            texto1.TabIndex = 0;
            // 
            // texto2
            // 
            texto2.BackColor = SystemColors.WindowFrame;
            texto2.ForeColor = Color.White;
            texto2.Location = new Point(151, 47);
            texto2.Name = "texto2";
            texto2.Size = new Size(210, 23);
            texto2.TabIndex = 0;
            // 
            // textoNumerico1
            // 
            textoNumerico1.BackColor = SystemColors.WindowFrame;
            textoNumerico1.ForeColor = Color.White;
            textoNumerico1.Location = new Point(151, 76);
            textoNumerico1.Name = "textoNumerico1";
            textoNumerico1.Size = new Size(210, 23);
            textoNumerico1.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DimGray;
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(151, 154);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(146, 41);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Servicio";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // AgregarServicioAdicional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(467, 361);
            Controls.Add(btnAgregar);
            Controls.Add(textoNumerico1);
            Controls.Add(texto2);
            Controls.Add(texto1);
            Controls.Add(lblTarifa);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Name = "AgregarServicioAdicional";
            ResumeLayout(false);
            PerformLayout();
        }

        private LabelFormulario lblNombre;
        private LabelFormulario lblTarifa;
        private Texto texto1;
        private Texto texto2;
        private TextoNumerico textoNumerico1;
        private BotonFormulario btnAgregar;
        private LabelFormulario lblDescripcion;
    }
}
