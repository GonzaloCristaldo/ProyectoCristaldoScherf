using AdministracionPolideportivo.CPresentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class TipoUsuario : EntidadDataGridView
    {
        public TipoUsuario(int idTipoUsuario, string nombreTipoUsuario)
        {
            this.idTipoUsuario = idTipoUsuario;
            NombreTipoUsuario = nombreTipoUsuario;
        }

        public int idTipoUsuario {  get; set; }
        public string NombreTipoUsuario { get; set; }

        public override void CargarEnTabla(AdministracionPolideportivo.CPresentacion.DataGridViewEstandar tabla)
        {
            if (tabla.getDatoModelo().GetType() != this.GetType())
            {
                tabla.setDatoModelo(this);
                System.Console.WriteLine("El tipo de dato no era igual al dato modelo, se cambio la cabecera");
            }
            String[] datosCliente = [idTipoUsuario.ToString(), NombreTipoUsuario];
            tabla.Rows.Add(datosCliente);

        }

        public override void CrearCabecera(DataGridViewEstandar tabla)
        {
            tabla.Columns.Clear();
            tabla.Rows.Clear();
            tabla.Columns.Add("id", "Id");
            tabla.Columns.Add("nombre", "Tipo de Usuario");
        }
    }
}
