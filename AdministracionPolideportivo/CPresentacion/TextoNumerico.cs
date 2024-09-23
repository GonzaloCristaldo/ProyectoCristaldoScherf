using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class TextoNumerico : TextBox
    {
        public TextoNumerico()
        {
            BackColor = SystemColors.WindowFrame;
            ForeColor = Color.White;
            Location = new Point(100, 158);
            Name = "textoNumerico1";
            Size = new Size(210, 23);
            TabIndex = 1;
            KeyPress += textoNumerico_KeyPress;
            TextChanged += textoNumerico_TextChanged;
        }

        private void textoNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si no es un número o la tecla de retroceso, cancela el evento.
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela el evento si no es un número.
            }
        }

        private void textoNumerico_TextChanged(object sender, EventArgs e)
        {
            // Necesario para evitar copiar y pegar caracteres
            // Verifica que todo el texto sea numérico.
            if (!System.Text.RegularExpressions.Regex.IsMatch(Text, "^[0-9]*$"))
            {
                // Si hay algún carácter no numérico, lo elimina.
                MessageBox.Show("Por favor, ingrese solo números.");
                Text = System.Text.RegularExpressions.Regex.Replace(Text, "[^0-9]", "");
                SelectionStart = Text.Length; // Mantiene el cursor al final.
            }
        }
    }
}
