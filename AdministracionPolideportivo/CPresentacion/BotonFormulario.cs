using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class BotonFormulario : Button
    {
        public BotonFormulario()
        {
            BackColor = Color.DimGray;
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            Location = new Point(58, 49);
            Name = "botonFormulario1";
            Size = new Size(146, 41);
            TabIndex = 0;
            Text = "botonFormulario1";
            UseVisualStyleBackColor = false;
            
        }

    }
}
