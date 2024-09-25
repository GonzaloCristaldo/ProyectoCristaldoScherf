using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class Usuario
    {

        public int idUsuario {  get; set; }
        public string nombreUsuario { get; set; }

        public int idTipoUsuario { get; set; }

        private String passUsuario { get; set; }

    }
}
