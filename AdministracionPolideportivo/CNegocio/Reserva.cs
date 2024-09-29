using AdministracionPolideportivo.CPresentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class Reserva : EntidadDataGridView
    {
        public Reserva(int reservaP, Recinto recintoP, Cliente clienteP, DateOnly fecha, TimeOnly hora)
        {
            this.idReserva = reservaP;
            this.recinto = recintoP;
            this.cliente = clienteP;
            Fecha = fecha;
            Hora = hora;
        }

        public int idReserva {  get; set; }
        public Recinto recinto { get; set; }

        public Cliente cliente { get; set; }

        public DateOnly Fecha { get; set; }

        public TimeOnly Hora { get; set; }

        public override void CargarEnTabla(AdministracionPolideportivo.CPresentacion.DataGridViewEstandar tabla)
        {
            if (tabla.getDatoModelo().GetType() != this.GetType())
            {
                tabla.setDatoModelo(this);
                System.Console.WriteLine("El tipo de dato no era igual al dato modelo, se cambio la cabecera");
            }
            String[] datosCliente = [idReserva.ToString(), cliente.NombreCliente,recinto.NroRecinto.ToString(),Fecha.ToString()+Hora.ToString()];
            tabla.Rows.Add(datosCliente);

        }

        public override void CrearCabecera(DataGridViewEstandar tabla)
        {
            tabla.Columns.Clear();
            tabla.Rows.Clear();
            tabla.Columns.Add("idReserva", "Id");
            tabla.Columns.Add("cliente", "Cliente");
            tabla.Columns.Add("recinto", "Recinto");
            tabla.Columns.Add("fecha", "Fecha");
        }

    }
}
