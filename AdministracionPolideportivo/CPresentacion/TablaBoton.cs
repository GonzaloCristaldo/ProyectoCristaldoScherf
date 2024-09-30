using AdministracionPolideportivo.CNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class TablaBoton : DataGridViewButtonCell
    {
        EntidadDataGridView entidad;

        public TablaBoton(EntidadDataGridView entidad)
        {
            this.entidad = entidad;
            //this.UseColumnTextForButtonValue = true;
            this.Value = "Editar";
           
        }
        
        public void EditarEntidad()
        {

        }
    }
}
