using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CDatos
{
    internal class Cancha
    {

        private int anchoMts;
        private int largoMts;
        private int idCancha;
        private int tarifaHora;
        private String ubicacion;
        private String estadoCesped;
        private String tipoCesped;
        private String tipoIluminacion;



        
        public Cancha() { }

        public Cancha(int anchoMts, int largoMts, int idCancha, int precioHora, string ubicacion, string estadoCesped, string tipoCesped, string tipoIluminacion)
        {
            AnchoMts = anchoMts;
            LargoMts = largoMts;
            IdCancha = idCancha;
            TarifaHora = precioHora;
            Ubicacion = ubicacion;
            EstadoCesped = estadoCesped;
            TipoCesped = tipoCesped;
            TipoIluminacion = tipoIluminacion;
        }

        public int AnchoMts { get => anchoMts; set => anchoMts = value; }
        public int LargoMts { get => largoMts; set => largoMts = value; }
        public int IdCancha { get => idCancha; set => idCancha = value; }
        public int TarifaHora { get => tarifaHora; set => tarifaHora = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string EstadoCesped { get => estadoCesped; set => estadoCesped = value; }
        public string TipoCesped { get => tipoCesped; set => tipoCesped = value; }
        public string TipoIluminacion { get => tipoIluminacion; set => tipoIluminacion = value; }
    }
}
