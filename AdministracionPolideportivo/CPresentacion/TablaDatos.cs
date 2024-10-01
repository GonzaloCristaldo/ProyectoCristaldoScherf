using AdministracionPolideportivo.CNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    public class TablaDatos : DataGridView
    {

        EntidadDataGridView datoModelo;

        public TablaDatos()
        {

        }

        public TablaDatos(EntidadDataGridView datoModeloP)
        {
            setDatoModelo(datoModeloP);
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void setDatoModelo(EntidadDataGridView datoModeloP)
        {
            datoModelo = datoModeloP;
            datoModelo.CrearCabecera(this);
        }

        public EntidadDataGridView getDatoModelo()
        {
            return datoModelo;
        }

        public void AgregarEntidad(EntidadDataGridView entidad)
        {
            entidad.CargarEnTabla(this);
        }

    }
}
