using AdministracionPolideportivo.CNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion.Recepcionista
{
    internal class BuscarReserva : FormularioEstandar
    {
        public BuscarReserva()
        {

            InitializeComponent();
            tablaDatos1.setDatoModelo(new Reserva(1,new Recinto(),new Cliente(), new DateOnly(),new TimeOnly()));

        }

        private void InitializeComponent()
        {
            labelFormulario1 = new LabelFormulario();
            cbBuscar = new ComboBoxEstandar();
            texto1 = new Texto();
            btnBuscar = new BotonFormulario();
            tablaDatos1 = new TablaDatos();
            ((System.ComponentModel.ISupportInitialize)tablaDatos1).BeginInit();
            SuspendLayout();
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.Font = new Font("Segoe UI", 15F);
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(301, 9);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(175, 28);
            labelFormulario1.TabIndex = 0;
            labelFormulario1.Text = "Buscar Reserva por";
            // 
            // cbBuscar
            // 
            cbBuscar.BackColor = SystemColors.WindowFrame;
            cbBuscar.ForeColor = Color.White;
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Items.AddRange(new object[] { "Nombre", "Fecha", "Recinto", "Deporte", "Servicio " });
            cbBuscar.Location = new Point(289, 40);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(210, 23);
            cbBuscar.TabIndex = 0;
            // 
            // texto1
            // 
            texto1.BackColor = SystemColors.WindowFrame;
            texto1.ForeColor = Color.White;
            texto1.Location = new Point(269, 86);
            texto1.Name = "texto1";
            texto1.Size = new Size(249, 23);
            texto1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DimGray;
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(319, 130);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 41);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar Reserva";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // tablaDatos1
            // 
            tablaDatos1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaDatos1.Location = new Point(12, 187);
            tablaDatos1.Name = "tablaDatos1";
            tablaDatos1.Size = new Size(766, 212);
            tablaDatos1.TabIndex = 1;
            // 
            // BuscarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(790, 411);
            Controls.Add(tablaDatos1);
            Controls.Add(btnBuscar);
            Controls.Add(texto1);
            Controls.Add(cbBuscar);
            Controls.Add(labelFormulario1);
            Name = "BuscarReserva";
            ((System.ComponentModel.ISupportInitialize)tablaDatos1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private LabelFormulario labelFormulario1;
        private ComboBoxEstandar cbBuscar;
        private Texto texto1;
        private TablaDatos tablaDatos1;
        private BotonFormulario btnBuscar;
    }
}
