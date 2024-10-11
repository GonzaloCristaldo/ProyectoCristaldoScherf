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
            ubiPanel1 = 20;
            anchoPaneles = (this.Width / 2) - 50;
            ubiPanel2 = anchoPaneles + 30;
            UbicarControles();
        }

        int anchoPaneles;

        int ubiPanel1;
        int ubiPanel2;


        private void UbicarControles()
        {
            anchoPaneles = (this.Width / 2) - 25;
            panelIzquierda.Width = anchoPaneles;
            panelDerecha.Width = anchoPaneles;

            ubiPanel1 = 20;

            ubiPanel2 = anchoPaneles + 30;

            panelIzquierda.Location = new Point(ubiPanel1, panelIzquierda.Location.Y);
            panelDerecha.Location = new Point(ubiPanel2, panelDerecha.Location.Y);

            cbCliente.Width = panelIzquierda.Width - 40;
            cbCliente.Location = new Point(ubiPanel1, cbCliente.Location.Y);
            cbRecinto.Width = panelIzquierda.Width - 40;
            cbRecinto.Location = new Point(ubiPanel1, cbRecinto.Location.Y);
            fecha.Width = panelIzquierda.Width - 40;
            fecha.Location = new Point(ubiPanel1, fecha.Location.Y);

            cbHora.Location = new Point((panelIzquierda.Width - cbHora.Width) / 2, cbHora.Location.Y);

            cbServicioAdicional.Width = panelDerecha.Width - 40;
            cbServicioAdicional.Location = new Point(ubiPanel1, cbServicioAdicional.Location.Y);

            tabla.Width = panelDerecha.Width;
            tabla.Location= new Point(0, btnAgregarServicio.Location.Y+btnAgregarServicio.Height+15);
            btnAgregarServicio.Location = new Point((panelDerecha.Width - btnAgregarServicio.Width) / 2, btnAgregarServicio.Location.Y);
            btnAgendar.Location = new Point((panelIzquierda.Width - btnAgendar.Width) / 2, btnAgendar.Location.Y);
            lblServicio.Location = new Point((panelDerecha.Width-lblServicio.Width)/2,lblServicio.Location.Y);

            lblCliente.Location = new Point((panelIzquierda.Width - lblCliente.Width) / 2, lblCliente.Location.Y);
            lblRecinto.Location = new Point((panelIzquierda.Width - lblRecinto.Width) / 2, lblRecinto.Location.Y);
            lblFecha.Location = new Point((panelIzquierda.Width - lblFecha.Width) / 2, lblFecha.Location.Y);
            lblHora.Location = new Point((panelIzquierda.Width - lblHora.Width) / 2, lblHora.Location.Y);
            lblTotal.Location = new Point((panelIzquierda.Width - lblTotal.Width) / 2, lblTotal.Location.Y);
            lblTitulo.Location = new Point((this.Width - lblTitulo.Width) / 2, lblTitulo.Location.Y);
        }

        private void InitializeComponent()
        {
            cbCliente = new ComboBoxEstandar();
            lblTitulo = new LabelFormulario();
            lblCliente = new LabelFormulario();
            lblRecinto = new LabelFormulario();
            cbRecinto = new ComboBoxEstandar();
            fecha = new DateTimePicker();
            lblFecha = new LabelFormulario();
            cbHora = new ComboBoxEstandar();
            lblHora = new LabelFormulario();
            btnAgendar = new BotonFormulario();
            cbServicioAdicional = new ComboBoxEstandar();
            lblServicio = new LabelFormulario();
            btnAgregarServicio = new BotonFormulario();
            lblTotal = new LabelFormulario();
            tabla = new DataGridView();
            panelDerecha = new Panel();
            panelIzquierda = new Panel();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            panelDerecha.SuspendLayout();
            panelIzquierda.SuspendLayout();
            SuspendLayout();
            // 
            // cbCliente
            // 
            cbCliente.BackColor = SystemColors.WindowFrame;
            cbCliente.ForeColor = Color.White;
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(23, 30);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(274, 23);
            cbCliente.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(185, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(237, 28);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Programar Nueva Reserva";
            lblTitulo.Click += labelFormulario1_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 15F);
            lblCliente.ForeColor = Color.White;
            lblCliente.Location = new Point(117, -1);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(76, 28);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Cliente:";
            // 
            // lblRecinto
            // 
            lblRecinto.AutoSize = true;
            lblRecinto.Font = new Font("Segoe UI", 15F);
            lblRecinto.ForeColor = Color.White;
            lblRecinto.Location = new Point(117, 59);
            lblRecinto.Name = "lblRecinto";
            lblRecinto.Size = new Size(81, 28);
            lblRecinto.TabIndex = 4;
            lblRecinto.Text = "Recinto:";
            // 
            // cbRecinto
            // 
            cbRecinto.BackColor = SystemColors.WindowFrame;
            cbRecinto.ForeColor = Color.White;
            cbRecinto.FormattingEnabled = true;
            cbRecinto.Location = new Point(23, 90);
            cbRecinto.Name = "cbRecinto";
            cbRecinto.Size = new Size(274, 23);
            cbRecinto.TabIndex = 3;
            // 
            // fecha
            // 
            fecha.Location = new Point(23, 157);
            fecha.Name = "fecha";
            fecha.Size = new Size(274, 23);
            fecha.TabIndex = 5;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 15F);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(117, 126);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(66, 28);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha:";
            // 
            // cbHora
            // 
            cbHora.BackColor = SystemColors.WindowFrame;
            cbHora.ForeColor = Color.White;
            cbHora.FormattingEnabled = true;
            cbHora.Items.AddRange(new object[] { "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            cbHora.Location = new Point(101, 224);
            cbHora.Name = "cbHora";
            cbHora.Size = new Size(82, 23);
            cbHora.TabIndex = 0;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 15F);
            lblHora.ForeColor = Color.White;
            lblHora.Location = new Point(117, 193);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(59, 28);
            lblHora.TabIndex = 7;
            lblHora.Text = "Hora:";
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = Color.DimGray;
            btnAgendar.Font = new Font("Segoe UI", 10F);
            btnAgendar.ForeColor = Color.White;
            btnAgendar.Location = new Point(81, 288);
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
            cbServicioAdicional.Location = new Point(52, 44);
            cbServicioAdicional.Name = "cbServicioAdicional";
            cbServicioAdicional.Size = new Size(210, 23);
            cbServicioAdicional.TabIndex = 0;
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Font = new Font("Segoe UI", 15F);
            lblServicio.ForeColor = Color.White;
            lblServicio.Location = new Point(73, 13);
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
            btnAgregarServicio.Location = new Point(86, 90);
            btnAgregarServicio.Name = "btnAgregarServicio";
            btnAgregarServicio.Size = new Size(146, 41);
            btnAgregarServicio.TabIndex = 0;
            btnAgregarServicio.Text = "Agregar Servicio";
            btnAgregarServicio.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 15F);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(117, 257);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(85, 28);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total: $0";
            // 
            // tabla
            // 
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Location = new Point(17, 148);
            tabla.Name = "tabla";
            tabla.Size = new Size(292, 150);
            tabla.TabIndex = 10;
            // 
            // panelDerecha
            // 
            panelDerecha.Controls.Add(cbServicioAdicional);
            panelDerecha.Controls.Add(tabla);
            panelDerecha.Controls.Add(lblServicio);
            panelDerecha.Controls.Add(btnAgregarServicio);
            panelDerecha.Location = new Point(347, 50);
            panelDerecha.Name = "panelDerecha";
            panelDerecha.Size = new Size(326, 347);
            panelDerecha.TabIndex = 11;
            // 
            // panelIzquierda
            // 
            panelIzquierda.Controls.Add(cbCliente);
            panelIzquierda.Controls.Add(lblCliente);
            panelIzquierda.Controls.Add(lblTotal);
            panelIzquierda.Controls.Add(cbRecinto);
            panelIzquierda.Controls.Add(btnAgendar);
            panelIzquierda.Controls.Add(lblRecinto);
            panelIzquierda.Controls.Add(lblHora);
            panelIzquierda.Controls.Add(fecha);
            panelIzquierda.Controls.Add(cbHora);
            panelIzquierda.Controls.Add(lblFecha);
            panelIzquierda.Location = new Point(12, 50);
            panelIzquierda.Name = "panelIzquierda";
            panelIzquierda.Size = new Size(320, 347);
            panelIzquierda.TabIndex = 12;
            // 
            // ProgramarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(688, 415);
            Controls.Add(panelIzquierda);
            Controls.Add(panelDerecha);
            Controls.Add(lblTitulo);
            MinimumSize = new Size(688, 415);
            Name = "ProgramarReserva";
            Resize += ProgramarReserva_Resize;
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            panelDerecha.ResumeLayout(false);
            panelDerecha.PerformLayout();
            panelIzquierda.ResumeLayout(false);
            panelIzquierda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBoxEstandar cbCliente;
        private LabelFormulario lblTitulo;
        private LabelFormulario lblCliente;
        private LabelFormulario lblRecinto;
        private DateTimePicker fecha;
        private LabelFormulario lblFecha;
        private ComboBoxEstandar cbHora;
        private LabelFormulario lblHora;
        private BotonFormulario btnAgendar;
        private ComboBoxEstandar cbServicioAdicional;
        private LabelFormulario lblServicio;
        private BotonFormulario btnAgregarServicio;
        private LabelFormulario lblTotal;
        private DataGridView tabla;
        private Panel panelDerecha;
        private Panel panelIzquierda;
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

        private void ProgramarReserva_Resize(object sender, EventArgs e)
        {
           UbicarControles();
        }
    }
}
