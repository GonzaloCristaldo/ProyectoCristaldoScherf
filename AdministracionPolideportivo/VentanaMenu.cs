using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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

        //Variables usadas para arrastrar la ventana
        int movX, movY;
        bool isMoving;

        //variables usadas para redimensionar el tamaño de la ventana 
        protected bool isDragging = false;
        private Button button1;
        private Button button2;
        protected Rectangle lastRectangle;
        public VentanaMenu()
        {
            InitializeComponent();

            //Aplicando color a los paneles del menu
            this.panelNavegacion.BackColor = Color.FromArgb(18, 77, 10);
            this.panelOpciones.BackColor = Color.FromArgb(31, 31, 31);
            this.panelFormulario.BackColor = Color.FromArgb(49, 49, 49);


            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            Console.WriteLine("ventana construida");

            this.FormBorderStyle = FormBorderStyle.None;  // Remove default form border
            this.Padding = new Padding(borderWidth);      // Add padding for the custom border
            this.MouseDown += Form_MouseDown;
            this.MouseMove += Form_MouseMove;
            this.MouseUp += Form_MouseUp;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Draw custom border
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid);
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


        //funciones para redimensionar la ventana

        protected void initialiseFormEdge()
        {
            int resizeWidth = 5;

            this.MouseDown += new MouseEventHandler(form_MouseDown);
            this.MouseMove += new MouseEventHandler(form_MouseMove);
            this.MouseUp += delegate (object sender, MouseEventArgs e)
            {
                isDragging = false;
            };

            // bottom
            UserControl uc1 = new UserControl()
            {
                Anchor = (AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right),
                Height = resizeWidth,
                Width = this.DisplayRectangle.Width - (resizeWidth * 2),
                Left = resizeWidth,
                Dock = DockStyle.Bottom,
                Top = this.DisplayRectangle.Height - resizeWidth,
                //BackColor = Color.Transparent,
                Cursor = Cursors.SizeNS,
                BackColor = Color.FromArgb(31, 31, 31)
            };
            panelFormulario.Controls.Add(uc1);
            uc1.MouseDown += form_MouseDown;
            uc1.MouseUp += form_MouseUp;
            uc1.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                if (isDragging)
                {
                    this.Size = new Size(lastRectangle.Width, e.Y - lastRectangle.Y + this.Height);
                }
            };
            uc1.BringToFront();
            uc1.TabIndex = 0;

            this.Controls.Add(uc1);

            // right
            UserControl uc2 = new UserControl()
            {
                Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom),
                Height = this.DisplayRectangle.Height - (resizeWidth * 2),
                Width = resizeWidth,
                Left = this.DisplayRectangle.Width - resizeWidth,
                Top = resizeWidth,
                Dock = DockStyle.Right,
                BackColor = Color.FromArgb(31, 31, 31),
                Cursor = Cursors.SizeWE,
                ForeColor = Color.Black
            };
            uc2.MouseDown += form_MouseDown;
            uc2.MouseUp += form_MouseUp;
            uc2.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                if (isDragging)
                {
                    this.Size = new Size(e.X - lastRectangle.X + this.Width, lastRectangle.Height);
                }
            };
            uc2.BringToFront();

            this.Controls.Add(uc2);

            // bottom-right
            UserControl uc3 = new UserControl()
            {
                Anchor = (AnchorStyles.Bottom | AnchorStyles.Right),
                Height = resizeWidth,
                Width = resizeWidth,
                Left = this.DisplayRectangle.Width - resizeWidth,
                Top = this.DisplayRectangle.Height - resizeWidth,
                /*Dock = DockStyle.*/
                BackColor = Color.Transparent,
                Cursor = Cursors.SizeNWSE
            };
            uc3.MouseDown += form_MouseDown;
            uc3.MouseUp += form_MouseUp;
            uc3.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                if (isDragging)
                {
                    this.Size = new Size((e.X - lastRectangle.X + this.Width), (e.Y - lastRectangle.Y + this.Height));
                }
            };
            uc3.BringToFront();

            this.Controls.Add(uc3);

            // top-right
            UserControl uc4 = new UserControl()
            {
                Anchor = (AnchorStyles.Top | AnchorStyles.Right),
                Height = resizeWidth,
                Width = resizeWidth,
                Left = this.DisplayRectangle.Width - resizeWidth,
                Top = 0,
                BackColor = Color.Transparent,
                Cursor = Cursors.SizeNESW
            };
            uc4.MouseDown += form_MouseDown;
            uc4.MouseUp += form_MouseUp;
            uc4.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                if (isDragging)
                {
                    int diff = (e.Location.Y - lastRectangle.Y);
                    int y = (this.Location.Y + diff);

                    this.Location = new Point(this.Location.X, y);
                    this.Size = new Size(e.X - lastRectangle.X + this.Width, (this.Height + (diff * -1)));
                }
            };
            uc4.BringToFront();
            //uc4.BackColor = Color.Firebrick;

            this.Controls.Add(uc4);

            // top
            UserControl uc5 = new UserControl()
            {
                Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right),
                Height = resizeWidth,
                Width = this.DisplayRectangle.Width - (resizeWidth * 2),
                Left = resizeWidth,
                Top = 0,
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(31, 31, 31),
                Cursor = Cursors.SizeNS,
                ForeColor = Color.FromArgb(18, 77, 10)
            };
            uc5.MouseDown += form_MouseDown;
            uc5.MouseUp += form_MouseUp;
            uc5.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                if (isDragging)
                {
                    int diff = (e.Location.Y - lastRectangle.Y);
                    int y = (this.Location.Y + diff);

                    this.Location = new Point(this.Location.X, y);
                    this.Size = new Size(lastRectangle.Width, (this.Height + (diff * -1)));
                }
            };
            uc5.BringToFront();

            this.Controls.Add(uc5);

            // left
            UserControl uc6 = new UserControl()
            {
                Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom),
                Height = this.DisplayRectangle.Height - (resizeWidth * 2),
                Width = resizeWidth,
                Left = 0,
                Top = resizeWidth,
                Dock = DockStyle.Left,
                BackColor = Color.FromArgb(31, 31, 31),
                Cursor = Cursors.SizeWE,
                ForeColor = Color.Black
            };
            uc6.MouseDown += form_MouseDown;
            uc6.MouseUp += form_MouseUp;
            uc6.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                if (isDragging)
                {
                    int diff = (e.Location.X - lastRectangle.X);
                    int x = (this.Location.X + diff);

                    this.Location = new Point(x, this.Location.Y);
                    this.Size = new Size((this.Width + (diff * -1)), this.Height);
                }
            };
            uc6.BringToFront();

            this.Controls.Add(uc6);

            // bottom-left
            UserControl uc7 = new UserControl()
            {
                Anchor = (AnchorStyles.Bottom | AnchorStyles.Left),
                Height = resizeWidth,
                Width = resizeWidth,
                Left = 0,
                Top = this.DisplayRectangle.Height - resizeWidth,
                BackColor = Color.Transparent,
                Cursor = Cursors.SizeNESW
            };
            uc7.MouseDown += form_MouseDown;
            uc7.MouseUp += form_MouseUp;
            uc7.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                if (isDragging)
                {
                    int diff = (e.Location.X - lastRectangle.X);
                    int x = (this.Location.X + diff);

                    this.Location = new Point(x, this.Location.Y);
                    this.Size = new Size((this.Width + (diff * -1)), (e.Y - lastRectangle.Y + this.Height));
                }
            };
            uc7.BringToFront();

            this.Controls.Add(uc7);

            // bottom-left
            UserControl uc8 = new UserControl()
            {
                Anchor = (AnchorStyles.Bottom | AnchorStyles.Left),
                //Dock = DockStyle.Bottom,
                Height = resizeWidth,
                Width = resizeWidth,
                Left = 0,
                Top = 0,
                BackColor = Color.Transparent,
                Cursor = Cursors.SizeNWSE,
                ForeColor = Color.Transparent

            };
            uc8.MouseDown += form_MouseDown;
            uc8.MouseUp += form_MouseUp;
            uc8.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                if (isDragging)
                {
                    int dX = (e.Location.X - lastRectangle.X);
                    int dY = (e.Location.Y - lastRectangle.Y);
                    int x = (this.Location.X + dX);
                    int y = (this.Location.Y + dY);

                    this.Location = new Point(x, y);
                    this.Size = new Size((this.Width + (dX * -1)), (this.Height + (dY * -1)));
                }
            };
            uc8.BringToFront();

            this.Controls.Add(uc8);
        }
        private void form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastRectangle = new Rectangle(e.Location.X, e.Location.Y, this.Width, this.Height);
            }
        }

        private void form_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int x = (this.Location.X + (e.Location.X - lastRectangle.X));
                int y = (this.Location.Y + (e.Location.Y - lastRectangle.Y));

                this.Location = new Point(x, y);
            }
        }

        private void form_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
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
            if (e.Button == MouseButtons.Left && e.Y > borderWidth)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                normalBounds = this.Bounds;  // Save the original bounds
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            Screen currentScreen = Screen.FromPoint(this.Location);

            // Detect if the form is dragged to the top, left, or right edges of the screen
            if (this.Left <= currentScreen.WorkingArea.Left + 5)  // Snap to left
            {
                this.Bounds = new Rectangle(currentScreen.WorkingArea.Left, currentScreen.WorkingArea.Top,
                                            currentScreen.WorkingArea.Width / 2, currentScreen.WorkingArea.Height);
                isMaximized = false;  // Not fully maximized
            }
            else if (this.Right >= currentScreen.WorkingArea.Right - 5)  // Snap to right
            {
                this.Bounds = new Rectangle(currentScreen.WorkingArea.Left + currentScreen.WorkingArea.Width / 2,
                                            currentScreen.WorkingArea.Top,
                                            currentScreen.WorkingArea.Width / 2, currentScreen.WorkingArea.Height);
                isMaximized = false;
            }
            else if (this.Top <= currentScreen.WorkingArea.Top + 5)  // Maximize when dragged to the top
            {
                MaximizeForm();
            }
            else if (this.Bottom >= currentScreen.WorkingArea.Bottom - 5 && !isMaximized)
            {
                RestoreForm();  // Restore size if dragged away from edges
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            // When the mouse is released, restore original size if not at the edges
            if (!isMaximized && (this.Left > 5 && this.Top > 5))
            {
                this.Bounds = normalBounds;  // Restore to original size
            }
        }

        private void MaximizeForm()
        {
            if (!isMaximized)
            {
                normalBounds = this.Bounds;  // Save the original bounds
                Screen currentScreen = Screen.FromPoint(this.Location);
                this.Bounds = currentScreen.WorkingArea;  // Maximize to screen
                isMaximized = true;
            }
        }

        private void RestoreForm()
        {
            if (isMaximized)
            {
                this.Bounds = normalBounds;  // Restore to original size
                isMaximized = false;
            }
        }

    }
}
