using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class Partido
    {
        public int idPartido {  get; set; }
        public int idCancha { get; set; }

        public int idCliente { get; set; }

        public TimeOnly Hora { get; set; }

    }
}
