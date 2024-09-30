﻿using System;
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


            AgregarBotonOpcion(new BotonOpcion(new AgregarRecinto(), this, formActual, "Agregar Recinto"));
            AgregarBotonOpcion(new BotonOpcion(new AgregarServicioAdicional(), this, formActual, "Agregar Servicio Adicional"));
            AgregarBotonOpcion(new BotonOpcion(new AgregarCliente(), this, formActual, "Agregar Cliente"));
            AgregarBotonOpcion(new BotonOpcion(new BuscarCliente(), this, formActual, "Buscar Cliente"));
            AgregarBotonOpcion(new BotonOpcion(new BuscarRecinto(), this, formActual, "Buscar Recinto"));
            AgregarBotonOpcion(new BotonOpcion(new ProgramarReserva(), this, formActual, "Programar Nueva Reserva"));
            AgregarBotonOpcion(new BotonOpcion(new BuscarReserva(), this, formActual, "Buscar Reserva"));
        }

        private void InitializeComponent()
        {
            tablaOpciones = new TableLayoutPanel();
            labelFormulario1 = new LabelFormulario();
            panelNavegacion.SuspendLayout();
            panelOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavegacion
            // 
            panelNavegacion.Controls.Add(labelFormulario1);
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
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.Font = new Font("Segoe UI", 18F);
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(19, 0);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(159, 32);
            labelFormulario1.TabIndex = 0;
            labelFormulario1.Text = "Recepcionista";
            // 
            // vistaRecepcionista
            // 
            ClientSize = new Size(1100, 720);
            Name = "vistaRecepcionista";
            panelNavegacion.ResumeLayout(false);
            panelNavegacion.PerformLayout();
            panelOpciones.ResumeLayout(false);
            panelOpciones.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tablaOpciones;
        private LabelFormulario labelFormulario1;
        private int contadorOpciones;

        private void AgregarBotonOpcion(BotonOpcion nuevoBoton)
        {
            /*Se agrega el boton a la tabla de opciones, en la primer columna
            (0) y en la fila correspondiente al contador*/
            tablaOpciones.Controls.Add(nuevoBoton, 0, contadorOpciones);
            //Se actualiza el contador
            contadorOpciones++;
            //Se agrega la opcion al array definido en la superclase
            agregarOpcion(nuevoBoton);
        }

    }
}
