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
    }
}
