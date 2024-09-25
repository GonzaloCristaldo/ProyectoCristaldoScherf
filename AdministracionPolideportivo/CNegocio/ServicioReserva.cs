using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class ServicioReserva
    {
        public ServicioReserva(int idReserva, int idServicio)
        {
            IdReserva = idReserva;
            IdServicio = idServicio;
        }

        public int IdReserva { get; set; }

        public int IdServicio { get; set; }
    }
}
