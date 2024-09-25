using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal class Cliente
    {
        public Cliente(int idCliente, int dniCliente, string nombreCliente, string apellidoCliente, string telefono)
        {
            IdCliente = idCliente;
            DniCliente = dniCliente;
            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;
            Telefono = telefono;
        }

        public int IdCliente { get; set; }
        public int DniCliente { get; set; }
        public string NombreCliente { get; set; } = null!;
        public string ApellidoCliente { get; set; } = null!;
        public string Telefono { get; set; } = null!;



    }
}
