using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    public class Texto : TextBox
    {
        public Texto() {
            BackColor = SystemColors.WindowFrame;
            ForeColor = Color.White;
            Location = new Point(100, 68);
            Name = "texto1";
            Size = new Size(210, 23);
            TabIndex = 0;
        }
    }
}
