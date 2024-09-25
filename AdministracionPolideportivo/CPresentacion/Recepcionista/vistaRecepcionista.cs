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
            //tablaOpciones.Width = panelOpciones.Width;
            

            AgregarBotonOpcion(new BotonOpcion(new AgregarCancha(),this,formActual, "Agregar Cancha"));
            AgregarBotonOpcion(new BotonOpcion(new AgregarServicioAdicional(), this, formActual, "Agregar Servicio Adicional"));
            AgregarBotonOpcion(new BotonOpcion(new AgregarCliente(), this, formActual, "Agregar Cliente"));
            AgregarBotonOpcion(new BotonOpcion(new BuscarCliente(), this, formActual, "Buscar Cliente"));
            AgregarBotonOpcion(new BotonOpcion(new BuscarCancha(), this, formActual, "Buscar Cancha"));
            AgregarBotonOpcion(new BotonOpcion(new ProgramarPartido(), this, formActual, "Programar Nuevo Partido"));
        }

        private void InitializeComponent()
        {
            tablaOpciones = new TableLayoutPanel();
            panelOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // panelOpciones
            // 
            panelOpciones.AutoScroll = true;
            panelOpciones.Controls.Add(tablaOpciones);
            // 
            // tablaOpciones
            // 
            tablaOpciones.AutoSize = true;
            tablaOpciones.ColumnCount = 1;
            tablaOpciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablaOpciones.Dock = DockStyle.Top;
            tablaOpciones.Location = new Point(0, 0);
            tablaOpciones.Name = "tablaOpciones";
            tablaOpciones.RowCount = 1;
            tablaOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablaOpciones.Size = new Size(226, 0);
            tablaOpciones.TabIndex = 0;
            // 
            // vistaRecepcionista
            // 
            ClientSize = new Size(694, 450);
            Name = "vistaRecepcionista";
            panelOpciones.ResumeLayout(false);
            panelOpciones.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tablaOpciones;
        private int contadorOpciones;

        private void AgregarBotonOpcion(BotonOpcion nuevoBoton)
        {
            /*Se agrega el boton a la tabla de opciones, en la primer columna
            (0) y en la fila correspondiente al contador*/
            tablaOpciones.Controls.Add(nuevoBoton,0,contadorOpciones);

            //Se actualiza el contador
            contadorOpciones++;

            //Se agrega una fila a la tabla
            //tablaOpciones.RowCount++;

            //Se redimensiona el panel
            //tablaOpciones.Height = contadorOpciones * 80;

            

            //Se agrega la opcion al array definido en la superclase
            agregarOpcion(nuevoBoton);

            
        }

    }
}
