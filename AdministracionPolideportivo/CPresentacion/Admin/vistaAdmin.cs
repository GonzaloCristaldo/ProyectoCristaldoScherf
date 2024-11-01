using AdministracionPolideportivo.CNegocio;
using AdministracionPolideportivo.CPresentacion.Recepcionista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion.Admin

{
    internal class VistaAdmin : VentanaMenu
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

        public VistaAdmin(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            contadorOpciones = 0;
            //tablaOpciones.Width = panelOpciones.Width;

            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            AgregarBotonOpcion(new BotonOpcion(new listarClienteCheckIn_Out(), this, formActual, "CheckIN/CheckOut"));
            AgregarBotonOpcion(new BotonOpcion(new agregarUsuario(), this, formActual, "Agregar Recepcionista"));
            AgregarBotonOpcion(new BotonOpcion(new AgregarRecinto(), this, formActual, "Agregar Recinto"));
            AgregarBotonOpcion(new BotonOpcion(new AgregarServicioAdicional(), this, formActual, "Agregar Servicio Adicional"));
            AgregarBotonOpcion(new BotonOpcion(new AgregarCliente(), this, formActual, "Agregar Cliente"));
            AgregarBotonOpcion(new BotonOpcion(new BuscarCliente(), this, formActual, "Buscar Cliente"));
            AgregarBotonOpcion(new BotonOpcion(new BuscarRecinto(), this, formActual, "Buscar Recinto"));
            AgregarBotonOpcion(new BotonOpcion(new ProgramarReserva(), this, formActual, "Programar Nueva Reserva"));
            AgregarBotonOpcion(new BotonOpcion(new BuscarReserva(), this, formActual, "Buscar Reserva"));
            AgregarBotonOpcion(new BotonOpcion(new Estadisticas(), this, formActual, "Ver estadisticas"));
            AgregarBotonOpcion(new BotonOpcion(new BuscarUsuario(), this, formActual, "Buscar Usuario"));
            BotonOpcion btnSalirSesion = new BotonOpcion(new AgregarCliente(), this, formActual, "Cerrar Sesion"); ;
            btnSalirSesion.Click += cerrarForm;
            AgregarBotonOpcion(btnSalirSesion);
        }
        private void InitializeComponent()
        {
            tablaOpciones = new TableLayoutPanel();
            btnCerrar = new Button();
            btnMinimizar = new Button();
            labelFormulario1 = new LabelFormulario();
            panelNavegacion.SuspendLayout();
            panelOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavegacion
            // 
            panelNavegacion.Controls.Add(labelFormulario1);
            panelNavegacion.Controls.Add(btnMinimizar);
            panelNavegacion.Controls.Add(btnCerrar);
            // 
            // panelOpciones
            // 
            panelOpciones.AutoScroll = true;
            panelOpciones.Controls.Add(tablaOpciones);
            panelOpciones.Size = new Size(226, 506);
            // 
            // panelFormulario
            // 
            panelFormulario.AutoScroll = true;
            panelFormulario.Size = new Size(864, 506);
            panelFormulario.Paint += panelFormulario_Paint;
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
            // btnCerrar
            // 
            btnCerrar.Location = new Point(1060, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(27, 24);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Location = new Point(1029, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 24);
            btnMinimizar.TabIndex = 7;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.Font = new Font("Segoe UI", 18F);
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(14, -1);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(164, 32);
            labelFormulario1.TabIndex = 8;
            labelFormulario1.Text = "Administrador";
            // 
            // VistaAdmin
            // 
            ClientSize = new Size(1100, 550);
            Name = "VistaAdmin";
            panelNavegacion.ResumeLayout(false);
            panelNavegacion.PerformLayout();
            panelOpciones.ResumeLayout(false);
            panelOpciones.PerformLayout();
            ResumeLayout(false);
        }

        private Button button1;
        private Button button2;
        private Button btnCerrar;
        private Button btnMinimizar;
        private LabelFormulario labelFormulario1;
        private Label label1;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void botonFormulario1_Click(object sender, EventArgs e)
        {

        }

        private TableLayoutPanel tablaOpciones;
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void panelFormulario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}