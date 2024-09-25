using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class ServicioAdicional
    {
        public ServicioAdicional(int idServicio, string nombreServicio,
            string descripcionServicio, double precio)
        {
            IdServicio = idServicio;
            NombreServicio = nombreServicio;
            DescripcionServicio = descripcionServicio;
            Precio = precio;
        }

        public int IdServicio { get; set; }

        public String NombreServicio { get; set; } = null!;

        public String DescripcionServicio { get; set; } 

        public double Precio { get; set; }

    

    }
}
