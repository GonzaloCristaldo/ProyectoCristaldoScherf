using Microsoft.IdentityModel.Tokens;
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
            texto1 = new Texto();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 18F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(12, 12);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(237, 32);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del Servicio:";
            lblNombre.Click += lblNombre_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 18F);
            lblDescripcion.ForeColor = Color.White;
            lblDescripcion.Location = new Point(12, 47);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(143, 32);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción:";
            lblDescripcion.Click += lblDescripcion_Click;
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Font = new Font("Segoe UI", 18F);
            lblTarifa.ForeColor = Color.White;
            lblTarifa.Location = new Point(12, 79);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(202, 32);
            lblTarifa.TabIndex = 2;
            lblTarifa.Text = "Tarifa del servicio:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.WindowFrame;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(251, 21);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(172, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = SystemColors.WindowFrame;
            txtDescripcion.ForeColor = Color.White;
            txtDescripcion.Location = new Point(251, 56);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(210, 23);
            txtDescripcion.TabIndex = 0;
            // 
            // txtTarifa
            // 
            txtTarifa.BackColor = SystemColors.WindowFrame;
            txtTarifa.ForeColor = Color.White;
            txtTarifa.Location = new Point(251, 88);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(210, 23);
            txtTarifa.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DimGray;
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(215, 362);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(146, 41);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Servicio";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbRecintos
            // 
            cbRecintos.BackColor = SystemColors.WindowFrame;
            cbRecintos.ForeColor = Color.White;
            cbRecintos.FormattingEnabled = true;
            cbRecintos.Location = new Point(138, 254);
            cbRecintos.Name = "cbRecintos";
            cbRecintos.Size = new Size(285, 23);
            cbRecintos.TabIndex = 0;
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.Font = new Font("Segoe UI", 18F);
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(93, 209);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(373, 32);
            labelFormulario1.TabIndex = 3;
            labelFormulario1.Text = "Habilitar para el siguiente recinto:";
            // 
            // btnHabilitarRecinto
            // 
            btnHabilitarRecinto.BackColor = Color.DimGray;
            btnHabilitarRecinto.Font = new Font("Segoe UI", 10F);
            btnHabilitarRecinto.ForeColor = Color.White;
            btnHabilitarRecinto.Location = new Point(173, 283);
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
            rbHabilitarTodos.Location = new Point(13, 17);
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
            lblUltimoRecinto.Font = new Font("Segoe UI", 18F);
            lblUltimoRecinto.ForeColor = Color.White;
            lblUltimoRecinto.Location = new Point(10, 327);
            lblUltimoRecinto.Name = "lblUltimoRecinto";
            lblUltimoRecinto.Size = new Size(264, 32);
            lblUltimoRecinto.TabIndex = 6;
            lblUltimoRecinto.Text = "Ultimo recinto añadido:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbElegirRecintos);
            groupBox1.Controls.Add(rbHabilitarTodos);
            groupBox1.Location = new Point(124, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 87);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // texto1
            // 
            texto1.BackColor = SystemColors.WindowFrame;
            texto1.ForeColor = Color.White;
            texto1.Location = new Point(280, 336);
            texto1.Name = "texto1";
            texto1.Size = new Size(210, 23);
            texto1.TabIndex = 0;
            // 
            // AgregarServicioAdicional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(589, 425);
            Controls.Add(texto1);
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
        private Texto texto1;
        private LabelFormulario lblDescripcion;

        private void rbHabilitarTodos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.IsNullOrEmpty() || txtTarifa.Text.IsNullOrEmpty() || txtDescripcion.Text.IsNullOrEmpty())
            {
                List<String> vacios = new List<String>();
                if (txtNombre.Text.IsNullOrEmpty())
                {
                    vacios.Add("Nombre del servicio");
                }
                if (txtTarifa.Text.IsNullOrEmpty())
                {
                    vacios.Add("Tarifa");
                }
                if (txtDescripcion.Text.IsNullOrEmpty())
                {
                    vacios.Add("Descripción");
                }
                String mensaje = "Por favor, complete los siguientes campos: ";
                for (int i = 0; i < vacios.Count; i++)
                {
                    if (i + 1 < vacios.Count)
                    {
                        mensaje += vacios[i] + ", ";
                    }
                    else
                    {
                        mensaje += vacios[i] + ".";
                    }

                }
                MessageBox.Show(mensaje);
                return;
            }
            else
            {
                var confirmResult = MessageBox.Show("¿Estas seguro que deseas agregar un nuevo servicio adicional?",
                                     "Confirmar alta de servicio adicional",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (confirmResult == DialogResult.Yes)
                { }
            }
        }
    }
}
