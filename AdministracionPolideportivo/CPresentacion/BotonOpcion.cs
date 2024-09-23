using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class BotonOpcion : Button
    {
        Form formularioViejo; // formulario viejo que se debe eliminar al abrir el nuevo formulario
        Form formularioAsociado; // formulario que debe abrir el boton al ser presionado
        VentanaMenu ventana; // ventana a la que pertenece el boton y en la que debe abrir el formulario asociado
        public BotonOpcion(Form formularioAsociado, VentanaMenu ventana, Form formularioViejo) {

            BackColor = Color.FromArgb(64, 64, 64);
            Dock = DockStyle.Fill;
            FlatAppearance.BorderColor = Color.Red;
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Segoe UI", 12F);
            ForeColor = SystemColors.ButtonHighlight;
            Location = new Point(3, 3);
            Name = "button1";
            Size = new Size(191, 44);
            TabIndex = 0;
            Text = "Agregar Cancha";
            UseVisualStyleBackColor = false;
            this.formularioAsociado = formularioAsociado;
            Click += BotonFormulario_Click;
            this.ventana = ventana;
            this.FormularioViejo = formularioViejo;
        }

        public Form FormularioViejo { get => formularioViejo; set => formularioViejo = value; }

        private void BotonFormulario_Click(object? sender, EventArgs e)
        {
            if (FormularioViejo != null)//corrobora si hay alguna referencia a un formulario viejo
            {
                ventana.panelFormulario.Controls.Remove(FormularioViejo);//Elimina el formulario viejo
                formularioViejo.Show();
                System.Console.WriteLine("Se escondio un form");
            }
            formularioAsociado.TopLevel = false;//Necesario para poder identar formularios
            ventana.panelFormulario.Controls.Add(formularioAsociado);//agregar formulario al panel de la ventana a la que pertenece el boton
            formularioAsociado.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //eliminar el borde
            formularioAsociado.Dock = DockStyle.Fill;//cubre toda el area del panel correspondiente
            formularioAsociado.Show();//muestra el formulario

            System.Console.WriteLine("********************************************");
            System.Console.WriteLine("SE AGREGO UN FORMULARIO DE TIPO" + formularioAsociado.GetType());
            ventana.actualizarFormulario(formularioAsociado);
        }
    }
}
