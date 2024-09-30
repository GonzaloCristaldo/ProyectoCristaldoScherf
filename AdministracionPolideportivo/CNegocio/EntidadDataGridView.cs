using AdministracionPolideportivo.CPresentacion.Recepcionista;
using AdministracionPolideportivo.CPresentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CNegocio
{
    public abstract class EntidadDataGridView
    {

        public abstract void CargarEnTabla(TablaDatos tabla);
        public abstract void CrearCabecera(TablaDatos tabla);

    }
}
