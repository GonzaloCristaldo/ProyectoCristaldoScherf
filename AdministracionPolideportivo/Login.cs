using AdministracionPolideportivo.CPresentacion.Admin;
using AdministracionPolideportivo.CPresentacion.Recepcionista;
using AdministracionPolideportivo.CPresentacion.SuperAdmin;
using System.Diagnostics;

namespace AdministracionPolideportivo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(51, 153, 51);



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;


        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            VistaAdmin menu = new VistaAdmin();
            menu.Show();

            //  VentanaMenu menu = new VentanaMenu();
            //menu.Show();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vistaRecepcionista menu = new vistaRecepcionista();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VistaAdmin menu = new VistaAdmin();
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string direccionCorreo = "destinatario@example.com";

                // Muestra una ventana de confirmación
                var confirmacion = MessageBox.Show("¿Quieres enviar un correo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    // Abre el cliente de correo predeterminado
                    Process.Start($"mailto:{direccionCorreo}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el cliente de correo: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            vistaSuperAdmin menu = new vistaSuperAdmin();
            menu.Show();
        }

        private void texto2_TextChanged(object sender, EventArgs e)
        {

        }

        private void texto1_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
