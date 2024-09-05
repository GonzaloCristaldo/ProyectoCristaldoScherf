using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo
{
    internal class VentanaMenu : Form
    {
        //Variables usadas para arrastrar la ventana
        int movX, movY;
        bool isMoving;

        //variables usadas para redimensionar el tamaño de la ventana 
        int grip = 16;
        int cap = 32;
        public VentanaMenu()
        {
            InitializeComponent();

            //Aplicando color a los paneles del menu
            this.panelNavegacion.BackColor = Color.FromArgb(18, 77, 10);
            this.panelOpciones.BackColor = Color.FromArgb(31, 31, 31);
            this.panelFormulario.BackColor = Color.FromArgb(49, 49, 49);


            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

        }


        private void InitializeComponent()
        {
            panelNavegacion = new Panel();
            panelOpciones = new Panel();
            panelFormulario = new Panel();
            SuspendLayout();
            // 
            // panelNavegacion
            // 
            panelNavegacion.Dock = DockStyle.Top;
            panelNavegacion.Location = new Point(0, 0);
            panelNavegacion.Name = "panelNavegacion";
            panelNavegacion.Size = new Size(694, 34);
            panelNavegacion.TabIndex = 0;
            panelNavegacion.Paint += panelNavegacion_Paint;
            panelNavegacion.MouseDown += panelNavegacion_MouseDown;
            panelNavegacion.MouseMove += panelNavegacion_MouseMove;
            panelNavegacion.MouseUp += panelNavegacion_MouseUp;
            // 
            // panelOpciones
            // 
            panelOpciones.Dock = DockStyle.Left;
            panelOpciones.Location = new Point(0, 34);
            panelOpciones.Name = "panelOpciones";
            panelOpciones.Size = new Size(200, 416);
            panelOpciones.TabIndex = 1;
            panelOpciones.Paint += panelOpciones_Paint;
            panelOpciones.MouseDown += panelOpciones_MouseDown;
            // 
            // panelFormulario
            // 
            panelFormulario.Dock = DockStyle.Fill;
            panelFormulario.Location = new Point(200, 34);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(494, 416);
            panelFormulario.TabIndex = 2;
            panelFormulario.Paint += panelFormulario_Paint;
            // 
            // VentanaMenu
            // 
            ClientSize = new Size(694, 450);
            Controls.Add(panelFormulario);
            Controls.Add(panelOpciones);
            Controls.Add(panelNavegacion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentanaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            MouseDown += VentanaMenu_MouseDown;
            MouseMove += VentanaMenu_MouseMove;
            MouseUp += VentanaMenu_MouseUp;
            ResumeLayout(false);
        }

        private Panel panelNavegacion;
        private Panel panelOpciones;
        private Panel panelFormulario;

        private void panelNavegacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelOpciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFormulario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelOpciones_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void VentanaMenu_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            movX = e.X;
            movY = e.Y;
        }

        private void VentanaMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void VentanaMenu_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
        }

        private void panelNavegacion_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            movX = e.X;
            movY = e.Y;
        }

        private void panelNavegacion_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelNavegacion_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
        }

        /*public static Point GetPoint(IntPtr lParam)
        {
            int value = unchecked((int)(long)lParam);
            int x = (short)(value & 0xffff);
            int y = (short)((value >> 16) & 0xffff);
            return new Point(x, y);
        }

        protected override void WndProc(ref Message m)
        {
            Point pos = GetPoint(m.LParam);
            pos = this.PointToClient(pos);
            if (m.Msg == 0x84) {
                if (pos.Y < cap)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if ((pos.X >= this.ClientSize.Width - grip) &&
                    (pos.Y >= this.ClientSize.Height - grip))
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }*/
    }
}
