using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion.Recepcionista
{
    internal class ProgramarReserva : FormularioEstandar
    {

        public ProgramarReserva()
        {

            InitializeComponent();

        }



        private void InitializeComponent()
        {
            cbCliente = new ComboBoxEstandar();
            labelFormulario1 = new LabelFormulario();
            labelFormulario2 = new LabelFormulario();
            labelFormulario3 = new LabelFormulario();
            cbRecinto = new ComboBoxEstandar();
            fecha = new DateTimePicker();
            labelFormulario4 = new LabelFormulario();
            cbHora = new ComboBoxEstandar();
            labelFormulario5 = new LabelFormulario();
            btnAgendar = new BotonFormulario();
            cbServicioAdicional = new ComboBoxEstandar();
            lblServicio = new LabelFormulario();
            btnAgregarServicio = new BotonFormulario();
            labelFormulario6 = new LabelFormulario();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbCliente
            // 
            cbCliente.BackColor = SystemColors.WindowFrame;
            cbCliente.ForeColor = Color.White;
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(34, 69);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(274, 23);
            cbCliente.TabIndex = 0;
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.Font = new Font("Segoe UI", 15F);
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(185, 9);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(237, 28);
            labelFormulario1.TabIndex = 1;
            labelFormulario1.Text = "Programar Nueva Reserva";
            labelFormulario1.Click += labelFormulario1_Click;
            // 
            // labelFormulario2
            // 
            labelFormulario2.AutoSize = true;
            labelFormulario2.Font = new Font("Segoe UI", 15F);
            labelFormulario2.ForeColor = Color.White;
            labelFormulario2.Location = new Point(128, 38);
            labelFormulario2.Name = "labelFormulario2";
            labelFormulario2.Size = new Size(76, 28);
            labelFormulario2.TabIndex = 2;
            labelFormulario2.Text = "Cliente:";
            // 
            // labelFormulario3
            // 
            labelFormulario3.AutoSize = true;
            labelFormulario3.Font = new Font("Segoe UI", 15F);
            labelFormulario3.ForeColor = Color.White;
            labelFormulario3.Location = new Point(128, 98);
            labelFormulario3.Name = "labelFormulario3";
            labelFormulario3.Size = new Size(81, 28);
            labelFormulario3.TabIndex = 4;
            labelFormulario3.Text = "Recinto:";
            // 
            // cbRecinto
            // 
            cbRecinto.BackColor = SystemColors.WindowFrame;
            cbRecinto.ForeColor = Color.White;
            cbRecinto.FormattingEnabled = true;
            cbRecinto.Location = new Point(34, 129);
            cbRecinto.Name = "cbRecinto";
            cbRecinto.Size = new Size(274, 23);
            cbRecinto.TabIndex = 3;
            // 
            // fecha
            // 
            fecha.Location = new Point(34, 196);
            fecha.Name = "fecha";
            fecha.Size = new Size(274, 23);
            fecha.TabIndex = 5;
            // 
            // labelFormulario4
            // 
            labelFormulario4.AutoSize = true;
            labelFormulario4.Font = new Font("Segoe UI", 15F);
            labelFormulario4.ForeColor = Color.White;
            labelFormulario4.Location = new Point(138, 165);
            labelFormulario4.Name = "labelFormulario4";
            labelFormulario4.Size = new Size(66, 28);
            labelFormulario4.TabIndex = 6;
            labelFormulario4.Text = "Fecha:";
            // 
            // cbHora
            // 
            cbHora.BackColor = SystemColors.WindowFrame;
            cbHora.ForeColor = Color.White;
            cbHora.FormattingEnabled = true;
            cbHora.Items.AddRange(new object[] { "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            cbHora.Location = new Point(112, 263);
            cbHora.Name = "cbHora";
            cbHora.Size = new Size(82, 23);
            cbHora.TabIndex = 0;
            // 
            // labelFormulario5
            // 
            labelFormulario5.AutoSize = true;
            labelFormulario5.Font = new Font("Segoe UI", 15F);
            labelFormulario5.ForeColor = Color.White;
            labelFormulario5.Location = new Point(128, 232);
            labelFormulario5.Name = "labelFormulario5";
            labelFormulario5.Size = new Size(59, 28);
            labelFormulario5.TabIndex = 7;
            labelFormulario5.Text = "Hora:";
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = Color.DimGray;
            btnAgendar.Font = new Font("Segoe UI", 10F);
            btnAgendar.ForeColor = Color.White;
            btnAgendar.Location = new Point(92, 327);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(146, 41);
            btnAgendar.TabIndex = 0;
            btnAgendar.Text = "Agendar Reserva";
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // cbServicioAdicional
            // 
            cbServicioAdicional.BackColor = SystemColors.WindowFrame;
            cbServicioAdicional.ForeColor = Color.White;
            cbServicioAdicional.FormattingEnabled = true;
            cbServicioAdicional.Location = new Point(378, 79);
            cbServicioAdicional.Name = "cbServicioAdicional";
            cbServicioAdicional.Size = new Size(210, 23);
            cbServicioAdicional.TabIndex = 0;
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Font = new Font("Segoe UI", 15F);
            lblServicio.ForeColor = Color.White;
            lblServicio.Location = new Point(399, 48);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(168, 28);
            lblServicio.TabIndex = 8;
            lblServicio.Text = "Servicio Adicional";
            // 
            // btnAgregarServicio
            // 
            btnAgregarServicio.BackColor = Color.DimGray;
            btnAgregarServicio.Font = new Font("Segoe UI", 10F);
            btnAgregarServicio.ForeColor = Color.White;
            btnAgregarServicio.Location = new Point(412, 125);
            btnAgregarServicio.Name = "btnAgregarServicio";
            btnAgregarServicio.Size = new Size(146, 41);
            btnAgregarServicio.TabIndex = 0;
            btnAgregarServicio.Text = "Agregar Servicio";
            btnAgregarServicio.UseVisualStyleBackColor = false;
            // 
            // labelFormulario6
            // 
            labelFormulario6.AutoSize = true;
            labelFormulario6.Font = new Font("Segoe UI", 15F);
            labelFormulario6.ForeColor = Color.White;
            labelFormulario6.Location = new Point(125, 296);
            labelFormulario6.Name = "labelFormulario6";
            labelFormulario6.Size = new Size(85, 28);
            labelFormulario6.TabIndex = 9;
            labelFormulario6.Text = "Total: $0";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(343, 183);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(292, 150);
            dataGridView1.TabIndex = 10;
            // 
            // ProgramarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(662, 396);
            Controls.Add(dataGridView1);
            Controls.Add(labelFormulario6);
            Controls.Add(btnAgregarServicio);
            Controls.Add(lblServicio);
            Controls.Add(cbServicioAdicional);
            Controls.Add(btnAgendar);
            Controls.Add(labelFormulario5);
            Controls.Add(cbHora);
            Controls.Add(labelFormulario4);
            Controls.Add(fecha);
            Controls.Add(labelFormulario3);
            Controls.Add(cbRecinto);
            Controls.Add(labelFormulario2);
            Controls.Add(labelFormulario1);
            Controls.Add(cbCliente);
            Name = "ProgramarReserva";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBoxEstandar cbCliente;
        private LabelFormulario labelFormulario1;
        private LabelFormulario labelFormulario2;
        private LabelFormulario labelFormulario3;
        private DateTimePicker fecha;
        private LabelFormulario labelFormulario4;
        private ComboBoxEstandar cbHora;
        private LabelFormulario labelFormulario5;
        private BotonFormulario btnAgendar;
        private ComboBoxEstandar cbServicioAdicional;
        private LabelFormulario lblServicio;
        private BotonFormulario btnAgregarServicio;
        private LabelFormulario labelFormulario6;
        private DataGridView dataGridView1;
        private ComboBoxEstandar cbRecinto;

        private void labelFormulario1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            if (cbCliente.Text.IsNullOrEmpty() || cbRecinto.Text.IsNullOrEmpty() || cbHora.Text.IsNullOrEmpty() || fecha.Text.IsNullOrEmpty()
                /*cbCliente.Text.IsNullOrEmpty() || cbRecinto.Text.IsNullOrEmpty() || txtUbicacion.Text.IsNullOrEmpty() || cbTipo.Text.IsNullOrEmpty()*/)
            {
                List<String> vacios = new List<String>();
                if (cbCliente.Text.IsNullOrEmpty())
                {
                    vacios.Add("Cliente");
                }
                if (cbRecinto.Text.IsNullOrEmpty())
                {
                    vacios.Add("Recinto");
                }
                if (fecha.Text.IsNullOrEmpty())
                {
                    vacios.Add("Fecha");
                }
                if (cbHora.Text.IsNullOrEmpty())
                {
                    vacios.Add("Hora");
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
        }
    }
}
