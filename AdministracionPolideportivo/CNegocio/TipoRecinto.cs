using AdministracionPolideportivo.CPresentacion.Recepcionista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionPolideportivo.CPresentacion;

namespace AdministracionPolideportivo.CNegocio
{
    internal class TipoRecinto : EntidadDataGridView
    {
        public int id {  get; set; }
        public String nombre { get; set; }
        public override void CargarEnTabla(TablaDatos tabla)
        {
            if (tabla.getDatoModelo().GetType() != this.GetType())
            {
                tabla.setDatoModelo(this);
                System.Console.WriteLine("El tipo de dato no era igual al dato modelo, se cambio la cabecera");
            }
            String[] datosCliente = [id.ToString(), nombre];
            tabla.Rows.Add(datosCliente);

        }

        public override void CrearCabecera(TablaDatos tabla)
        {
            tabla.Columns.Clear();
            tabla.Rows.Clear();
            tabla.Columns.Add("id", "Id");
            tabla.Columns.Add("nombre", "Nombre");
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
