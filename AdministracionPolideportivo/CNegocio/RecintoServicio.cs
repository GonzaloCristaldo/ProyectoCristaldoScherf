using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class RecintoServicio
    {
        public RecintoServicio(int idRecinto, int idServicio)
        {
            IdRecinto = idRecinto;
            IdServicio = idServicio;
        }

        public int IdRecinto{ get; set; }

        public int IdServicio { get; set; }

    }
}
