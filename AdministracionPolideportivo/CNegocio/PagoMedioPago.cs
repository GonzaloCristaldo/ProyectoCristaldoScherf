using AdministracionPolideportivo.CPresentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class PagoMedioPago : EntidadDataGridView
    {
        public PagoMedioPago(Pago pago, MedioPago medioPago, double monto)
        {
            this.pago = pago;
            this.medioPago = medioPago;
            this.monto = monto;
        }

        public Pago pago {  get; set; }
        public MedioPago medioPago { get; set; }

        public double monto {  get; set; }

        public override void CargarEnTabla(AdministracionPolideportivo.CPresentacion.DataGridViewEstandar tabla)
        {
            if (tabla.getDatoModelo().GetType() != this.GetType())
            {
                tabla.setDatoModelo(this);
                System.Console.WriteLine("El tipo de dato no era igual al dato modelo, se cambio la cabecera");
            }
            String[] datosPago = [pago.idPago.ToString(), medioPago.idMedioPago.ToString(), monto.ToString()];
            tabla.Rows.Add(datosPago);

        }

        public override void CrearCabecera(DataGridViewEstandar tabla)
        {
            tabla.Columns.Clear();
            tabla.Rows.Clear();
            tabla.Columns.Add("idPago", "Id Pago");
            tabla.Columns.Add("idMedioPago", "Id Medio de Pago");
            tabla.Columns.Add("monto", "Monto Pagado");
        }
    }
}
