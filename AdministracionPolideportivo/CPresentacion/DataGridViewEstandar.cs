using AdministracionPolideportivo.CNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class DataGridViewEstandar : DataGridView
    {
        EntidadDataGridView datoModelo;

        public DataGridViewEstandar(EntidadDataGridView datoModeloP)
        {
            InitializeComponent();
            setDatoModelo(datoModeloP);
        }
        /*public DataGridViewEstandar()
        {
            InitializeComponent();
            //setDatoModelo();
        }*/

        public void InitializeComponent()
        {

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
