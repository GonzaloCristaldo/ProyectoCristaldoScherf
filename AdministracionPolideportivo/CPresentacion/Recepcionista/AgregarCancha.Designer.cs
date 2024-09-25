namespace AdministracionPolideportivo.CPresentacion.Recepcionista
{
    partial class AgregarCancha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumero = new LabelFormulario();
            txtNumCancha = new TextoNumerico();
            lblTarifa = new LabelFormulario();
            txtTarifa = new TextoNumerico();
            cbEstado = new ComboBoxEstandar();
            lblEstado = new LabelFormulario();
            lblTipo = new LabelFormulario();
            cbTipo = new ComboBoxEstandar();
            lblUbicacion = new LabelFormulario();
            txtUbicacion = new Texto();
            btnAgregar = new BotonFormulario();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.ForeColor = Color.White;
            lblNumero.Location = new Point(12, 9);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(110, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero de Cancha";
            lblNumero.Click += labelFormulario1_Click;
            // 
            // txtNumCancha
            // 
            txtNumCancha.BackColor = SystemColors.WindowFrame;
            txtNumCancha.ForeColor = Color.White;
            txtNumCancha.Location = new Point(128, 6);
            txtNumCancha.Name = "txtNumCancha";
            txtNumCancha.Size = new Size(82, 23);
            txtNumCancha.TabIndex = 1;
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.ForeColor = Color.White;
            lblTarifa.Location = new Point(37, 38);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(85, 15);
            lblTarifa.TabIndex = 2;
            lblTarifa.Text = "Tarifa por Hora";
            lblTarifa.Click += labelFormulario1_Click_1;
            // 
            // txtTarifa
            // 
            txtTarifa.BackColor = SystemColors.WindowFrame;
            txtTarifa.ForeColor = Color.White;
            txtTarifa.Location = new Point(128, 35);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(82, 23);
            txtTarifa.TabIndex = 1;
            // 
            // cbEstado
            // 
            cbEstado.BackColor = SystemColors.WindowFrame;
            cbEstado.ForeColor = Color.White;
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(128, 64);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(168, 23);
            cbEstado.TabIndex = 0;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.ForeColor = Color.White;
            lblEstado.Location = new Point(11, 67);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(111, 15);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Estado de la cancha";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.ForeColor = Color.White;
            lblTipo.Location = new Point(33, 96);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(89, 15);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo de Cancha";
            lblTipo.Click += labelFormulario1_Click_2;
            // 
            // cbTipo
            // 
            cbTipo.BackColor = SystemColors.WindowFrame;
            cbTipo.ForeColor = Color.White;
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(128, 93);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(168, 23);
            cbTipo.TabIndex = 0;
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.ForeColor = Color.White;
            lblUbicacion.Location = new Point(62, 126);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(60, 15);
            lblUbicacion.TabIndex = 5;
            lblUbicacion.Text = "Ubicación";
            // 
            // txtUbicacion
            // 
            txtUbicacion.BackColor = SystemColors.WindowFrame;
            txtUbicacion.ForeColor = Color.White;
            txtUbicacion.Location = new Point(128, 123);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(210, 23);
            txtUbicacion.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DimGray;
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(102, 169);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(146, 41);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Cancha";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // AgregarCancha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 249);
            Controls.Add(btnAgregar);
            Controls.Add(txtUbicacion);
            Controls.Add(lblUbicacion);
            Controls.Add(cbTipo);
            Controls.Add(lblTipo);
            Controls.Add(lblEstado);
            Controls.Add(cbEstado);
            Controls.Add(txtTarifa);
            Controls.Add(lblTarifa);
            Controls.Add(txtNumCancha);
            Controls.Add(lblNumero);
            Name = "AgregarCancha";
            Text = "AgregarCancha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelFormulario lblNumero;
        private TextoNumerico txtNumCancha;
        private LabelFormulario lblTarifa;
        private TextoNumerico txtTarifa;
        private ComboBoxEstandar cbEstado;
        private LabelFormulario lblEstado;
        private LabelFormulario lblTipo;
        private ComboBoxEstandar cbTipo;
        private LabelFormulario lblUbicacion;
        private Texto txtUbicacion;
        private BotonFormulario btnAgregar;
    }
}