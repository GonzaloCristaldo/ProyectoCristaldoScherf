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
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnEntrar = new Button();
            btnCerrar = new Button();
            btnMinimizar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            label1 = new Label();
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
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Info;
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Location = new Point(103, 233);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(201, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContrasena
            // 
            txtContrasena.Cursor = Cursors.IBeam;
            txtContrasena.Location = new Point(103, 277);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(201, 23);
            txtContrasena.TabIndex = 3;
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(btnMinimizar);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(lblContrasena);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 450);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
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
            // button2
            // 
            button2.Location = new Point(268, 315);
            button2.Name = "button2";
            button2.Size = new Size(120, 41);
            button2.TabIndex = 8;
            button2.Text = "vistaAdmin";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 315);
            button1.Name = "button1";
            button1.Size = new Size(120, 41);
            button1.TabIndex = 7;
            button1.Text = "vistaRecepcionista";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Login";
            ShowIcon = false;
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
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnEntrar;
        private Button btnCerrar;
        private Button btnMinimizar;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button3;
        private Label label1;
    }
}
