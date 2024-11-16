namespace AdministracionPolideportivo
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblUsuario = new Label();
            lblContrasena = new Label();
            btnEntrar = new Button();
            btnCerrar = new Button();
            btnMinimizar = new Button();
            panel1 = new Panel();
            btnAdmin = new Button();
            txtUsuario = new CPresentacion.Texto();
            txtPass = new CPresentacion.Texto();
            label1 = new Label();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Gainsboro;
            lblUsuario.Location = new Point(177, 213);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.BackColor = Color.Gainsboro;
            lblContrasena.Location = new Point(168, 259);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(67, 15);
            lblContrasena.TabIndex = 1;
            lblContrasena.Text = "Contraseña";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.LimeGreen;
            btnEntrar.BackgroundImageLayout = ImageLayout.Center;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Location = new Point(144, 316);
            btnEntrar.Margin = new Padding(3, 3, 3, 1);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(114, 40);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Iniciar Sesión";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(357, 7);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(40, 38);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Location = new Point(310, 7);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(40, 38);
            btnMinimizar.TabIndex = 6;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnAdmin);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(btnMinimizar);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(lblContrasena);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 450);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(325, 324);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(75, 23);
            btnAdmin.TabIndex = 12;
            btnAdmin.Text = "admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += button1_Click_1;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Gainsboro;
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(94, 233);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(210, 23);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextChanged += texto2_TextChanged;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.Gainsboro;
            txtPass.Cursor = Cursors.IBeam;
            txtPass.ForeColor = Color.Black;
            txtPass.Location = new Point(94, 277);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(210, 23);
            txtPass.TabIndex = 0;
            txtPass.TextChanged += texto1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 393);
            label1.Name = "label1";
            label1.Size = new Size(170, 15);
            label1.TabIndex = 11;
            label1.Text = "¿Problemas para iniciar sesion?";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(84, 411);
            button3.Name = "button3";
            button3.Size = new Size(220, 23);
            button3.TabIndex = 10;
            button3.Text = "Contactar Administrador general";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(103, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 158);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUsuario;
        private Label lblContrasena;
        private Button btnEntrar;
        private Button btnCerrar;
        private Button btnMinimizar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button3;
        private Label label1;
        private CPresentacion.Texto txtUsuario;
        private CPresentacion.Texto txtPass;
        private Button btnAdmin;
    }
}
