using AdministracionPolideportivo.CPresentacion.Recepcionista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionPolideportivo.CPresentacion;

namespace AdministracionPolideportivo.CNegocio
{
    internal class ServicioReserva : EntidadDataGridView
    {
        public ServicioReserva(Reserva reservaP, ServicioAdicional servicioP)
        {
            reserva = reservaP;
            servicio = servicioP;
        }

        public Reserva reserva { get; set; }

        public ServicioAdicional servicio { get; set; }

        public override void CargarEnTabla(TablaDatos tabla)
        {
            if (tabla.getDatoModelo().GetType() != this.GetType())
            {
                tabla.setDatoModelo(this);
                System.Console.WriteLine("El tipo de dato no era igual al dato modelo, se cambio la cabecera");
            }
            String[] datosCliente = [reserva.idReserva.ToString(), servicio.NombreServicio];
            tabla.Rows.Add(datosCliente);

        }

        public override void CrearCabecera(TablaDatos tabla)
        {
            tabla.Columns.Clear();
            tabla.Rows.Clear();
            tabla.Columns.Add("idReserva", "Id Reserva");
            tabla.Columns.Add("servicio", "Servicio");
        }
    }
}
