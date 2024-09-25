using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class ComboBoxEstandar : ComboBox
    {

        public ComboBoxEstandar()
        {
            BackColor = SystemColors.WindowFrame;
            ForeColor = Color.White;
            Size = new Size(210, 23);
            TabIndex = 0;
        }
    }
}
