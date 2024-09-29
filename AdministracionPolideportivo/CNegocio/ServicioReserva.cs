using AdministracionPolideportivo.CPresentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override void CargarEnTabla(AdministracionPolideportivo.CPresentacion.DataGridViewEstandar tabla)
        {
            if (tabla.getDatoModelo().GetType() != this.GetType())
            {
                tabla.setDatoModelo(this);
                System.Console.WriteLine("El tipo de dato no era igual al dato modelo, se cambio la cabecera");
            }
            String[] datosCliente = [reserva.idReserva.ToString(), servicio.NombreServicio];
            tabla.Rows.Add(datosCliente);

        }

        public override void CrearCabecera(DataGridViewEstandar tabla)
        {
            tabla.Columns.Clear();
            tabla.Rows.Clear();
            tabla.Columns.Add("idReserva", "Id Reserva");
            tabla.Columns.Add("servicio", "Servicio");
        }
    }
}
