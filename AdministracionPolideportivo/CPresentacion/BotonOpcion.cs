using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class BotonOpcion : Button
    {
        static int caracteresPorLinea = 22;
        String textoBoton;
        Form formularioViejo; // formulario viejo que se debe eliminar al abrir el nuevo formulario
        Form formularioAsociado; // formulario que debe abrir el boton al ser presionado
        VentanaMenu ventana; // ventana a la que pertenece el boton y en la que debe abrir el formulario asociado
        public BotonOpcion(Form formularioAsociado, VentanaMenu ventana, Form formularioViejo, string textoBoton)
        {

            BackColor = Color.FromArgb(64, 64, 64);
            Dock = DockStyle.Fill;
            FlatAppearance.BorderColor = Color.Red;
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Font = new System.Drawing.Font("Segoe UI", 12F);
            ForeColor = SystemColors.ButtonHighlight;
            Location = new Point(3, 3);
            Name = "button1";
            Size = new Size(191, 60);
            TabIndex = 0;
            
            UseVisualStyleBackColor = false;
            this.formularioAsociado = formularioAsociado;
            Click += BotonFormulario_Click;
            this.ventana = ventana;
            this.FormularioViejo = formularioViejo;
            this.textoBoton = textoBoton;

            EstablecerTexto(textoBoton);
            
            
        }

        private void EstablecerTexto(String texto)
        {
            /*En cada linea de texto del boton entran 22 caracteres, por lo tanto
            hay que hacer un salto de linea para los botones que tengan
            mas de 22 caracteres, teniendo la consideracion de no separar una palabra
            en distintos renglones*/
            if (textoBoton.Length <= caracteresPorLinea)
            {
                Text = textoBoton;
            }
            else
            {
                String textoFormateado = "";
                List<String> palabras = new List<String>();
                String[] palabrasOrdenadas;
                for (int i = 0; i < textoBoton.Length; i++)
                {

                    if (Char.IsWhiteSpace(textoBoton.ElementAt(i)))
                    {
                        String palabra = "";
                        for (int j = i - 1; j >= 0 && !Char.IsWhiteSpace(textoBoton.ElementAt(j)); j--)
                        {
                            palabra += textoBoton.ElementAt(j);
                        }
                        palabras.Add(palabra);
                    }
                    else if (i == textoBoton.Length - 1)
                    {
                        String palabra = "";
                        for (int j = i; j >= 0 && !Char.IsWhiteSpace(textoBoton.ElementAt(j)); j--)
                        {
                            palabra += textoBoton.ElementAt(j);
                        }
                        palabras.Add(palabra);
                    }

                }
                palabrasOrdenadas = palabras.ToArray();
                Array.Reverse(palabrasOrdenadas);
                for (int i = 0; i < palabras.Count; i++)
                {
                    if (i == 0)
                    {
                        textoFormateado += palabrasOrdenadas.ElementAt<String>(i);
                    }
                    else
                    {
                        if ((textoFormateado.Count() + palabrasOrdenadas.ElementAt<String>(i).Count()) <= caracteresPorLinea - 1)
                        {//hay que restar 1 a los caracteres por linea para calcular si entra el espacio entre las palabras
                            textoFormateado += " " + palabrasOrdenadas.ElementAt<String>(i);
                        }
                        else
                        {
                            textoFormateado += Environment.NewLine + palabrasOrdenadas.ElementAt<String>(i);
                        }
                    }
                }
                //Debido al proceso de construccion de palabras y de la lista de palabras, se debe invertir el texto
                char[] array = textoFormateado.ToCharArray();
                Array.Reverse(array);
                textoFormateado = new String(array);
                Text = textoFormateado;
            }
        }

        public Form FormularioViejo { get => formularioViejo; set => formularioViejo = value; }

        private void BotonFormulario_Click(object? sender, EventArgs e)
        {
            if (FormularioViejo != null)//corrobora si hay alguna referencia a un formulario viejo
            {
                ventana.panelFormulario.Controls.Remove(FormularioViejo);//Elimina el formulario viejo
                formularioViejo.Show();
                
            }
            formularioAsociado.TopLevel = false;//Necesario para poder identar formularios
            ventana.panelFormulario.Controls.Add(formularioAsociado);//agregar formulario al panel de la ventana a la que pertenece el boton
            formularioAsociado.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //eliminar el borde
            formularioAsociado.Dock = DockStyle.Fill;//cubre toda el area del panel correspondiente
            formularioAsociado.Show();//muestra el formulario

            
            ventana.actualizarFormulario(formularioAsociado);
        }
    }
}
