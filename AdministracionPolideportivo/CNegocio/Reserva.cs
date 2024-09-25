using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class Reserva
    {
        public Reserva(int idReserva, int idRecinto, int idCliente, DateOnly fecha, TimeOnly hora)
        {
            this.idReserva = idReserva;
            this.idRecinto = idRecinto;
            this.idCliente = idCliente;
            Fecha = fecha;
            Hora = hora;
        }

        public int idReserva {  get; set; }
        public int idRecinto { get; set; }

        public int idCliente { get; set; }

        public DateOnly Fecha { get; set; }

        public TimeOnly Hora { get; set; }

    }
}
