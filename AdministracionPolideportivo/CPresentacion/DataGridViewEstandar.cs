using AdministracionPolideportivo.CNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion.Recepcionista
{
    public class DataGridViewEstandar : DataGridView
    {
        EntidadDataGridView datoModelo;

        public DataGridViewEstandar(EntidadDataGridView datoModeloP)
        {
            setDatoModelo(datoModeloP);
        }

        public void setDatoModelo(EntidadDataGridView datoModeloP)
        {
            datoModelo = datoModeloP;
            //datoModelo.CrearCabecera(this);
        }

        public EntidadDataGridView getDatoModelo()
        {
            return datoModelo;
        }

        public void AgregarEntidad(EntidadDataGridView entidad)
        {
            //entidad.CargarEnTabla(this);
        }

        public static void RemoveCellContentClickHandlers(DataGridView tabla)
        {
            // Access the private event handler list for the DataGridView
            FieldInfo fi = typeof(DataGridView).GetField("EventCellContentClick", BindingFlags.Static | BindingFlags.NonPublic);

            if (fi != null)
            {
                object clickEventKey = fi.GetValue(tabla);

                // Get the list of event handlers associated with the DataGridView
                PropertyInfo eventsProp = typeof(Control).GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance);
                EventHandlerList eventList = (EventHandlerList)eventsProp.GetValue(tabla);

                // Remove the CellContentClick event handlers
                eventList.RemoveHandler(clickEventKey, eventList[clickEventKey]);
            }
        }

    }
}
