using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    internal abstract class EntidadDataGridView
    {

        public abstract void CargarEnTabla(AdministracionPolideportivo.CPresentacion.DataGridViewEstandar tabla);
        public abstract void CrearCabecera(AdministracionPolideportivo.CPresentacion.DataGridViewEstandar tabla);

    }
}
