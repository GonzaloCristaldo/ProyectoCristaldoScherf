using AdministracionPolideportivo.CPresentacion.Recepcionista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionPolideportivo.CPresentacion;


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
        public Cliente()
        {

            IdCliente = 123;
            DniCliente = 213;
            NombreCliente = "nombreCliente";
            ApellidoCliente = "apellidoCliente";
            Telefono = "";
        }

        public Cliente(int dniCliente, string nombreCliente, string apellidoCliente, string telefono)
        {

            DniCliente = dniCliente;
            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;
            Telefono = telefono;
        }

        public int IdCliente { get; set; }
        public long DniCliente { get; set; }
        public string NombreCliente { get; set; } = null!;
        public string ApellidoCliente { get; set; } = null!;
        public string Telefono { get; set; } = null!;

        public static void EditarEntidad(Cliente cliente)
        {
           
                AgregarCliente popUp = new AgregarCliente(true, cliente.IdCliente);
                popUp.TopLevel = true;
                popUp.FormBorderStyle = FormBorderStyle.FixedSingle;
                popUp.txtDNI.Text = cliente.DniCliente.ToString();
                popUp.txtNombre.Text = cliente.NombreCliente.ToString();
                popUp.txtApellido.Text = cliente.ApellidoCliente.ToString();
                popUp.txtTelefono.Text = cliente.Telefono.ToString();
                //popUp.idCliente= cliente.IdCliente;
                popUp.ShowDialog();

            
            
        }
        Object[] datosCliente;
        int filaBoton;
        void clickeado(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == filaBoton && e.ColumnIndex == datosCliente.Length)
            {
                EditarEntidad(this);
            }

        }
        public override void CargarEnTabla(TablaDatos tabla)
        {
            if (tabla.getDatoModelo().GetType()!=this.GetType())
            {
                tabla.setDatoModelo(this);
                System.Console.WriteLine("El tipo de dato no era igual al dato modelo, se cambio la cabecera");
            }
            
            datosCliente = [IdCliente.ToString(),DniCliente.ToString(),NombreCliente,ApellidoCliente,Telefono];
            tabla.Rows.Add(datosCliente);
            TablaBoton boton = new TablaBoton(this);
            filaBoton = tabla.RowCount - 2;
            tabla.Rows[filaBoton].Cells[datosCliente.Length] = boton;

            
            tabla.CellContentClick += clickeado;
        }


        public override void CrearCabecera(TablaDatos tabla)
        {
            tabla.Columns.Clear();
            tabla.Rows.Clear();
            tabla.Columns.Add("id","Id");
            tabla.Columns.Add("dni", "DNI");
            tabla.Columns.Add("nombre", "Nombre");
            tabla.Columns.Add("apellido", "Apellido");
            tabla.Columns.Add("telefono", "Telefono");
            tabla.Columns.Add("modificar", "Modificar");
        }

        public override string ToString()
        {
            return this.IdCliente+". "+this.NombreCliente + " " +this.ApellidoCliente;
        }

    }
}
