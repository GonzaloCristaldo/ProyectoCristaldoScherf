using AdministracionPolideportivo.CPresentacion.Recepcionista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionPolideportivo.CPresentacion;

namespace AdministracionPolideportivo.CNegocio
{
    internal class Usuario : EntidadDataGridView
    {
        public Usuario(string nombreUsuario, string apellidoUsuario, TipoUsuario tipoUsuario, string passUsuario, int dniUsuario, DateTime fechaNacimiento, DateTime fechaIngreso, string telefono, byte[] foto,string sexo)
        {
            this.nombreUsuario = nombreUsuario;
            this.apellidoUsuario = apellidoUsuario;
            this.tipoUsuario = tipoUsuario;
            this.passUsuario = passUsuario;
            DniUsuario = dniUsuario;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaIngreso = fechaIngreso;
            Telefono = telefono;
            this.pass = pass;
            this.foto = foto;
            this.sexo = sexo;
        }

        public Usuario(int idUsuario, string nombreUsuario, string apellidoUsuario, TipoUsuario tipoUsuario, string passUsuario, int dniUsuario, DateTime fechaNacimiento, DateTime fechaIngreso, string telefono, byte[] foto, String sexo)
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.apellidoUsuario = apellidoUsuario;
            this.tipoUsuario = tipoUsuario;
            this.passUsuario = passUsuario;
            DniUsuario = dniUsuario;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaIngreso = fechaIngreso;
            Telefono = telefono;
            this.pass = pass;
            this.foto = foto;
            this.sexo = sexo;
        }

        public Usuario()
        {

        }

        public String sexo {  get; set; }
        public int idUsuario {  get; set; }
        public string nombreUsuario { get; set; }
        public string apellidoUsuario { get; set; }

        public TipoUsuario tipoUsuario { get; set; }

        private String passUsuario { get; set; }

        public int DniUsuario { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaIngreso {  get; set; }

        public String Telefono {  get; set; }

        public String pass {  get; set; }

        public byte[] foto { get; set; }

        public static void EditarEntidad(Usuario usuario)
        {
            agregarUsuario popUp = new agregarUsuario();
            popUp.TopLevel = true;
            popUp.FormBorderStyle = FormBorderStyle.FixedSingle;
            popUp.txtDNI.Text = usuario.DniUsuario.ToString();
            popUp.txtNombre.Text = usuario.nombreUsuario.ToString();
            popUp.txtApellido.Text = usuario.apellidoUsuario.ToString();
            popUp.txtTelefono.Text = usuario.Telefono.ToString();
            popUp.cbSexo.Text = "Masculino";
            popUp.cbTipo.Text = usuario.tipoUsuario.NombreTipoUsuario;
            //TODO agregar imagen (foto del usuario) desde la db al picturebox
            popUp.ShowDialog();
        }

        public override void CargarEnTabla(TablaDatos tabla)
        {
            if (tabla.getDatoModelo().GetType() != this.GetType())
            {
                tabla.setDatoModelo(this);
                System.Console.WriteLine("El tipo de dato no era igual al dato modelo, se cambio la cabecera");
            }
            String[] datosUsuario = [idUsuario.ToString(), nombreUsuario, apellidoUsuario,DniUsuario.ToString(),
            Telefono,tipoUsuario.NombreTipoUsuario,fechaIngreso.ToString(),fechaNacimiento.ToString()];
            tabla.Rows.Add(datosUsuario);
            TablaBoton boton = new TablaBoton(this);
            int filaBoton = tabla.RowCount - 1;
            tabla.Rows[filaBoton].Cells[datosUsuario.Length] = boton;

            void clickeado(Object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex == filaBoton && e.ColumnIndex == datosUsuario.Length)
                {
                    EditarEntidad(this);
                }

            }
            tabla.CellContentClick += clickeado;

        }

        public override void CrearCabecera(TablaDatos tabla)
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
            tabla.Columns.Add("editar","Modificar");
        }

    }
}
