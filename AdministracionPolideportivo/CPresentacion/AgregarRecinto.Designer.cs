namespace AdministracionPolideportivo.CPresentacion.Recepcionista
{
    partial class AgregarRecinto
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
            lblTipo = new LabelFormulario();
            cbTipo = new ComboBoxEstandar();
            lblUbicacion = new LabelFormulario();
            txtUbicacion = new Texto();
            btnAgregar = new BotonFormulario();
            txtServiciosAgregados = new Texto();
            btnAgregarServicio = new BotonFormulario();
            lblServicio = new LabelFormulario();
            cbServicioAdicional = new ComboBoxEstandar();
            labelFormulario1 = new LabelFormulario();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 18F);
            lblNumero.ForeColor = Color.White;
            lblNumero.Location = new Point(-2, 92);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(222, 32);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero de Recinto";
            lblNumero.Click += labelFormulario1_Click;
            // 
            // txtNumCancha
            // 
            txtNumCancha.BackColor = SystemColors.WindowFrame;
            txtNumCancha.ForeColor = Color.White;
            txtNumCancha.Location = new Point(226, 101);
            txtNumCancha.Name = "txtNumCancha";
            txtNumCancha.Size = new Size(117, 23);
            txtNumCancha.TabIndex = 1;
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Font = new Font("Segoe UI", 18F);
            lblTarifa.ForeColor = Color.White;
            lblTarifa.Location = new Point(-2, 133);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(171, 32);
            lblTarifa.TabIndex = 2;
            lblTarifa.Text = "Tarifa por Hora";
            lblTarifa.Click += labelFormulario1_Click_1;
            // 
            // txtTarifa
            // 
            txtTarifa.BackColor = SystemColors.WindowFrame;
            txtTarifa.ForeColor = Color.White;
            txtTarifa.Location = new Point(175, 139);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(168, 23);
            txtTarifa.TabIndex = 1;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 18F);
            lblTipo.ForeColor = Color.White;
            lblTipo.Location = new Point(-2, 165);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(181, 32);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo de Recinto";
            lblTipo.Click += labelFormulario1_Click_2;
            // 
            // cbTipo
            // 
            cbTipo.BackColor = SystemColors.WindowFrame;
            cbTipo.ForeColor = Color.White;
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(175, 174);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(168, 23);
            cbTipo.TabIndex = 0;
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Font = new Font("Segoe UI", 18F);
            lblUbicacion.ForeColor = Color.White;
            lblUbicacion.Location = new Point(-2, 205);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(118, 32);
            lblUbicacion.TabIndex = 5;
            lblUbicacion.Text = "Ubicación";
            // 
            // txtUbicacion
            // 
            txtUbicacion.BackColor = SystemColors.WindowFrame;
            txtUbicacion.ForeColor = Color.White;
            txtUbicacion.Location = new Point(133, 214);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(210, 23);
            txtUbicacion.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DimGray;
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(108, 265);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(146, 41);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Recinto";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtServiciosAgregados
            // 
            txtServiciosAgregados.BackColor = SystemColors.WindowFrame;
            txtServiciosAgregados.Enabled = false;
            txtServiciosAgregados.ForeColor = Color.White;
            txtServiciosAgregados.Location = new Point(359, 165);
            txtServiciosAgregados.Multiline = true;
            txtServiciosAgregados.Name = "txtServiciosAgregados";
            txtServiciosAgregados.Size = new Size(261, 191);
            txtServiciosAgregados.TabIndex = 9;
            // 
            // btnAgregarServicio
            // 
            btnAgregarServicio.BackColor = Color.DimGray;
            btnAgregarServicio.Font = new Font("Segoe UI", 10F);
            btnAgregarServicio.ForeColor = Color.White;
            btnAgregarServicio.Location = new Point(412, 118);
            btnAgregarServicio.Name = "btnAgregarServicio";
            btnAgregarServicio.Size = new Size(146, 41);
            btnAgregarServicio.TabIndex = 10;
            btnAgregarServicio.Text = "Agregar Servicio";
            btnAgregarServicio.UseVisualStyleBackColor = false;
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Font = new Font("Segoe UI", 18F);
            lblServicio.ForeColor = Color.White;
            lblServicio.Location = new Point(379, 54);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(202, 32);
            lblServicio.TabIndex = 12;
            lblServicio.Text = "Servicio Adicional";
            // 
            // cbServicioAdicional
            // 
            cbServicioAdicional.BackColor = SystemColors.WindowFrame;
            cbServicioAdicional.ForeColor = Color.White;
            cbServicioAdicional.FormattingEnabled = true;
            cbServicioAdicional.Location = new Point(379, 89);
            cbServicioAdicional.Name = "cbServicioAdicional";
            cbServicioAdicional.Size = new Size(210, 23);
            cbServicioAdicional.TabIndex = 11;
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.Font = new Font("Segoe UI", 18F);
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(108, 9);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(384, 32);
            labelFormulario1.TabIndex = 13;
            labelFormulario1.Text = "Agregar nuevo recinto al complejo";
            // 
            // AgregarRecinto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 369);
            Controls.Add(labelFormulario1);
            Controls.Add(txtServiciosAgregados);
            Controls.Add(btnAgregarServicio);
            Controls.Add(lblServicio);
            Controls.Add(cbServicioAdicional);
            Controls.Add(btnAgregar);
            Controls.Add(txtUbicacion);
            Controls.Add(lblUbicacion);
            Controls.Add(cbTipo);
            Controls.Add(lblTipo);
            Controls.Add(txtTarifa);
            Controls.Add(lblTarifa);
            Controls.Add(txtNumCancha);
            Controls.Add(lblNumero);
            Name = "AgregarRecinto";
            Text = "AgregarCancha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelFormulario lblNumero;
        public TextoNumerico txtNumCancha;
        private LabelFormulario lblTarifa;
        public TextoNumerico txtTarifa;
        private LabelFormulario lblTipo;
        public ComboBoxEstandar cbTipo;
        private LabelFormulario lblUbicacion;
        public Texto txtUbicacion;
        private BotonFormulario btnAgregar;
        public Texto txtServiciosAgregados;
        private BotonFormulario btnAgregarServicio;
        private LabelFormulario lblServicio;
        private ComboBoxEstandar cbServicioAdicional;
        private LabelFormulario labelFormulario1;
    }
}