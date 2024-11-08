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
            tablaDatos.setDatoModelo(new Pago(0,new Reserva(1,new Recinto(),new Cliente(),new DateOnly(),new TimeOnly(),new Usuario())));
        }

        private TablaDatos tabla;

        override public void RefrescarCB()
        {
            //TODO
        }

        private void InitializeComponent()
        {
            tabla = new TablaDatos();
            tablaDatos = new TablaDatos();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablaDatos).BeginInit();
            SuspendLayout();
            // 
            // tabla
            // 
            tabla.Location = new Point(0, 0);
            tabla.Name = "tabla";
            tabla.Size = new Size(240, 150);
            tabla.TabIndex = 0;
            // 
            // tablaDatos
            // 
            tablaDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaDatos.Location = new Point(41, 31);
            tablaDatos.Name = "tablaDatos";
            tablaDatos.Size = new Size(726, 312);
            tablaDatos.TabIndex = 0;
            // 
            // ListarPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(800, 450);
            Controls.Add(tablaDatos);
            Name = "ListarPagos";
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablaDatos).EndInit();
            ResumeLayout(false);
        }

        private TablaDatos tablaDatos;
    }
}
