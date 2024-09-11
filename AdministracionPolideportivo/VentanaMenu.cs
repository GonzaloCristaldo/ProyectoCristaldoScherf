using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionPolideportivo
{
    internal class VentanaMenu : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

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
        private Button button1;
        private Button button2;
        private bool shouldMaximize = false;
        private bool shouldSnapRight = false;
        private bool shouldSnapLeft = false;
        private bool isSnapped = true;
        Screen currentScreen;



        protected Rectangle lastRectangle;
        public VentanaMenu()
        {
            InitializeComponent();

            //Aplicando color a los paneles del menu
            this.panelNavegacion.BackColor = Color.FromArgb(18, 77, 10);
            this.panelOpciones.BackColor = Color.FromArgb(31,31,31);
            this.panelFormulario.BackColor = Color.FromArgb(49, 49, 49);


            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            Console.WriteLine("ventana construida");

            this.FormBorderStyle = FormBorderStyle.None;  // Remove default form border
            this.Padding = new Padding(borderWidth);      // Add padding for the custom border
            this.MouseDown += Form_MouseDown;
            this.MouseMove += Form_MouseMove;
            this.MouseUp += Form_MouseUp;
            this.Move += Form_Move;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Draw custom border
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                Color.FromArgb(31, 31, 31), borderWidth, ButtonBorderStyle.Solid,
                Color.FromArgb(18, 77, 10), borderWidth, ButtonBorderStyle.Solid,
                Color.FromArgb(31, 31, 31), borderWidth, ButtonBorderStyle.Solid,
                Color.FromArgb(31, 31, 31), borderWidth, ButtonBorderStyle.Solid);
            //draw border details
            Rectangle rcDetalles= this.ClientRectangle;
            rcDetalles.Width = this.Width;
            rcDetalles.Height = this.Height-borderWidth-panelFormulario.Height;
            ControlPaint.DrawBorder(e.Graphics, rcDetalles,
                Color.FromArgb(18, 77, 10), borderWidth, ButtonBorderStyle.Solid,
                Color.FromArgb(18, 77, 10), borderWidth, ButtonBorderStyle.Solid,
                Color.FromArgb(18, 77, 10), borderWidth, ButtonBorderStyle.Solid,
                Color.FromArgb(18,77,10), borderWidth, ButtonBorderStyle.Solid);
            Rectangle rcAreaTrabajo=panelFormulario.ClientRectangle;
            Point location = PointToScreen(panelFormulario.Location);
            rcAreaTrabajo.Width = panelFormulario.Width;
            rcAreaTrabajo.Height = panelFormulario.Height;
            rcAreaTrabajo.Width -= borderWidth*2;
            rcAreaTrabajo.Height -= borderWidth*2;
            rcAreaTrabajo.X = location.X; rcAreaTrabajo.Y = location.Y;
            /*rcAreaTrabajo.Width = panelFormulario.Width;
            rcAreaTrabajo.Height = panelFormulario.Height;*/
            ControlPaint.DrawBorder(e.Graphics, rcAreaTrabajo,
                Color.FromArgb(31,31,31), borderWidth*3, ButtonBorderStyle.Solid,
                Color.FromArgb(31,31,31), borderWidth*3, ButtonBorderStyle.Solid,
                Color.FromArgb(31,31,31), borderWidth*3, ButtonBorderStyle.Solid,
                Color.FromArgb(31,31,31), borderWidth*3, ButtonBorderStyle.Solid);
        }

        private void InitializeComponent()
        {
            panelNavegacion = new Panel();
            panelOpciones = new Panel();
            panelFormulario = new Panel();
            button2 = new Button();
            button1 = new Button();
            panelFormulario.SuspendLayout();
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
            panelFormulario.Controls.Add(button2);
            panelFormulario.Controls.Add(button1);
            panelFormulario.Dock = DockStyle.Fill;
            panelFormulario.Location = new Point(200, 34);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(494, 416);
            panelFormulario.TabIndex = 2;
            panelFormulario.Paint += panelFormulario_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(290, 166);
            button2.Name = "button2";
            button2.Size = new Size(92, 45);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(122, 159);
            button1.Name = "button1";
            button1.Size = new Size(102, 52);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
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
            panelFormulario.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panelNavegacion;
        private Panel panelOpciones;
        private Panel panelFormulario;

        private void panelNavegacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Move(object sender, EventArgs e)
        {
            if (isResizing) return; // Evitar parpadeo si ya estamos redimensionando

            Screen currentScreen = Screen.FromPoint(this.Location);

            // Redimensionar hacia la izquierda (ajustar al borde izquierdo)
            if (this.Left <= currentScreen.WorkingArea.Left + 5)
            {
                /*isResizing = true;
                this.Bounds = new Rectangle(currentScreen.WorkingArea.Left, currentScreen.WorkingArea.Top,
                                            currentScreen.WorkingArea.Width / 2, currentScreen.WorkingArea.Height);
                isMaximized = false;
                isResizing = false;*/
            }
            // Redimensionar hacia la derecha (ajustar al borde derecho)
            else if (this.Right >= currentScreen.WorkingArea.Right - 5)
            {
                
            }
            // Maximizar al arrastrar al borde superior
            else if (this.Top <= currentScreen.WorkingArea.Top + 5)
            {
                //MaximizeForm();
            }
            // Restaurar el formulario si se arrastra fuera de la parte inferior
            else if (this.Bottom >= currentScreen.WorkingArea.Bottom - 5 && !isMaximized)
            {
                RestoreForm();
            }
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
            /*isDragging = true;
            movX = e.X;
            movY = e.Y;*/

            Console.WriteLine("el evento ocurre");
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastRectangle = new Rectangle(e.Location.X, e.Location.Y, this.Width, this.Height);
                Console.WriteLine("isDragging");
                if (isSnapped==false) { 
                    normalBounds = this.Bounds;
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
                int x = (this.Location.X + (e.Location.X - lastRectangle.X));
                int y = (this.Location.Y + (e.Location.Y - lastRectangle.Y));
                this.Location = new Point(x, y);
            }
            if (isDragging)
            {
                currentScreen = Screen.FromPoint(this.Location);

                // Si el borde superior está alcanzado, señalamos que debe maximizarse al soltar el mouse
                if (this.Top <= currentScreen.WorkingArea.Top + 5 )
                {
                    shouldMaximize = true;  // Bandera para maximizar
                    shouldSnapLeft = false;
                    shouldSnapRight = false;
                    
                }
                else if (this.Left <= currentScreen.WorkingArea.Left + 5)  // Snap to left
                {
                    shouldSnapLeft = true;
                    shouldSnapRight = false;
                    shouldMaximize = false;
                }
                else if (this.Right >= currentScreen.WorkingArea.Right - 5)  // Snap to right
                {
                    shouldSnapRight = true;
                    shouldSnapLeft = false;
                    shouldMaximize = false;
                }
                else if (this.Top <= currentScreen.WorkingArea.Top + 5 && this.Left <= currentScreen.WorkingArea.Left + 5
                    && this.Right >= currentScreen.WorkingArea.Right - 5)
                {
                    RestoreForm();  // Restore size if dragged away from edges
                }
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
            Console.WriteLine("shouldMaximize = "+shouldMaximize);
            Console.WriteLine("isMaximized = " + isMaximized);
            if (shouldMaximize && isMaximized==false)
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
                    m.Result = (IntPtr)HTLEFT;
                else if (cursor.X >= ClientSize.Width - borderWidth)
                    m.Result = (IntPtr)HTRIGHT;
                else if (cursor.Y <= borderWidth)
                    m.Result = (IntPtr)HTTOP;
                else if (cursor.Y >= ClientSize.Height - borderWidth)
                    m.Result = (IntPtr)HTBOTTOM;
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
            this.Bounds = new Rectangle(currentScreen.WorkingArea.Left + currentScreen.WorkingArea.Width / 2,
                                        currentScreen.WorkingArea.Top,
                                        currentScreen.WorkingArea.Width / 2, currentScreen.WorkingArea.Height);
            isMaximized = false;
            isResizing = false;
            shouldSnapRight = false;
            isSnapped = true;
        }

        private void SnapLeft()
        {
            this.Bounds = new Rectangle(currentScreen.WorkingArea.Left, currentScreen.WorkingArea.Top,
                                                currentScreen.WorkingArea.Width / 2, currentScreen.WorkingArea.Height);
            isMaximized = false;  // Not fully maximized
            isResizing=false;
            shouldSnapLeft = false;
            isSnapped = true;
        }

        private void MaximizeForm()
        {
            if (!isMaximized)
            {
                normalBounds = this.Bounds; // Guardar los límites originales
                Screen currentScreen = Screen.FromPoint(this.Location);
                isResizing = true;
                this.Bounds = currentScreen.WorkingArea; // Maximizar al tamaño completo de la pantalla
                isMaximized = true;
                isResizing = false;
            }
            shouldMaximize = false;
        }

        private void RestoreForm()
        {
            if (isMaximized || isSnapped)
            {
                Console.WriteLine("anda el restore");
                Rectangle tamanoDefault = new Rectangle();
                tamanoDefault.Width = 800;
                tamanoDefault.Height = 600;
                this.Bounds = tamanoDefault;  // Restore to original size
                isMaximized = false;
                shouldMaximize=false;
                shouldSnapLeft=false;
                shouldSnapRight=false;
                isSnapped = false;
            }
        }

    }
}
