using AdministracionPolideportivo.CPresentacion.Recepcionista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionPolideportivo.CPresentacion;
using System.Runtime.CompilerServices;

namespace AdministracionPolideportivo.CNegocio
{
    internal class Reserva : EntidadDataGridView
    {
        public Reserva(int idReservaP, Recinto recintoP, Cliente clienteP, DateOnly fecha, TimeOnly hora, Usuario user)
        {
            this.idReserva = idReservaP;
            this.recinto = recintoP;
            this.cliente = clienteP;
            Fecha = fecha;
            Hora = hora;
            this.usuario = user;
        }

        

        public int idReserva {  get; set; }
        public Recinto recinto { get; set; }

        public Usuario usuario {  get; set; }

        public Cliente cliente { get; set; }

        public DateOnly Fecha { get; set; }

        public TimeOnly Hora { get; set; }

        public static void EditarEntidad(Reserva reserva)
        {
            VerDetalle popUp = new VerDetalle();
            popUp.TopLevel = true;
            popUp.FormBorderStyle = FormBorderStyle.FixedSingle;
            popUp.tabla.setDatoModelo(new ServicioAdicional(1, "", "", 0.1m));
            popUp.lblDetalle.Text = "Servicios adicionales de la reserva N° " + reserva.idReserva;
            //TODO
            //cargar datos dinamicamente a la tabla


            popUp.ShowDialog();
        }
        public override void CargarEnTabla(TablaDatos tabla)
        {
            if (tabla.getDatoModelo().GetType() != this.GetType())
            {
                tabla.setDatoModelo(this);
                System.Console.WriteLine("El tipo de dato no era igual al dato modelo, se cambio la cabecera");
            }
            String[] datosReserva = [idReserva.ToString(), cliente.NombreCliente,recinto.NroRecinto.ToString(),Fecha.ToString()+Hora.ToString()];
            tabla.Rows.Add(datosReserva);

            TablaBoton boton = new TablaBoton(this);
            int filaBoton = tabla.RowCount - 2;
            tabla.Rows[filaBoton].Cells[datosReserva.Length] = boton;

            void clickeado(Object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex == filaBoton && e.ColumnIndex == datosReserva.Length)
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
            tabla.Columns.Add("idReserva", "Id");
            tabla.Columns.Add("cliente", "Cliente");
            tabla.Columns.Add("recinto", "Recinto");
            tabla.Columns.Add("fecha", "Fecha");
            tabla.Columns.Add("detalle","Adicionales");
        }

    }
}
