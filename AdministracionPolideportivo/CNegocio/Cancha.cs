using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class Cancha
    {

        public int NroCancha { get; set; }

        public double TarifaHora { get; set; }

        public int IdEstado { get; set; }

        public int IdTipoCancha { get; set; }

        public String Ubicacion { get; set; }


        public Cancha( int nroCancha, double tarifaHora, int idEstado, int idTipoCancha, string ubicacion)
        {
            
            NroCancha = nroCancha;
            TarifaHora = tarifaHora;
            IdEstado = idEstado;
            IdTipoCancha = idTipoCancha;
            Ubicacion = ubicacion;
        }
    }
}
