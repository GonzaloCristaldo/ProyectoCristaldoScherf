using AdministracionPolideportivo.CPresentacion.Recepcionista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionPolideportivo.CPresentacion;

namespace AdministracionPolideportivo.CNegocio
{
    internal class ServicioAdicional : EntidadDataGridView
    {
        public ServicioAdicional(int idServicio, string nombreServicio,
            string descripcionServicio, double precio)
        {
            IdServicio = idServicio;
            NombreServicio = nombreServicio;
            DescripcionServicio = descripcionServicio;
            Precio = precio;
        }

        public int IdServicio { get; set; }

        public String NombreServicio { get; set; } = null!;

        public String DescripcionServicio { get; set; } 

        public double Precio { get; set; }

        public override void CargarEnTabla(TablaDatos tabla)
        {
            if (tabla.getDatoModelo().GetType() != this.GetType())
            {
                tabla.setDatoModelo(this);
                System.Console.WriteLine("El tipo de dato no era igual al dato modelo, se cambio la cabecera");
            }
            String[] datosServicioAdicional = [IdServicio.ToString(), NombreServicio, DescripcionServicio, Precio.ToString()];
            tabla.Rows.Add(datosServicioAdicional);

        }

        public override void CrearCabecera(TablaDatos tabla)
        {
            tabla.Columns.Clear();
            tabla.Rows.Clear();
            tabla.Columns.Add("id", "Id");
            tabla.Columns.Add("nombre", "Servicio");
            tabla.Columns.Add("descripcion", "Descripcion");
            tabla.Columns.Add("precio", "Precio");
        }

    }
}
