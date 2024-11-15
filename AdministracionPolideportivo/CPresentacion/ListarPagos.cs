using AdministracionPolideportivo.CDatos;
using AdministracionPolideportivo.CNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class ListarPagos : FormularioEstandar
    {
        public ListarPagos()
        {
            InitializeComponent();
            tablaDatos.setDatoModelo(new Pago(0,new Reserva(1,new Recinto(),new Cliente(),new DateOnly(),new TimeOnly(),new Usuario()),DALUsuario.BuscarPorID(1.ToString()).First(),new MedioPago(6,""),0));
            tablaDatos.DataSource = DALPago.ListarPagos();
        }


        override public void RefrescarCB()
        {
            //TODO
        }

        private void InitializeComponent()
        {
            tablaDatos = new TablaDatos();
            labelFormulario1 = new LabelFormulario();
            ((System.ComponentModel.ISupportInitialize)tablaDatos).BeginInit();
            SuspendLayout();

            // 
            // tablaDatos
            // 
            tablaDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaDatos.Location = new Point(25, 64);
            tablaDatos.MinimumSize = new Size(736, 328);
            tablaDatos.Name = "tablaDatos";
            tablaDatos.Size = new Size(736, 328);
            tablaDatos.TabIndex = 0;
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.Font = new Font("Segoe UI", 15F);
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(300, 9);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(137, 28);
            labelFormulario1.TabIndex = 1;
            labelFormulario1.Text = "Lista de pagos";
            // 
            // ListarPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScroll = true;
            AutoScrollMinSize = new Size(840, 480);
            ClientSize = new Size(800, 450);
            Controls.Add(labelFormulario1);
            Controls.Add(tablaDatos);
            MinimumSize = new Size(800, 450);
            Name = "ListarPagos";
            ((System.ComponentModel.ISupportInitialize)tablaDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TablaDatos tablaDatos;
        private LabelFormulario labelFormulario1;
    }
}
