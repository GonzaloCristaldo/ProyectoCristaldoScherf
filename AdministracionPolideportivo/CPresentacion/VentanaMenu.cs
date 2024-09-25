using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class VentanaMenu : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern nint SendMessage(nint hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public BotonOpcion[] opciones;
        public int indexOpciones;

        // Constants for resizing
        private const int WM_NCHITTEST = 0x84;
        private const int HTLEFT = 0xA;
        private const int HTRIGHT = 0xB;
        private const int HTTOP = 0xC;
        private const int HTBOTTOM = 0xF;

        private int borderWidth = 5;  // Custom border width
        private Color borderColor = Color.DarkBlue;  // Custom border color
        private bool isMaximized = false;  // Track if the form is maximized
        private Rectangle normalBounds;    // Store form bounds when not maximized
        private bool isResizing = false; //Trackea cuando una ventana esta siendo redimencionada para evitar parpadeos

        //Variables usadas para arrastrar la ventana
        int movX, movY;
        bool isMoving;

        //variables usadas para redimensionar el tamaño de la ventana 
        protected bool isDragging = false;
        private bool shouldMaximize = false;
        private bool shouldSnapRight = false;
        private bool shouldSnapLeft = false;
        private bool isSnapped = true;
        Screen currentScreen;

        public Form formActual;//utilizado para llevar registro del formulario abierto

        protected Rectangle lastRectangle;
        public VentanaMenu()
        {
            InitializeComponent();
            opciones = new BotonOpcion[50];
            indexOpciones = 0;
            //Aplicando color a los paneles del menu
            panelNavegacion.BackColor = Color.FromArgb(18, 77, 10);
            panelOpciones.BackColor = Color.FromArgb(31, 31, 31);
            panelFormulario.BackColor = Color.FromArgb(49, 49, 49);


            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            Console.WriteLine("ventana construida");

            FormBorderStyle = FormBorderStyle.None;  // Remove default form border
            Padding = new Padding(borderWidth);      // Add padding for the custom border
            MouseDown += Form_MouseDown;
            MouseMove += Form_MouseMove;
            MouseUp += Form_MouseUp;
            Move += Form_Move;
            normalBounds = Bounds;
        }

        public void actualizarFormulario(Form nuevo)
        {
            System.Console.WriteLine("entra al metodo");
            formActual = nuevo;
            if (opciones.Length>0) {
                System.Console.WriteLine("hay opciones en el array");
                for (int i=0;i<opciones.GetLength(0);i++) {
                    System.Console.WriteLine("opcion n" + i);
                    if (opciones[i]!=null)
                    {
                        System.Console.WriteLine("en esta opcion no hay null");
                        opciones[i].FormularioViejo = formActual;
                        System.Console.WriteLine("SE actualizo el formulario viejo");
                    }
                }
            }
            
        }

        public void agregarOpcion(BotonOpcion opcionNueva)
        {
            //opciones.Append<BotonOpcion>(opcionNueva);
            opciones[indexOpciones]= opcionNueva;
            indexOpciones++;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Draw custom border
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                Color.FromArgb(31, 31, 31), borderWidth, ButtonBorderStyle.Solid,
                Color.FromArgb(18, 77, 10), borderWidth, ButtonBorderStyle.Solid,
                Color.FromArgb(31, 31, 31), borderWidth, ButtonBorderStyle.Solid,
                Color.FromArgb(31, 31, 31), borderWidth, ButtonBorderStyle.Solid);
            //draw border details
            Rectangle rcDetalles = ClientRectangle;
            rcDetalles.Width = Width;
            rcDetalles.Height = Height - borderWidth - panelFormulario.Height;
            ControlPaint.DrawBorder(e.Graphics, rcDetalles,
                Color.FromArgb(18, 77, 10), borderWidth, ButtonBorderStyle.Solid,
                Color.FromArgb(18, 77, 10), borderWidth, ButtonBorderStyle.Solid,
                Color.FromArgb(18, 77, 10), borderWidth, ButtonBorderStyle.Solid,
                Color.FromArgb(18, 77, 10), borderWidth, ButtonBorderStyle.Solid);
            Rectangle rcAreaTrabajo = panelFormulario.ClientRectangle;
            Point location = PointToScreen(panelFormulario.Location);
            rcAreaTrabajo.Width = panelFormulario.Width;
            rcAreaTrabajo.Height = panelFormulario.Height;
            rcAreaTrabajo.Width -= borderWidth * 2;
            rcAreaTrabajo.Height -= borderWidth * 2;
            rcAreaTrabajo.X = location.X; rcAreaTrabajo.Y = location.Y;
            /*rcAreaTrabajo.Width = panelFormulario.Width;
            rcAreaTrabajo.Height = panelFormulario.Height;*/
            ControlPaint.DrawBorder(e.Graphics, rcAreaTrabajo,
                Color.FromArgb(31, 31, 31), borderWidth * 3, ButtonBorderStyle.Solid,
                Color.FromArgb(31, 31, 31), borderWidth * 3, ButtonBorderStyle.Solid,
                Color.FromArgb(31, 31, 31), borderWidth * 3, ButtonBorderStyle.Solid,
                Color.FromArgb(31, 31, 31), borderWidth * 3, ButtonBorderStyle.Solid);
        }

        protected void InitializeComponent()
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
            panelNavegacion.Size = new Size(900, 34);
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
            panelOpciones.Size = new Size(226, 416);
            panelOpciones.TabIndex = 1;
            panelOpciones.Paint += panelOpciones_Paint;
            panelOpciones.MouseDown += panelOpciones_MouseDown;
            // 
            // panelFormulario
            // 
            panelFormulario.Dock = DockStyle.Fill;
            panelFormulario.Location = new Point(226, 34);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(674, 416);
            panelFormulario.TabIndex = 2;
            panelFormulario.Paint += panelFormulario_Paint;
            // 
            // VentanaMenu
            // 
            ClientSize = new Size(900, 450);
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

        public Panel panelNavegacion;
        public Panel panelOpciones;
        public Panel panelFormulario;

        public void panelNavegacion_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Form_Move(object sender, EventArgs e)
        {   
            if (isResizing) return; // Evitar parpadeo si ya estamos redimensionando

            Screen currentScreen = Screen.FromPoint(Location);

            // Redimensionar hacia la izquierda (ajustar al borde izquierdo)
            if (Left <= currentScreen.WorkingArea.Left + 5)
            {
                /*isResizing = true;
                this.Bounds = new Rectangle(currentScreen.WorkingArea.Left, currentScreen.WorkingArea.Top,
                                            currentScreen.WorkingArea.Width / 2, currentScreen.WorkingArea.Height);
                isMaximized = false;
                isResizing = false;*/
            }
            // Redimensionar hacia la derecha (ajustar al borde derecho)
            else if (Right >= currentScreen.WorkingArea.Right - 5)
            {

            }
            // Maximizar al arrastrar al borde superior
            else if (Top <= currentScreen.WorkingArea.Top + 5)
            {
                //MaximizeForm();
            }
            // Restaurar el formulario si se arrastra fuera de la parte inferior
            else if (Bottom >= currentScreen.WorkingArea.Bottom - 5 && !isMaximized)
            {
                RestoreForm();
            }
        }
        public void panelOpciones_Paint(object sender, PaintEventArgs e)
        {

        }

        public void panelFormulario_Paint(object sender, PaintEventArgs e)
        {

        }

        public void panelOpciones_MouseDown(object sender, MouseEventArgs e)
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
                SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void VentanaMenu_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
        }

        private void panelNavegacion_MouseDown(object sender, MouseEventArgs e)
        {
            /*isDragging = true;
            movX = e.X;
            movY = e.Y;*/

            Console.WriteLine("el evento ocurre");
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                if (!isMaximized)
                {
                    lastRectangle = new Rectangle(e.Location.X, e.Location.Y, Width, Height);
                }
                Console.WriteLine("isDragging");
                if (isSnapped == false && isMaximized == false)
                {
                    normalBounds = Bounds;
                }

            }

        }

        private void panelNavegacion_MouseMove(object sender, MouseEventArgs e)
        {
            /*if (isMoving)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }*/

            if (isDragging)
            {
                int x = Location.X + (e.Location.X - lastRectangle.X);
                int y = Location.Y + (e.Location.Y - lastRectangle.Y);
                Location = new Point(x, y);
            }
            if (isDragging)
            {
                RestoreForm();
                currentScreen = Screen.FromPoint(Location);

                // Si el borde superior está alcanzado, señalamos que debe maximizarse al soltar el mouse
                if (Top <= currentScreen.WorkingArea.Top + 5)
                {
                    shouldMaximize = true;  // Bandera para maximizar
                    shouldSnapLeft = false;
                    shouldSnapRight = false;

                }
                else if (Left <= currentScreen.WorkingArea.Left + 5)  // Snap to left
                {
                    shouldSnapLeft = true;
                    shouldSnapRight = false;
                    shouldMaximize = false;
                }
                else if (Right >= currentScreen.WorkingArea.Right - 5)  // Snap to right
                {
                    shouldSnapRight = true;
                    shouldSnapLeft = false;
                    shouldMaximize = false;
                }
                else if (Top <= currentScreen.WorkingArea.Top + 5 && Left <= currentScreen.WorkingArea.Left + 5
                    && Right >= currentScreen.WorkingArea.Right - 5)
                {
                    RestoreForm();  // Restore size if dragged away from edges
                }/*else if(isMaximized){

                }*/
                else
                {
                    shouldMaximize = false; // No maximizar si no está cerca del borde superior
                    shouldSnapLeft = false;
                    shouldSnapRight = false;

                }

            }

        }

        private void panelNavegacion_MouseUp(object sender, MouseEventArgs e)
        {
            // When the mouse is released, restore original size if not at the edges
            /*if (!isMaximized && (this.Left > 5 && this.Top > 5))
            {
                this.Bounds = normalBounds;  // Restore to original size
            }*/
            // Solo maximizar cuando el usuario suelte el mouse y esté cerca del borde superior
            Console.WriteLine("shouldMaximize = " + shouldMaximize);
            Console.WriteLine("isMaximized = " + isMaximized);
            if (shouldMaximize && isMaximized == false)
            {
                Console.WriteLine("maximiza");
                MaximizeForm();
            }
            else if (shouldSnapRight)
            {
                SnapRight();
            }
            else if (shouldSnapLeft)
            {
                SnapLeft();
            }

            isDragging = false; // Finaliza el arrastre
        }


        //funciones para redimensionar la ventana


        private void form_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void form_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void form_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("BOTON CLICKEADO");
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // Handle window resizing with custom border
            if (m.Msg == WM_NCHITTEST)
            {
                Point cursor = PointToClient(Cursor.Position);

                if (cursor.X <= borderWidth)
                    m.Result = HTLEFT;
                else if (cursor.X >= ClientSize.Width - borderWidth)
                    m.Result = HTRIGHT;
                else if (cursor.Y <= borderWidth)
                    m.Result = HTTOP;
                else if (cursor.Y >= ClientSize.Height - borderWidth)
                    m.Result = HTBOTTOM;
            }

        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void SnapRight()
        {
            isResizing = true;
            Bounds = new Rectangle(currentScreen.WorkingArea.Left + currentScreen.WorkingArea.Width / 2,
                                        currentScreen.WorkingArea.Top,
                                        currentScreen.WorkingArea.Width / 2, currentScreen.WorkingArea.Height);
            isMaximized = false;
            isResizing = false;
            shouldSnapRight = false;
            isSnapped = true;
        }

        private void SnapLeft()
        {
            Bounds = new Rectangle(currentScreen.WorkingArea.Left, currentScreen.WorkingArea.Top,
                                                currentScreen.WorkingArea.Width / 2, currentScreen.WorkingArea.Height);
            isMaximized = false;  // Not fully maximized
            isResizing = false;
            shouldSnapLeft = false;
            isSnapped = true;
        }

        private void MaximizeForm()
        {
            if (!isMaximized)
            {
                normalBounds = Bounds; // Guardar los límites originales
                Screen currentScreen = Screen.FromPoint(Location);
                isResizing = true;
                Bounds = currentScreen.WorkingArea; // Maximizar al tamaño completo de la pantalla
                isMaximized = true;
                isResizing = false;
            }
            shouldMaximize = false;
        }

        private void RestoreForm()
        {
            if (isMaximized || isSnapped)
            {

                /*Console.WriteLine("anda el restore");
                Rectangle tamanoDefault = new Rectangle();
                tamanoDefault.Width = 800;
                tamanoDefault.Height = 600;*/
                Bounds = normalBounds;  // Restore to original size
                SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
                isMaximized = false;
                shouldMaximize = false;
                shouldSnapLeft = false;
                shouldSnapRight = false;
                isSnapped = false;
            }
        }

    }
}
