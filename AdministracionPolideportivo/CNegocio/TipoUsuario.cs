using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class TipoUsuario
    {
        public TipoUsuario(int idTipoUsuario, string nombreTipoUsuario)
        {
            this.idTipoUsuario = idTipoUsuario;
            NombreTipoUsuario = nombreTipoUsuario;
        }

        public int idTipoUsuario {  get; set; }
        public string NombreTipoUsuario { get; set; }
    }
}
