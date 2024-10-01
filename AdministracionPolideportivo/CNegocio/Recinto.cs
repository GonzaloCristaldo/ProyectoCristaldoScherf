using AdministracionPolideportivo.CPresentacion.Recepcionista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionPolideportivo.CPresentacion;

namespace AdministracionPolideportivo.CNegocio
{
    internal class Recinto : EntidadDataGridView
    {
        public static void EditarEntidad(Recinto recinto)
        {
            AgregarRecinto popUp = new AgregarRecinto();
            popUp.TopLevel = true;
            popUp.FormBorderStyle = FormBorderStyle.FixedSingle;
            popUp.txtNumCancha.Text = recinto.NroRecinto.ToString();
            popUp.txtTarifa.Text = recinto.TarifaHora.ToString();
            popUp.txtUbicacion.Text = recinto.Ubicacion;
            popUp.cbTipo.Text = recinto.tipoRecinto.nombre;
            popUp.ShowDialog();
        }

        public Recinto(int nroRecinto, double tarifaHora, Estado estadoP, TipoRecinto tipoRecintoP, string ubicacion)
        {
            NroRecinto = nroRecinto;
            TarifaHora = tarifaHora;
            estado = estadoP;
            tipoRecinto = tipoRecintoP;
            Ubicacion = ubicacion;
        }

        public Recinto()
        {
            NroRecinto = -1;
            TarifaHora = 0;
            estado = new Estado();
            tipoRecinto = new TipoRecinto();
            Ubicacion = "";
        }
        public int NroRecinto { get; set; }

        public double TarifaHora { get; set; }

        public Estado estado { get; set; }

        public TipoRecinto tipoRecinto { get; set; }

        public String Ubicacion { get; set; }

        public override void CargarEnTabla(TablaDatos tabla)
        {
            if (tabla.getDatoModelo().GetType() != this.GetType())
            {
                tabla.setDatoModelo(this);
                System.Console.WriteLine("El tipo de dato no era igual al dato modelo, se cambio la cabecera");
            }
            String[] datosRecinto = [NroRecinto.ToString(), TarifaHora.ToString(), tipoRecinto.nombre.ToString(), Ubicacion, estado.nombre.ToString()];
            tabla.Rows.Add(datosRecinto);
            TablaBoton boton = new TablaBoton(this);
            int filaBoton = tabla.RowCount - 2;
            tabla.Rows[filaBoton].Cells[datosRecinto.Length] = boton;

            void clickeado(Object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex == filaBoton && e.ColumnIndex == datosRecinto.Length)
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
            tabla.Columns.Add("numero", "Recinto N°");
            tabla.Columns.Add("tarifa", "Tarifa");
            tabla.Columns.Add("tipo", "Tipo");
            tabla.Columns.Add("ubicacion", "Ubicación");
            tabla.Columns.Add("estado", "Estado");
            tabla.Columns.Add("modificar","Editar");
        }

    }
}
