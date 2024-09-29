using AdministracionPolideportivo.CPresentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class Usuario : EntidadDataGridView
    {

        public int idUsuario {  get; set; }
        public string nombreUsuario { get; set; }
        public string apellidoUsuario { get; set; }

        public TipoUsuario tipoUsuario { get; set; }

        private String passUsuario { get; set; }

        public int DniUsuario { get; set; }
        public DateOnly fechaNacimiento { get; set; }
        public DateOnly fechaIngreso {  get; set; }

        public String Telefono {  get; set; }

        public override void CargarEnTabla(AdministracionPolideportivo.CPresentacion.DataGridViewEstandar tabla)
        {
            if (tabla.getDatoModelo().GetType() != this.GetType())
            {
                tabla.setDatoModelo(this);
                System.Console.WriteLine("El tipo de dato no era igual al dato modelo, se cambio la cabecera");
            }
            String[] datosUsuario = [idUsuario.ToString(), nombreUsuario, apellidoUsuario,DniUsuario.ToString(),
            Telefono,tipoUsuario.NombreTipoUsuario,fechaIngreso.ToString(),fechaNacimiento.ToString()];
            tabla.Rows.Add(datosUsuario);

        }

        public override void CrearCabecera(DataGridViewEstandar tabla)
        {
            tabla.Columns.Clear();
            tabla.Rows.Clear();
            tabla.Columns.Add("id", "Id");
            tabla.Columns.Add("nombre", "Nombre");
            tabla.Columns.Add("apellido", "Apellido");
            tabla.Columns.Add("dni", "DNI");
            tabla.Columns.Add("telefono", "Telefono");
            tabla.Columns.Add("tipo", "Tipo");
            tabla.Columns.Add("ingreso", "Fecha Ingreso");
            tabla.Columns.Add("nacimiento", "Fecha Nacimiento");
        }

    }
}
