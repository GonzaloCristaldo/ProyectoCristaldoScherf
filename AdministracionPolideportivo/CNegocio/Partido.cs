using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class Partido
    {
        public Partido(int idPartido, int idCancha, int idCliente, TimeOnly hora)
        {
            this.idPartido = idPartido;
            this.idCancha = idCancha;
            this.idCliente = idCliente;
            Hora = hora;
        }

        public int idPartido {  get; set; }
        public int idCancha { get; set; }

        public int idCliente { get; set; }

        public DateOnly Fecha { get; set; }

        public TimeOnly Hora { get; set; }

    }
}
