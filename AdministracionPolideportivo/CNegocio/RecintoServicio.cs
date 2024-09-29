using AdministracionPolideportivo.CPresentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class RecintoServicio: EntidadDataGridView
    {
        public RecintoServicio(Recinto recintoP, ServicioAdicional servicioP)
        {
            recinto = recintoP;
            servicio = servicioP;
        }

        public Recinto recinto{ get; set; }

        public ServicioAdicional servicio { get; set; }

        public override void CargarEnTabla(AdministracionPolideportivo.CPresentacion.DataGridViewEstandar tabla)
        {
            if (tabla.getDatoModelo().GetType() != this.GetType())
            {
                tabla.setDatoModelo(this);
                System.Console.WriteLine("El tipo de dato no era igual al dato modelo, se cambio la cabecera");
            }
            String[] datosServicio = [recinto.NroRecinto.ToString(), servicio.NombreServicio,servicio.Precio.ToString()];
            tabla.Rows.Add(datosServicio);

        }

        public override void CrearCabecera(DataGridViewEstandar tabla)
        {
            tabla.Columns.Clear();
            tabla.Rows.Clear();
            tabla.Columns.Add("numero", "Recinto N°");
            tabla.Columns.Add("Servicio", "Servicio");
            tabla.Columns.Add("Tarifa", "Tarifa");
        }

    }
}
