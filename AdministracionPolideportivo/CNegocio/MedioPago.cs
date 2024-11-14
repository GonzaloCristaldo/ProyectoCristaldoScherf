using AdministracionPolideportivo.CPresentacion.Recepcionista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionPolideportivo.CPresentacion;

namespace AdministracionPolideportivo.CNegocio
{
    internal class MedioPago : EntidadDataGridView
    {
        public MedioPago(int idMedioPago, string nombreMedioPago)
        {
            this.idMedioPago = idMedioPago;
            this.nombreMedioPago = nombreMedioPago;
        }

        public int idMedioPago {  get; set; }
        public String nombreMedioPago { get; set; }

        public override void CargarEnTabla(TablaDatos tabla)
        {
            if (tabla.getDatoModelo().GetType() != this.GetType())
            {
                tabla.setDatoModelo(this);
                System.Console.WriteLine("El tipo de dato no era igual al dato modelo, se cambio la cabecera");
            }
            String[] datosMedioPago = [idMedioPago.ToString(), nombreMedioPago];
            tabla.Rows.Add(datosMedioPago);

        }

        public override void CrearCabecera(TablaDatos tabla)
        {
            tabla.Columns.Clear();
            tabla.Rows.Clear();
            tabla.Columns.Add("id", "Id");
            tabla.Columns.Add("nombre", "Medio de Pago");
        }
        public override string ToString()
        {
            return this.nombreMedioPago;
        }
    }
    
}
