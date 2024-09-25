using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class Cancha
    {

        public int IdCancha { get; set; }

        public int NroCancha { get; set; }

        public double TarifaHora { get; set; }

        public int IdEstado { get; set; }

        public int IdTipoCancha { get; set; }

        public String Ubicacion { get; set; }



        /*
    public int IdTipoHab { get; set; }

    public int IdPiso { get; set; }

    public virtual EstadoHabitacion IdEstadoNavigation { get; set; } = null!;

    public virtual Piso IdPisoNavigation { get; set; } = null!;

    public virtual TipoHabitacion IdTipoHabNavigation { get; set; } = null!;

    public virtual ICollection<Registro> Registros { get; set; } = new List<Registro>();
         */

        public Cancha(int idCancha, int nroCancha, double tarifaHora, int idEstado, int idTipoCancha, string ubicacion)
        {
            IdCancha = idCancha;
            NroCancha = nroCancha;
            TarifaHora = tarifaHora;
            IdEstado = idEstado;
            IdTipoCancha = idTipoCancha;
            Ubicacion = ubicacion;
        }
    }
}
