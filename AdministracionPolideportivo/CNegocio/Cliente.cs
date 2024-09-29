using AdministracionPolideportivo.CPresentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class Cliente : EntidadDataGridView
    {
        
        public Cliente(int idCliente, int dniCliente, string nombreCliente, string apellidoCliente, string telefono)
        {
            
            IdCliente = idCliente;
            DniCliente = dniCliente;
            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;
            Telefono = telefono;
        }

        public int IdCliente { get; set; }
        public int DniCliente { get; set; }
        public string NombreCliente { get; set; } = null!;
        public string ApellidoCliente { get; set; } = null!;
        public string Telefono { get; set; } = null!;


        public override void CargarEnTabla(AdministracionPolideportivo.CPresentacion.DataGridViewEstandar tabla)
        {
            if (tabla.getDatoModelo().GetType()!=this.GetType())
            {
                CrearCabecera(tabla);
                System.Console.WriteLine("El tipo de dato no era igual al dato modelo, se cambio la cabecera");
            }
            String[] datosCliente = [IdCliente.ToString(),DniCliente.ToString(),NombreCliente,ApellidoCliente,Telefono];
            tabla.Rows.Add(datosCliente);
            
        }

        public override void CrearCabecera(DataGridViewEstandar tabla)
        {
            tabla.Columns.Clear();
            tabla.Rows.Clear();
            tabla.Columns.Add("id","Id");
            tabla.Columns.Add("dni", "DNI");
            tabla.Columns.Add("nombre", "Nombre");
            tabla.Columns.Add("apellido", "Apellido");
            tabla.Columns.Add("telefono", "Telefono");
        }
    }
}
