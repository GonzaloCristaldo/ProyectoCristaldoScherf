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
            this.MinimumSize = new Size(cajaHabilitar.Width+40,btnAgregar.Location.Y+btnAgregar.Height+15);
            UbicarControles();
        }

        private void UbicarControles()
        {

            lblDescripcion.Location = new System.Drawing.Point(lblNombre.Location.X,
                lblNombre.Location.Y + 40);
            lblTarifa.Location = new System.Drawing.Point(lblNombre.Location.X,
                lblNombre.Location.Y + 80);
            coordenadaXTextbox = lblNombre.Width + lblNombre.Location.X + 10;

            txtNombre.Location = new Point(coordenadaXTextbox, lblNombre.Location.Y);
            txtDescripcion.Location = new Point(coordenadaXTextbox, lblDescripcion.Location.Y);
            txtTarifa.Location = new Point(coordenadaXTextbox, lblTarifa.Location.Y);

            cajaHabilitar.Location = new Point((this.Width - cajaHabilitar.Width) / 2, lblTarifa.Location.Y + lblTarifa.Height + 10);
            lblHabilitar.Location = new Point((this.Width - lblHabilitar.Width) / 2, cajaHabilitar.Location.Y + cajaHabilitar.Height + 10);
            cbRecintos.Location = new Point((this.Width - cbRecintos.Width) / 2, lblHabilitar.Location.Y + lblHabilitar.Height + 10);
            btnHabilitarRecinto.Location = new Point((this.Width - btnHabilitarRecinto.Width) / 2, cbRecintos.Location.Y + cbRecintos.Height + 10);
            lblUltimoRecinto.Location = new Point(lblNombre.Location.X, btnHabilitarRecinto.Location.Y + btnHabilitarRecinto.Height + 10);
            txtRecinto.Location = new Point(lblUltimoRecinto.Width + lblUltimoRecinto.Location.X + 10, lblUltimoRecinto.Location.Y);
            btnAgregar.Location = new Point((this.Width - btnAgregar.Width) / 2, lblUltimoRecinto.Location.Y + lblUltimoRecinto.Height + 10);
        }

        int coordenadaXTextbox;

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
            lblHabilitar = new LabelFormulario();
            btnHabilitarRecinto = new BotonFormulario();
            rbHabilitarTodos = new RadioButton();
            rbElegirRecintos = new RadioButton();
            lblUltimoRecinto = new LabelFormulario();
            cajaHabilitar = new GroupBox();
            txtRecinto = new Texto();
            cajaHabilitar.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 13F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(12, 12);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(177, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del Servicio:";
            lblNombre.Click += lblNombre_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 13F);
            lblDescripcion.ForeColor = Color.White;
            lblDescripcion.Location = new Point(12, 56);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(108, 25);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción:";
            lblDescripcion.Click += lblDescripcion_Click;
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Font = new Font("Segoe UI", 13F);
            lblTarifa.ForeColor = Color.White;
            lblTarifa.Location = new Point(12, 98);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(150, 25);
            lblTarifa.TabIndex = 2;
            lblTarifa.Text = "Tarifa del servicio:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.WindowFrame;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(206, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = SystemColors.WindowFrame;
            txtDescripcion.ForeColor = Color.White;
            txtDescripcion.Location = new Point(251, 44);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(210, 23);
            txtDescripcion.TabIndex = 0;
            // 
            // txtTarifa
            // 
            txtTarifa.BackColor = SystemColors.WindowFrame;
            txtTarifa.ForeColor = Color.White;
            txtTarifa.Location = new Point(251, 83);
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
            // lblHabilitar
            // 
            lblHabilitar.AutoSize = true;
            lblHabilitar.Font = new Font("Segoe UI", 13F);
            lblHabilitar.ForeColor = Color.White;
            lblHabilitar.Location = new Point(93, 209);
            lblHabilitar.Name = "lblHabilitar";
            lblHabilitar.Size = new Size(275, 25);
            lblHabilitar.TabIndex = 3;
            lblHabilitar.Text = "Habilitar para el siguiente recinto:";
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
            lblUltimoRecinto.Font = new Font("Segoe UI", 13F);
            lblUltimoRecinto.ForeColor = Color.White;
            lblUltimoRecinto.Location = new Point(10, 327);
            lblUltimoRecinto.Name = "lblUltimoRecinto";
            lblUltimoRecinto.Size = new Size(198, 25);
            lblUltimoRecinto.TabIndex = 6;
            lblUltimoRecinto.Text = "Ultimo recinto añadido:";
            // 
            // cajaHabilitar
            // 
            cajaHabilitar.Controls.Add(rbElegirRecintos);
            cajaHabilitar.Controls.Add(rbHabilitarTodos);
            cajaHabilitar.Location = new Point(93, 126);
            cajaHabilitar.Name = "cajaHabilitar";
            cajaHabilitar.Size = new Size(323, 87);
            cajaHabilitar.TabIndex = 7;
            cajaHabilitar.TabStop = false;
            cajaHabilitar.Enter += groupBox1_Enter;
            // 
            // txtRecinto
            // 
            txtRecinto.BackColor = SystemColors.WindowFrame;
            txtRecinto.ForeColor = Color.White;
            txtRecinto.Location = new Point(214, 329);
            txtRecinto.Name = "txtRecinto";
            txtRecinto.Size = new Size(247, 23);
            txtRecinto.TabIndex = 0;
            // 
            // AgregarServicioAdicional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(478, 425);
            Controls.Add(txtRecinto);
            Controls.Add(cajaHabilitar);
            Controls.Add(lblUltimoRecinto);
            Controls.Add(btnHabilitarRecinto);
            Controls.Add(lblHabilitar);
            Controls.Add(cbRecintos);
            Controls.Add(btnAgregar);
            Controls.Add(txtTarifa);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblTarifa);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Name = "AgregarServicioAdicional";
            Resize += AgregarServicioAdicional_Resize;
            cajaHabilitar.ResumeLayout(false);
            cajaHabilitar.PerformLayout();
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
        private LabelFormulario lblHabilitar;
        private BotonFormulario btnHabilitarRecinto;
        private RadioButton rbHabilitarTodos;
        private RadioButton rbElegirRecintos;
        private LabelFormulario lblUltimoRecinto;
        private GroupBox cajaHabilitar;
        private Texto txtRecinto;
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

        private void AgregarServicioAdicional_Resize(object sender, EventArgs e)
        {
            /*Calculamos dinamicamente el espacio que debe ocupar los textbox
             tomando como referencia el ancho de la ventana y restando el espacio
            que ocupan los label y una cantidad de pixeles de separacion con el margen
            de la ventana*/
            int anchoTextBox = this.Width - coordenadaXTextbox - 20;

            //Le asignamos el nuevo tamaño calculado a cada textbox
            txtDescripcion.Width = anchoTextBox;
            txtTarifa.Width = anchoTextBox;
            txtNombre.Width = anchoTextBox;
            cbRecintos.Width = this.Width - 20;
            UbicarControles();
            
            txtRecinto.Width = this.Width - 20 - lblUltimoRecinto.Location.X - lblUltimoRecinto.Width - 10;
        }
    }
}
