using AdministracionPolideportivo.CPresentacion;
using AdministracionPolideportivo.CPresentacion.Admin;

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
    }

  
}
