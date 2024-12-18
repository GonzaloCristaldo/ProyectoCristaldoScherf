﻿using AdministracionPolideportivo.CNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion.Recepcionista
{
    internal class vistaRecepcionista : VentanaMenu
    {
        private void cerrarForm(object sender, EventArgs e)
        {


            var confirmResult = MessageBox.Show("¿Estas seguro que deseas cerrar sesión?",
                                     "Confirmar cierre de sesion",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (confirmResult == DialogResult.Yes)
            {
                this.Hide();
                Login log = new Login();
                log.Show();
            }

        }

        Usuario usuario;

        public vistaRecepcionista(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            contadorOpciones = 0;
            //tablaOpciones.Width = panelOpciones.Width;
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            AgregarBotonOpcion(new BotonOpcion(new AgregarRecinto(), this, formActual, "Agregar Recinto"));
            AgregarBotonOpcion(new BotonOpcion(new AgregarServicioAdicional(), this, formActual, "Agregar Servicio Adicional"));
            AgregarBotonOpcion(new BotonOpcion(new AgregarCliente(), this, formActual, "Agregar Cliente"));
            AgregarBotonOpcion(new BotonOpcion(new BuscarCliente(), this, formActual, "Buscar Cliente"));
            AgregarBotonOpcion(new BotonOpcion(new BuscarRecinto(), this, formActual, "Buscar Recinto"));
            AgregarBotonOpcion(new BotonOpcion(new ProgramarReserva(user.idUsuario), this, formActual, "Programar Nueva Reserva"));
            AgregarBotonOpcion(new BotonOpcion(new BuscarReserva(), this, formActual, "Buscar Reserva"));
            AgregarBotonOpcion(new BotonOpcion(new ListarPagos(),this,formActual,"Listar Pagos"));
            AgregarBotonOpcion(new BotonOpcion(new CobrarReserva(user), this, formActual, "Cobrar Reserva"));
            BotonOpcion btnSalirSesion = new BotonOpcion(new FormularioEstandar(), this, formActual, "Cerrar Sesion");
            btnSalirSesion.Click += cerrarForm;
            AgregarBotonOpcion(btnSalirSesion);
        }

        private void InitializeComponent()
        {
            tablaOpciones = new TableLayoutPanel();
            labelFormulario1 = new LabelFormulario();
            btnCerrar = new Button();
            btnMinimizar = new Button();
            panelNavegacion.SuspendLayout();
            panelOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavegacion
            // 
            panelNavegacion.Controls.Add(btnMinimizar);
            panelNavegacion.Controls.Add(btnCerrar);
            panelNavegacion.Controls.Add(labelFormulario1);
            panelNavegacion.Size = new Size(990, 34);
            // 
            // panelOpciones
            // 
            panelOpciones.AutoScroll = true;
            panelOpciones.Controls.Add(tablaOpciones);
            panelOpciones.Size = new Size(226, 656);
            // 
            // panelFormulario
            // 
            panelFormulario.Size = new Size(764, 656);
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
            // btnCerrar
            // 
            btnCerrar.Location = new Point(960, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(27, 24);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Location = new Point(929, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 24);
            btnMinimizar.TabIndex = 8;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // vistaRecepcionista
            // 
            ClientSize = new Size(1000, 700);
            Name = "vistaRecepcionista";
            panelNavegacion.ResumeLayout(false);
            panelNavegacion.PerformLayout();
            panelOpciones.ResumeLayout(false);
            panelOpciones.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tablaOpciones;
        private LabelFormulario labelFormulario1;
        private Button btnCerrar;
        private Button btnMinimizar;
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           System.Windows.Forms.Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
