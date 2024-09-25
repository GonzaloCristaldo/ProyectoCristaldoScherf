using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class Recinto
    {
        public Recinto(int nroRecinto, double tarifaHora, int idEstado, int idTipoRecinto, string ubicacion)
        {
            NroRecinto = nroRecinto;
            TarifaHora = tarifaHora;
            IdEstado = idEstado;
            IdTipoRecinto = idTipoRecinto;
            Ubicacion = ubicacion;
        }

        public int NroRecinto { get; set; }

        public double TarifaHora { get; set; }

        public int IdEstado { get; set; }

        public int IdTipoRecinto { get; set; }

        public String Ubicacion { get; set; }


    }
}
