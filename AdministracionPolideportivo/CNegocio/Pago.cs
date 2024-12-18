﻿using AdministracionPolideportivo.CPresentacion.Recepcionista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionPolideportivo.CPresentacion;

namespace AdministracionPolideportivo.CNegocio
{
    internal class Pago : EntidadDataGridView
    {

        public static void EditarEntidad(Pago pago)
        {
            //TODO
        }
        public Pago(int idPago, Reserva reserva,Usuario usuarioP,MedioPago med, int precio)
        {
            this.idPago = idPago;
            this.reserva = reserva;
            usuario= usuarioP;
            medio = med;
            monto = precio;
        }

        public int idPago {  get; set; }
        public Reserva reserva {  get; set; }

        public Usuario usuario { get; set; }

        public MedioPago medio { get; set; }
        public int monto { get; set; }

        public override void CargarEnTabla(TablaDatos tabla)
        {
            if (tabla.getDatoModelo().GetType() != this.GetType())
            {
                tabla.setDatoModelo(this);
                System.Console.WriteLine("El tipo de dato no era igual al dato modelo, se cambio la cabecera");
            }
            String[] datosPago = [idPago.ToString(), reserva.idReserva.ToString()];
            tabla.Rows.Add(datosPago);

            TablaBoton boton = new TablaBoton(this);
            int filaBoton = tabla.RowCount - 2;
            tabla.Rows[filaBoton].Cells[datosPago.Length] = boton;

            void clickeado(Object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex == filaBoton && e.ColumnIndex == datosPago.Length)
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
        }



    }
}
