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
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(103, 97);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(94, 149);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(67, 15);
            lblContrasena.TabIndex = 1;
            lblContrasena.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(188, 94);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(189, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(188, 149);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(189, 23);
            txtContrasena.TabIndex = 3;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(169, 228);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(114, 23);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Iniciar Sesión";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 518);
            Controls.Add(btnEntrar);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContrasena;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnEntrar;
    }
}
