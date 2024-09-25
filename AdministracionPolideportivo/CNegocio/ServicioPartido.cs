using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class ServicioPartido
    {
        public ServicioPartido(int idServicio, int idPartido)
        {
            IdPartido = idPartido;
            IdServicio = idServicio;
        }

        public int IdPartido { get; set; }

        public int IdServicio { get; set; }
    }
}
