using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion.Recepcionista
{
    internal class AgregarServicioAdicional : FormularioEstandar
    {

        public AgregarServicioAdicional()
        {

            InitializeComponent();

        }

        private void InitializeComponent()
        {
            lblNombre = new LabelFormulario();
            lblDescripcion = new LabelFormulario();
            lblTarifa = new LabelFormulario();
            txtNombre = new Texto();
            txtDescripcion = new Texto();
            txtTarifa = new TextoNumerico();
            btnAgregar = new BotonFormulario();
            cbRecintos = new ComboBoxEstandar();
            labelFormulario1 = new LabelFormulario();
            btnHabilitarRecinto = new BotonFormulario();
            rbHabilitarTodos = new RadioButton();
            rbElegirRecintos = new RadioButton();
            lblUltimoRecinto = new LabelFormulario();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(31, 21);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(114, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del Servicio";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = Color.White;
            lblDescripcion.Location = new Point(76, 50);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción";
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.ForeColor = Color.White;
            lblTarifa.Location = new Point(48, 76);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(97, 15);
            lblTarifa.TabIndex = 2;
            lblTarifa.Text = "Tarifa del servicio";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.WindowFrame;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(151, 18);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = SystemColors.WindowFrame;
            txtDescripcion.ForeColor = Color.White;
            txtDescripcion.Location = new Point(151, 47);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(210, 23);
            txtDescripcion.TabIndex = 0;
            // 
            // txtTarifa
            // 
            txtTarifa.BackColor = SystemColors.WindowFrame;
            txtTarifa.ForeColor = Color.White;
            txtTarifa.Location = new Point(151, 76);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(210, 23);
            txtTarifa.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DimGray;
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(141, 315);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(146, 41);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Servicio";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // cbRecintos
            // 
            cbRecintos.BackColor = SystemColors.WindowFrame;
            cbRecintos.ForeColor = Color.White;
            cbRecintos.FormattingEnabled = true;
            cbRecintos.Location = new Point(78, 207);
            cbRecintos.Name = "cbRecintos";
            cbRecintos.Size = new Size(285, 23);
            cbRecintos.TabIndex = 0;
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(120, 179);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(184, 15);
            labelFormulario1.TabIndex = 3;
            labelFormulario1.Text = "Habilitar para el siguiente recinto:";
            // 
            // btnHabilitarRecinto
            // 
            btnHabilitarRecinto.BackColor = Color.DimGray;
            btnHabilitarRecinto.Font = new Font("Segoe UI", 10F);
            btnHabilitarRecinto.ForeColor = Color.White;
            btnHabilitarRecinto.Location = new Point(110, 236);
            btnHabilitarRecinto.Name = "btnHabilitarRecinto";
            btnHabilitarRecinto.Size = new Size(216, 41);
            btnHabilitarRecinto.TabIndex = 0;
            btnHabilitarRecinto.Text = "Habilitar para el recinto";
            btnHabilitarRecinto.UseVisualStyleBackColor = false;
            // 
            // rbHabilitarTodos
            // 
            rbHabilitarTodos.AutoSize = true;
            rbHabilitarTodos.ForeColor = Color.White;
            rbHabilitarTodos.Location = new Point(13, 27);
            rbHabilitarTodos.Name = "rbHabilitarTodos";
            rbHabilitarTodos.Size = new Size(192, 19);
            rbHabilitarTodos.TabIndex = 4;
            rbHabilitarTodos.TabStop = true;
            rbHabilitarTodos.Text = "Habilitar para todos los recintos";
            rbHabilitarTodos.UseVisualStyleBackColor = true;
            rbHabilitarTodos.CheckedChanged += rbHabilitarTodos_CheckedChanged;
            // 
            // rbElegirRecintos
            // 
            rbElegirRecintos.AutoSize = true;
            rbElegirRecintos.ForeColor = Color.White;
            rbElegirRecintos.Location = new Point(13, 52);
            rbElegirRecintos.Name = "rbElegirRecintos";
            rbElegirRecintos.Size = new Size(279, 19);
            rbElegirRecintos.TabIndex = 5;
            rbElegirRecintos.TabStop = true;
            rbElegirRecintos.Text = "Habilitar para una lista personalizada de recintos";
            rbElegirRecintos.UseVisualStyleBackColor = true;
            // 
            // lblUltimoRecinto
            // 
            lblUltimoRecinto.AutoSize = true;
            lblUltimoRecinto.ForeColor = Color.White;
            lblUltimoRecinto.Location = new Point(12, 288);
            lblUltimoRecinto.Name = "lblUltimoRecinto";
            lblUltimoRecinto.Size = new Size(132, 15);
            lblUltimoRecinto.TabIndex = 6;
            lblUltimoRecinto.Text = "Ultimo recinto añadido:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbElegirRecintos);
            groupBox1.Controls.Add(rbHabilitarTodos);
            groupBox1.Location = new Point(69, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 71);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // AgregarServicioAdicional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(426, 368);
            Controls.Add(groupBox1);
            Controls.Add(lblUltimoRecinto);
            Controls.Add(btnHabilitarRecinto);
            Controls.Add(labelFormulario1);
            Controls.Add(cbRecintos);
            Controls.Add(btnAgregar);
            Controls.Add(txtTarifa);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblTarifa);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Name = "AgregarServicioAdicional";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private LabelFormulario lblNombre;
        private LabelFormulario lblTarifa;
        private Texto txtNombre;
        private Texto txtDescripcion;
        private TextoNumerico txtTarifa;
        private BotonFormulario btnAgregar;
        private ComboBoxEstandar cbRecintos;
        private LabelFormulario labelFormulario1;
        private BotonFormulario btnHabilitarRecinto;
        private RadioButton rbHabilitarTodos;
        private RadioButton rbElegirRecintos;
        private LabelFormulario lblUltimoRecinto;
        private GroupBox groupBox1;
        private LabelFormulario lblDescripcion;

        private void rbHabilitarTodos_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
