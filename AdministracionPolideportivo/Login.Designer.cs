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
            lblUsuario = new Label();
            lblContrasena = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnEntrar = new Button();
            btnCerrar = new Button();
            btnMinimizar = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(105, 156);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(96, 208);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(67, 15);
            lblContrasena.TabIndex = 1;
            lblContrasena.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(190, 153);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(189, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(190, 208);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(189, 23);
            txtContrasena.TabIndex = 3;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(190, 270);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(114, 40);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Iniciar Sesión";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(448, 11);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(40, 38);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Location = new Point(393, 11);
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
            panel1.Size = new Size(501, 518);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 518);
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
    }
}
