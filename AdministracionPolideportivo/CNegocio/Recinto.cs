using AdministracionPolideportivo.CPresentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class Recinto : EntidadDataGridView
    {
        public Recinto(int nroRecinto, double tarifaHora, Estado estadoP, TipoRecinto tipoRecintoP, string ubicacion)
        {
            NroRecinto = nroRecinto;
            TarifaHora = tarifaHora;
            estado = estadoP;
            tipoRecinto = tipoRecintoP;
            Ubicacion = ubicacion;
        }

        public int NroRecinto { get; set; }

        public double TarifaHora { get; set; }

        public Estado estado { get; set; }

        public TipoRecinto tipoRecinto { get; set; }

        public String Ubicacion { get; set; }

        public override void CargarEnTabla(AdministracionPolideportivo.CPresentacion.DataGridViewEstandar tabla)
        {
            if (tabla.getDatoModelo().GetType() != this.GetType())
            {
                tabla.setDatoModelo(this);
                System.Console.WriteLine("El tipo de dato no era igual al dato modelo, se cambio la cabecera");
            }
            String[] datosRecinto = [NroRecinto.ToString(), TarifaHora.ToString(), tipoRecinto.nombre.ToString(), Ubicacion, estado.nombre.ToString()];
            tabla.Rows.Add(datosRecinto);

        }

        public override void CrearCabecera(DataGridViewEstandar tabla)
        {
            tabla.Columns.Clear();
            tabla.Rows.Clear();
            tabla.Columns.Add("numero", "Recinto N°");
            tabla.Columns.Add("tarifa", "Tarifa");
            tabla.Columns.Add("tipo", "Tipo");
            tabla.Columns.Add("ubicacion", "Ubicación");
            tabla.Columns.Add("estado", "Estado");
        }

    }
}
