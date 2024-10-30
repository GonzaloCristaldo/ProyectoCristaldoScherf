using AdministracionPolideportivo.CDatos;
using AdministracionPolideportivo.CNegocio;
using AdministracionPolideportivo.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class agregarUsuario : FormularioEstandar
    {
        public agregarUsuario()
        {
            

            InitializeComponent();
            UbicarElementos();
            //TODO traer tipos de la db y cargar en el combo box
            List<TipoUsuario> tipos=DALTipoUsuario.ListarTiposDeUsuario();
            cbTipo.DataSource = tipos;
            cbTipo.DataContext = tipos;
            
            
        }

        private void UbicarElementos()
        {

            LabelFormulario lblMasGrande = lblNacimiento;

            panelIzquierda.Location = new System.Drawing.Point(0, (this.Height - panelIzquierda.Height) / 2);
            panelIzquierda.Width = (Int32)(this.Width * (2.0 / 3.0));
            Console.WriteLine(panelIzquierda.Width);
            //panelIzquierda.Height = this.Height;

            panelDerecha.Location = new System.Drawing.Point(panelIzquierda.Width, ((this.Height - panelDerecha.Height) / 2) + 15);
            panelDerecha.Width = this.Width - panelIzquierda.Width;
            Console.WriteLine(panelDerecha.Width);

            // panelDerecha.Height = this.Height;

            lblDNI.Location = new System.Drawing.Point(10, 10);
            lblNombre.Location = new System.Drawing.Point(10, lblDNI.Location.Y + lblDNI.Height + 10);
            lblApellido.Location = new System.Drawing.Point(10, lblNombre.Location.Y + lblNombre.Height + 10);
            lblTipo.Location = new System.Drawing.Point(10, lblApellido.Location.Y + lblApellido.Height + 10);
            lblTelefono.Location = new System.Drawing.Point(10, lblTipo.Location.Y + lblTipo.Height + 10);
            lblPass.Location = new System.Drawing.Point(10, lblTelefono.Location.Y + lblTelefono.Height + 10);
            lblNacimiento.Location = new System.Drawing.Point(10, lblPass.Location.Y + lblPass.Height + 10);

            txtDNI.Location = new System.Drawing.Point(lblMasGrande.Location.X + lblMasGrande.Width + 5, lblDNI.Location.Y);
            txtNombre.Location = new System.Drawing.Point(lblMasGrande.Location.X + lblMasGrande.Width + 5, lblNombre.Location.Y);
            txtApellido.Location = new System.Drawing.Point(lblMasGrande.Location.X + lblMasGrande.Width + 5, lblApellido.Location.Y);
            cbTipo.Location = new System.Drawing.Point(lblMasGrande.Location.X + lblMasGrande.Width + 5, lblTipo.Location.Y);
            txtTelefono.Location = new System.Drawing.Point(lblMasGrande.Location.X + lblMasGrande.Width + 5, lblTelefono.Location.Y);
            txtPass.Location = new System.Drawing.Point(lblMasGrande.Location.X + lblMasGrande.Width + 5, lblPass.Location.Y);
            dtpNacimiento.Location = new System.Drawing.Point(lblMasGrande.Location.X + lblMasGrande.Width + 5, lblNacimiento.Location.Y);

            txtDNI.Width = panelIzquierda.Width - lblMasGrande.Location.X - lblMasGrande.Width - 10;
            txtApellido.Width = panelIzquierda.Width - lblMasGrande.Location.X - lblMasGrande.Width - 10;
            txtTelefono.Width = panelIzquierda.Width - lblMasGrande.Location.X - lblMasGrande.Width - 10;
            txtNombre.Width = panelIzquierda.Width - lblMasGrande.Location.X - lblMasGrande.Width - 10;
            cbTipo.Width = panelIzquierda.Width - lblMasGrande.Location.X - lblMasGrande.Width - 10;
            txtPass.Width = panelIzquierda.Width - lblMasGrande.Location.X - lblMasGrande.Width - 10;
            dtpNacimiento.Width = panelIzquierda.Width - lblMasGrande.Location.X - lblMasGrande.Width - 10;

            //panel derecho
            pictureBox1.Width = 150;
            pictureBox1.Height = 150;
            pictureBox1.Location = new Point((panelDerecha.Width - pictureBox1.Width) / 2, 0);

            //pictureBox1.Location = new System.Drawing.Point(0, 0);
            txtImagen.Location = new System.Drawing.Point(10, pictureBox1.Height + pictureBox1.Location.Y);
            txtImagen.Width = panelDerecha.Width - 20;
            btnImagen.Location = new System.Drawing.Point((panelDerecha.Width - btnImagen.Width) / 2, txtImagen.Location.Y + 10 + txtImagen.Height);
            lblSexo.Location = new System.Drawing.Point(10, btnImagen.Location.Y + btnImagen.Height + 10);
            cbSexo.Location = new Point(lblSexo.Location.X + lblSexo.Width + 10, lblSexo.Location.Y);
            cbSexo.Width = panelDerecha.Width - cbSexo.Location.X - 20;

            btnAgregar.Location = new System.Drawing.Point((panelDerecha.Width - btnAgregar.Width) / 2, cbSexo.Location.Y + cbSexo.Height + 15);


        }

        private LabelFormulario lblDNI;
        private LabelFormulario lblNombre;
        public Texto txtNombre;
        private LabelFormulario lblApellido;
        public Texto txtApellido;
        private LabelFormulario lblTelefono;
        public TextoNumerico txtTelefono;
        private BotonFormulario btnAgregar;
        public ComboBoxEstandar cbTipo;
        private LabelFormulario lblTipo;
        private PictureBox pictureBox1;
        public ComboBoxEstandar cbSexo;
        private LabelFormulario lblSexo;
        private Panel panelIzquierda;
        private Panel panelDerecha;
        private Texto txtImagen;
        private BotonFormulario btnImagen;
        private OpenFileDialog openFileDialog1;
        public TextoNumerico txtDNI;
        public Texto txtPass;
        private LabelFormulario lblPass;
        private LabelFormulario lblNacimiento;
        private DateTimePicker dtpNacimiento;
        string selectedFile;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarUsuario));
            lblDNI = new LabelFormulario();
            txtDNI = new TextoNumerico();
            lblNombre = new LabelFormulario();
            txtNombre = new Texto();
            lblApellido = new LabelFormulario();
            txtApellido = new Texto();
            lblTelefono = new LabelFormulario();
            txtTelefono = new TextoNumerico();
            btnAgregar = new BotonFormulario();
            cbTipo = new ComboBoxEstandar();
            lblTipo = new LabelFormulario();
            pictureBox1 = new PictureBox();
            cbSexo = new ComboBoxEstandar();
            lblSexo = new LabelFormulario();
            panelIzquierda = new Panel();
            txtPass = new Texto();
            lblPass = new LabelFormulario();
            panelDerecha = new Panel();
            txtImagen = new Texto();
            btnImagen = new BotonFormulario();
            openFileDialog1 = new OpenFileDialog();
            lblNacimiento = new LabelFormulario();
            dtpNacimiento = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelIzquierda.SuspendLayout();
            panelDerecha.SuspendLayout();
            SuspendLayout();
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 13F);
            lblDNI.ForeColor = Color.White;
            lblDNI.Location = new Point(12, 8);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(55, 25);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "D.N.I.";
            // 
            // txtDNI
            // 
            txtDNI.BackColor = SystemColors.WindowFrame;
            txtDNI.ForeColor = Color.White;
            txtDNI.Location = new Point(136, 17);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(117, 23);
            txtDNI.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 13F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(12, 56);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.WindowFrame;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(136, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 23);
            txtNombre.TabIndex = 0;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 13F);
            lblApellido.ForeColor = Color.White;
            lblApellido.Location = new Point(12, 111);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 25);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = SystemColors.WindowFrame;
            txtApellido.ForeColor = Color.White;
            txtApellido.Location = new Point(136, 120);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(210, 23);
            txtApellido.TabIndex = 0;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 13F);
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(7, 217);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(79, 25);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.WindowFrame;
            txtTelefono.ForeColor = Color.White;
            txtTelefono.Location = new Point(136, 226);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(151, 23);
            txtTelefono.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LimeGreen;
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(71, 307);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(146, 41);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Usuario";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregarCliente_Click;
            // 
            // cbTipo
            // 
            cbTipo.BackColor = SystemColors.WindowFrame;
            cbTipo.ForeColor = Color.White;
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Recepcionista", "Administrador (No apto para el admin)", "Super-Administrador (No apto para el admin)" });
            cbTipo.Location = new Point(136, 176);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(210, 23);
            cbTipo.TabIndex = 0;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 13F);
            lblTipo.ForeColor = Color.White;
            lblTipo.Location = new Point(12, 173);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(47, 25);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Tipo";
            lblTipo.Click += labelFormulario1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // cbSexo
            // 
            cbSexo.BackColor = SystemColors.WindowFrame;
            cbSexo.ForeColor = Color.White;
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Hombre", "Mujer" });
            cbSexo.Location = new Point(73, 249);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(144, 23);
            cbSexo.TabIndex = 0;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 13F);
            lblSexo.ForeColor = Color.White;
            lblSexo.Location = new Point(13, 246);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(54, 25);
            lblSexo.TabIndex = 7;
            lblSexo.Text = "Sexo:";
            // 
            // panelIzquierda
            // 
            panelIzquierda.Controls.Add(dtpNacimiento);
            panelIzquierda.Controls.Add(lblNacimiento);
            panelIzquierda.Controls.Add(txtPass);
            panelIzquierda.Controls.Add(lblPass);
            panelIzquierda.Controls.Add(txtDNI);
            panelIzquierda.Controls.Add(lblDNI);
            panelIzquierda.Controls.Add(lblNombre);
            panelIzquierda.Controls.Add(lblTipo);
            panelIzquierda.Controls.Add(txtNombre);
            panelIzquierda.Controls.Add(lblApellido);
            panelIzquierda.Controls.Add(cbTipo);
            panelIzquierda.Controls.Add(txtApellido);
            panelIzquierda.Controls.Add(lblTelefono);
            panelIzquierda.Controls.Add(txtTelefono);
            panelIzquierda.Location = new Point(12, 12);
            panelIzquierda.Name = "panelIzquierda";
            panelIzquierda.Size = new Size(360, 382);
            panelIzquierda.TabIndex = 8;
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.WindowFrame;
            txtPass.ForeColor = Color.White;
            txtPass.Location = new Point(136, 279);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(151, 23);
            txtPass.TabIndex = 7;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 13F);
            lblPass.ForeColor = Color.White;
            lblPass.Location = new Point(11, 277);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(101, 25);
            lblPass.TabIndex = 6;
            lblPass.Text = "Contraseña";
            // 
            // panelDerecha
            // 
            panelDerecha.Controls.Add(txtImagen);
            panelDerecha.Controls.Add(btnImagen);
            panelDerecha.Controls.Add(pictureBox1);
            panelDerecha.Controls.Add(cbSexo);
            panelDerecha.Controls.Add(btnAgregar);
            panelDerecha.Controls.Add(lblSexo);
            panelDerecha.Location = new Point(378, 12);
            panelDerecha.Name = "panelDerecha";
            panelDerecha.Size = new Size(287, 382);
            panelDerecha.TabIndex = 9;
            // 
            // txtImagen
            // 
            txtImagen.BackColor = SystemColors.WindowFrame;
            txtImagen.ForeColor = Color.White;
            txtImagen.Location = new Point(22, 158);
            txtImagen.Name = "txtImagen";
            txtImagen.ReadOnly = true;
            txtImagen.Size = new Size(210, 23);
            txtImagen.TabIndex = 0;
            // 
            // btnImagen
            // 
            btnImagen.BackColor = Color.DimGray;
            btnImagen.Font = new Font("Segoe UI", 10F);
            btnImagen.ForeColor = Color.White;
            btnImagen.Location = new Point(23, 187);
            btnImagen.MaximumSize = new Size(146, 41);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(146, 41);
            btnImagen.TabIndex = 0;
            btnImagen.Text = "Elegir imagen";
            btnImagen.UseVisualStyleBackColor = false;
            btnImagen.Click += btnImagen_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblNacimiento
            // 
            lblNacimiento.AutoSize = true;
            lblNacimiento.Font = new Font("Segoe UI", 15F);
            lblNacimiento.ForeColor = Color.White;
            lblNacimiento.Location = new Point(11, 332);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.Size = new Size(113, 28);
            lblNacimiento.TabIndex = 8;
            lblNacimiento.Text = "Nacimiento";
            lblNacimiento.Click += labelFormulario1_Click_1;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Format = DateTimePickerFormat.Short;
            dtpNacimiento.Location = new Point(130, 337);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(200, 23);
            dtpNacimiento.TabIndex = 9;
            // 
            // agregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(686, 406);
            Controls.Add(panelDerecha);
            Controls.Add(panelIzquierda);
            MinimumSize = new Size(500, 315);
            Name = "agregarUsuario";
            Resize += agregarUsuario_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelIzquierda.ResumeLayout(false);
            panelIzquierda.PerformLayout();
            panelDerecha.ResumeLayout(false);
            panelDerecha.PerformLayout();
            ResumeLayout(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelFormulario1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones de los campos
                if (string.IsNullOrEmpty(txtDNI.Text) || !int.TryParse(txtDNI.Text, out int dni) || dni <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un DNI válido.");
                    return;
                }

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Por favor, ingrese un nombre.");
                    return;
                }

                if (string.IsNullOrEmpty(txtApellido.Text))
                {
                    MessageBox.Show("Por favor, ingrese un apellido.");
                    return;
                }

                if (string.IsNullOrEmpty(txtTelefono.Text) || !int.TryParse(txtTelefono.Text, out int telefono) || telefono <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un número de teléfono válido.");
                    return;
                }

                // Verificar si se seleccionó un tipo de usuario
                if (cbTipo.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un tipo de usuario.");
                    return;
                }

                // Verificar si se seleccionó un sexo
                if (cbSexo.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un sexo.");
                    return;
                }

                var confirmResult = MessageBox.Show("¿Estas seguro que deseas agregar un nuevo usuario?",
                                     "Confirmar alta de usuario",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (confirmResult == DialogResult.Yes)
                {
                    ImageConverter converter = new ImageConverter();
                    byte[] imagen = (byte[])converter.ConvertTo(new Bitmap(selectedFile), typeof(byte[]));

                    
                    // Crea el usuario y llama a la capa de datos
                    Usuario usuario = new Usuario(txtNombre.Text, txtApellido.Text, (TipoUsuario)cbTipo.SelectedValue, txtPass.Text, Int32.Parse(txtDNI.Text),
                        dtpNacimiento.Value,DateTime.Today,txtTelefono.Text, imagen,cbSexo.Text);
                    int resultado = DALUsuario.AgregarUsuario(usuario);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Usuario agregado exitosamente.");
                        LimpiarCampos(); // Limpia los campos después de agregar el cliente
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el usuario.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        // Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarUsuario));

            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            cbTipo.SelectedIndex = -1; // Desmarcar selección
            cbSexo.SelectedIndex = -1; // Desmarcar selección
            txtImagen.Clear();
            txtPass.Clear();
            dtpNacimiento.ResetText();
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                selectedFile = openFileDialog1.FileName;
                try
                {
                    pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                    txtImagen.Text = selectedFile;
                }
                catch (Exception exc)
                {
                    txtImagen.Text = "Imagen no encontrada";
                }
            }
        }

        private void agregarUsuario_Resize(object sender, EventArgs e)
        {
            UbicarElementos();
        }

        private void labelFormulario1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
