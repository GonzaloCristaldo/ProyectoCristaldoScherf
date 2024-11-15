using AdministracionPolideportivo.CDatos;
using AdministracionPolideportivo.CNegocio;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class BuscarRecinto : FormularioEstandar
    {

        public void LabelFormulario1_Click()
        {
            ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10F); //Aca se establece el tamaño
        }

        private ComboBoxEstandar cbTipo;
        bool buscarPorTipo;

        private void CambiarFormaDeBusqueda(bool porTipo)
        {
            if (porTipo)
            {
                buscarPorTipo = true;
                labelFormulario1.Text = "Tipo de recinto";
                txtBuscar.Hide();
                cbTipo.Show();
            }
            else
            {
                buscarPorTipo = false;
                labelFormulario1.Text = "N° recinto";
                txtBuscar.Show();
                cbTipo.Hide();
            }
        }

        public BuscarRecinto()
        {
            buscarPorTipo = true;
            InitializeComponent();
            tablaDatos1.setDatoModelo(new Recinto());
            CambiarFormaDeBusqueda(buscarPorTipo);
            RefrescarCB();
        }

        override public void RefrescarCB()
        {
            //TODO
            cbTipo.DataSource = DALTipoRecinto.ListarTiposRecinto();
        }

        private BotonFormulario btnBuscar;
        private LabelFormulario lblBuscar;
        private BotonFormulario btnNRO;
        private BotonFormulario btnTipo;
        private LabelFormulario labelFormulario1;
        private TablaDatos tablaDatos1;
        private Texto txtBuscar;

        private void InitializeComponent()
        {
            btnBuscar = new BotonFormulario();
            lblBuscar = new LabelFormulario();
            txtBuscar = new Texto();
            btnNRO = new BotonFormulario();
            btnTipo = new BotonFormulario();
            labelFormulario1 = new LabelFormulario();
            tablaDatos1 = new TablaDatos();
            cbTipo = new ComboBoxEstandar();
            ((System.ComponentModel.ISupportInitialize)tablaDatos1).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DimGray;
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(468, 49);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 35);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar Recinto";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 18F);
            lblBuscar.ForeColor = Color.White;
            lblBuscar.Location = new Point(79, 7);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(544, 32);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Busqueda y Gestion de Recintos del Polideportivo";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.WindowFrame;
            txtBuscar.Cursor = Cursors.IBeam;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(243, 57);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(210, 23);
            txtBuscar.TabIndex = 0;
            // 
            // btnNRO
            // 
            btnNRO.BackColor = Color.DimGray;
            btnNRO.Font = new Font("Segoe UI", 10F);
            btnNRO.ForeColor = Color.White;
            btnNRO.Location = new Point(169, 98);
            btnNRO.Name = "btnNRO";
            btnNRO.Size = new Size(163, 41);
            btnNRO.TabIndex = 0;
            btnNRO.Text = "Buscar por Numero";
            btnNRO.UseVisualStyleBackColor = false;
            btnNRO.Click += btnNRO_Click;
            // 
            // btnTipo
            // 
            btnTipo.BackColor = Color.DimGray;
            btnTipo.Font = new Font("Segoe UI", 10F);
            btnTipo.ForeColor = Color.White;
            btnTipo.Location = new Point(354, 98);
            btnTipo.Name = "btnTipo";
            btnTipo.Size = new Size(176, 41);
            btnTipo.TabIndex = 3;
            btnTipo.Text = "Buscar por tipo";
            btnTipo.UseVisualStyleBackColor = false;
            btnTipo.Click += botonFormulario2_Click;
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.Font = new Font("Segoe UI", 18F);
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(44, 52);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(127, 32);
            labelFormulario1.TabIndex = 5;
            labelFormulario1.Text = "N° Recinto";
            labelFormulario1.Click += labelFormulario1_Click;
            // 
            // tablaDatos1
            // 
            tablaDatos1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaDatos1.Location = new Point(12, 155);
            tablaDatos1.Name = "tablaDatos1";
            tablaDatos1.Size = new Size(659, 233);
            tablaDatos1.TabIndex = 9;
            // 
            // cbTipo
            // 
            cbTipo.BackColor = SystemColors.WindowFrame;
            cbTipo.ForeColor = Color.White;
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(243, 57);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(210, 23);
            cbTipo.TabIndex = 0;
            // 
            // BuscarRecinto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(683, 400);
            Controls.Add(cbTipo);
            Controls.Add(tablaDatos1);
            Controls.Add(labelFormulario1);
            Controls.Add(btnTipo);
            Controls.Add(btnNRO);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(btnBuscar);
            MinimumSize = new Size(683, 400);
            Name = "BuscarRecinto";
            ((System.ComponentModel.ISupportInitialize)tablaDatos1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void botonFormulario3_Click(object sender, EventArgs e)
        {

        }

        private void botonFormulario2_Click(object sender, EventArgs e)
        {
            CambiarFormaDeBusqueda(true);
        }



        private void labelFormulario1_Click(object sender, EventArgs e)
        {

        }

        private void btnNRO_Click(object sender, EventArgs e)
        {
            CambiarFormaDeBusqueda(false);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TablaDatos.RemoveCellContentClickHandlers(tablaDatos1);
            List<Recinto> resultadoBusqueda = new List<Recinto>();
            if (buscarPorTipo){
                    resultadoBusqueda = DALRecinto.BuscarPorTipo(((TipoRecinto)cbTipo.SelectedItem).id.ToString());
            }else{
                int num;
                if (!txtBuscar.Text.IsNullOrEmpty() && int.TryParse(txtBuscar.Text,out num))
                {
                    resultadoBusqueda = DALRecinto.BuscarPorID(txtBuscar.Text);
                }else
                {
                    resultadoBusqueda = DALRecinto.ListarRecintos();
                }
            }
            tablaDatos1.Rows.Clear();
            for (int i = 0; i < resultadoBusqueda.Count; i++){
                resultadoBusqueda[i].CargarEnTabla(tablaDatos1);
            }
        }
    }
}

