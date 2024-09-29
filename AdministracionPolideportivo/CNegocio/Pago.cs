using AdministracionPolideportivo.CPresentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class Pago : EntidadDataGridView
    {
        public Pago(int idPago, Reserva reserva)
        {
            this.idPago = idPago;
            this.reserva = reserva;
        }

        public int idPago {  get; set; }
        public Reserva reserva {  get; set; }

        public override void CargarEnTabla(AdministracionPolideportivo.CPresentacion.DataGridViewEstandar tabla)
        {
            if (tabla.getDatoModelo().GetType() != this.GetType())
            {
                tabla.setDatoModelo(this);
                System.Console.WriteLine("El tipo de dato no era igual al dato modelo, se cambio la cabecera");
            }
            String[] datosPago = [idPago.ToString(), reserva.idReserva.ToString()];
            tabla.Rows.Add(datosPago);

        }

        public override void CrearCabecera(DataGridViewEstandar tabla)
        {
            tabla.Columns.Clear();
            tabla.Rows.Clear();
            tabla.Columns.Add("id", "Id Pago");
            tabla.Columns.Add("dni", "Id Reserva");
        }



    }
}
