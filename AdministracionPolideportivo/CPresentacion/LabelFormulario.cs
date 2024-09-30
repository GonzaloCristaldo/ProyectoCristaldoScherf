using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class LabelFormulario : Label
    {
        public LabelFormulario() {
            ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 18F); //Aca se establece el tamaño a todos
        }
    }
}
