using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion.Recepcionista
{
    internal class vistaRecepcionista : VentanaMenu
    {
        public vistaRecepcionista()
        {
            InitializeComponent();
            contadorOpciones = 0;
            tablaOpciones.Width = panelOpciones.Width;
            

            AgregarOpcion(new BotonOpcion(new AgregarCancha(),this,formActual, "Agregar Cancha"));
            AgregarOpcion(new BotonOpcion(new AgregarServicioAdicional(), this, formActual, "Agregar Servicio Adicional"));

        }

        private void InitializeComponent()
        {
            tablaOpciones = new TableLayoutPanel();
            panelOpciones.SuspendLayout();
            tablaOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // panelOpciones
            // 
            panelOpciones.Controls.Add(tablaOpciones);
            // 
            // tablaOpciones
            // 
            tablaOpciones.ColumnCount = 1;
            tablaOpciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablaOpciones.Location = new Point(0, 0);
            tablaOpciones.Name = "tablaOpciones";
            tablaOpciones.RowCount = 5;
            /*tablaOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablaOpciones.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tablaOpciones.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tablaOpciones.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tablaOpciones.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));*/
            tablaOpciones.Size = new Size(200, 298);
            tablaOpciones.TabIndex = 0;
            // 
            // vistaRecepcionista
            // 
            ClientSize = new Size(694, 450);
            Name = "vistaRecepcionista";
            panelOpciones.ResumeLayout(false);
            tablaOpciones.ResumeLayout(false);
            ResumeLayout(false);
        }

        private BotonOpcion opcionAgregarCancha;
        private BotonOpcion botonOpcion2;
        private BotonOpcion botonOpcion3;
        private BotonOpcion botonOpcion4;
        private BotonOpcion botonOpcion5;

        private int contadorOpciones;
        
       
        private TableLayoutPanel tablaOpciones;

        private void AgregarOpcion(BotonOpcion nuevoBoton)
        {
            /*Se agrega el boton a la tabla de opciones, en la primer columna
            (0) y en la fila correspondiente al contador*/
            tablaOpciones.Controls.Add(nuevoBoton,0,contadorOpciones);

            //Se actualiza el contador
            contadorOpciones++;

            //Se redimensiona el panel
            tablaOpciones.Height = tablaOpciones.RowCount * 80;

            //Se agrega una fila a la tabla
            tablaOpciones.RowCount++;

            //Se agrega la opcion al array definido en la superclase
            agregarOpcion(nuevoBoton);

            
        }

    }
}
