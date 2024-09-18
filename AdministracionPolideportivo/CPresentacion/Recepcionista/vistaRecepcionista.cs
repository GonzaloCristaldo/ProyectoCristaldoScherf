using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion.Recepcionista
{
    internal class vistaRecepcionista : VentanaMenu
    {
        public vistaRecepcionista()
        {
            InitializeComponent();
        }

        private Button button1;

        private void InitializeComponent()
        {
            button1 = new Button();
            panelOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // panelOpciones
            // 
            panelOpciones.Controls.Add(button1);
            // 
            // button1
            // 
            button1.Location = new Point(30, 72);
            button1.Name = "button1";
            button1.Size = new Size(118, 46);
            button1.TabIndex = 0;
            button1.Text = "Agregar Cancha";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // vistaRecepcionista
            // 
            ClientSize = new Size(694, 450);
            Name = "vistaRecepcionista";
            panelOpciones.ResumeLayout(false);
            ResumeLayout(false);
        }
        Form formActual;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formularioNuevo = new Form1();//Se instancia el formulario que se desea agregar al panel
            formularioNuevo.TopLevel = false;//se cambia la propiedad toplevel para que el formulario pueda ser hijo del formulario principal
            this.panelFormulario.Controls.Add(formularioNuevo);//se agrega el formulario al panel
            formularioNuevo.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//se saca el borde
            formularioNuevo.Dock = DockStyle.Fill;//El formulario cubre toda el area de su panel padre
            formularioNuevo.Show();
            if (formActual != null) {this.panelFormulario.Controls.Remove(formActual); }
            formActual= formularioNuevo;

        }
    }
}
