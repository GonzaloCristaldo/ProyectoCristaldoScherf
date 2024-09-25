using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class CanchaServicio
    {
        public CanchaServicio(int idCancha, int idServicio)
        {
            IdCancha = idCancha;
            IdServicio = idServicio;
        }

        public int IdCancha { get; set; }

        public int IdServicio { get; set; }

    }
}
