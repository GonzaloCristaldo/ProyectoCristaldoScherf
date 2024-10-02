using AdministracionPolideportivo.CDatos;
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


            var confirmResult = MessageBox.Show("¿Estas seguro que deseas salir del programa?",
                                     "Confirmar cierre",
                                     MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (confirmResult == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }

            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;


        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Validación: Verificar si los campos no están vacíos
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Por favor, ingrese su DNI.");
                return;
            }

            if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Por favor, ingrese su contraseña.");
                return;
            }

            try
            {
                // Convertir el texto del DNI a número
                int dni = Int32.Parse(txtUsuario.Text);
                // Intentar iniciar sesión
                AdministracionPolideportivo.CNegocio.Usuario usuario = DALUsuario.Login(dni, txtPass.Text);

                // Si el login retorna null, salir del método
                if (usuario == null)
                {
                    return;
                }

                // Mostrar el menú correspondiente según el tipo de usuario
                if (usuario.tipoUsuario.NombreTipoUsuario.Equals("Administrador"))
                {
                    VistaAdmin menu = new VistaAdmin();
                    menu.Show();
                    this.Hide();
                }
                else if (usuario.tipoUsuario.NombreTipoUsuario.Equals("Recepcionista"))
                {
                    vistaRecepcionista menu = new vistaRecepcionista();
                    menu.Show();
                    this.Hide();
                }
                else if (usuario.tipoUsuario.NombreTipoUsuario.Equals("SuperAdministrador"))
                {
                    vistaSuperAdmin menu = new vistaSuperAdmin();
                    menu.Show();
                    this.Hide();
                }
                else if (usuario.tipoUsuario.NombreTipoUsuario.Equals("error"))
                {
                    MessageBox.Show("Credenciales incorrectas. Por favor, intente de nuevo.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El DNI ingresado no es válido. Ingrese un número.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
            //menu.SetUsuario();
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string direccionCorreo = "gonzalodlp97@gmail.com";

                // Muestra una ventana de confirmación
                var confirmacion = MessageBox.Show("¿Quieres enviar un correo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    // Abre el cliente de correo predeterminado
                    System.Diagnostics.Process.Start(new ProcessStartInfo("mailto:"+direccionCorreo) { UseShellExecute = true });
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
