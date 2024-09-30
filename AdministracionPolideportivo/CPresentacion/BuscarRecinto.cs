using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class BuscarRecinto : FormularioEstandar
    {
        public BuscarRecinto()
        {

            InitializeComponent();

        }

        private BotonFormulario btnBuscar;
        private LabelFormulario lblBuscar;
        private DataGridView dataGridView1;
        private BotonFormulario botonFormulario1;
        private BotonFormulario botonFormulario2;
        private BotonFormulario botonFormulario3;
        private LabelFormulario labelFormulario1;
        private BotonFormulario botonFormulario4;
        private BotonFormulario botonFormulario5;
        private BotonFormulario botonFormulario6;
        private Texto txtBuscar;

        private void InitializeComponent()
        {
            btnBuscar = new BotonFormulario();
            lblBuscar = new LabelFormulario();
            txtBuscar = new Texto();
            dataGridView1 = new DataGridView();
            botonFormulario1 = new BotonFormulario();
            botonFormulario2 = new BotonFormulario();
            botonFormulario3 = new BotonFormulario();
            labelFormulario1 = new LabelFormulario();
            botonFormulario4 = new BotonFormulario();
            botonFormulario5 = new BotonFormulario();
            botonFormulario6 = new BotonFormulario();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DimGray;
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(385, 49);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 35);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar Recinto";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.ForeColor = Color.White;
            lblBuscar.Location = new Point(199, 9);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(268, 15);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Busqueda y Gestion de Recintos del Polideportivo";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.WindowFrame;
            txtBuscar.Cursor = Cursors.IBeam;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(169, 57);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(210, 23);
            txtBuscar.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(659, 233);
            dataGridView1.TabIndex = 2;
            // 
            // botonFormulario1
            // 
            botonFormulario1.BackColor = Color.DimGray;
            botonFormulario1.Font = new Font("Segoe UI", 10F);
            botonFormulario1.ForeColor = Color.White;
            botonFormulario1.Location = new Point(12, 98);
            botonFormulario1.Name = "botonFormulario1";
            botonFormulario1.Size = new Size(100, 41);
            botonFormulario1.TabIndex = 0;
            botonFormulario1.Text = "Futbol";
            botonFormulario1.UseVisualStyleBackColor = false;
            // 
            // botonFormulario2
            // 
            botonFormulario2.BackColor = Color.DimGray;
            botonFormulario2.Font = new Font("Segoe UI", 10F);
            botonFormulario2.ForeColor = Color.White;
            botonFormulario2.Location = new Point(118, 98);
            botonFormulario2.Name = "botonFormulario2";
            botonFormulario2.Size = new Size(100, 41);
            botonFormulario2.TabIndex = 3;
            botonFormulario2.Text = "Basquet";
            botonFormulario2.UseVisualStyleBackColor = false;
            botonFormulario2.Click += botonFormulario2_Click;
            // 
            // botonFormulario3
            // 
            botonFormulario3.BackColor = Color.DimGray;
            botonFormulario3.Font = new Font("Segoe UI", 10F);
            botonFormulario3.ForeColor = Color.White;
            botonFormulario3.Location = new Point(224, 98);
            botonFormulario3.Name = "botonFormulario3";
            botonFormulario3.Size = new Size(100, 41);
            botonFormulario3.TabIndex = 4;
            botonFormulario3.Text = "Mixto";
            botonFormulario3.UseVisualStyleBackColor = false;
            botonFormulario3.Click += botonFormulario3_Click;
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(169, 39);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(64, 15);
            labelFormulario1.TabIndex = 5;
            labelFormulario1.Text = "N° Recinto";
            // 
            // botonFormulario4
            // 
            botonFormulario4.BackColor = Color.DimGray;
            botonFormulario4.Font = new Font("Segoe UI", 10F);
            botonFormulario4.ForeColor = Color.White;
            botonFormulario4.Location = new Point(330, 98);
            botonFormulario4.Name = "botonFormulario4";
            botonFormulario4.Size = new Size(100, 41);
            botonFormulario4.TabIndex = 6;
            botonFormulario4.Text = "S.U.M";
            botonFormulario4.UseVisualStyleBackColor = false;
            // 
            // botonFormulario5
            // 
            botonFormulario5.BackColor = Color.DimGray;
            botonFormulario5.Font = new Font("Segoe UI", 10F);
            botonFormulario5.ForeColor = Color.White;
            botonFormulario5.Location = new Point(436, 98);
            botonFormulario5.Name = "botonFormulario5";
            botonFormulario5.Size = new Size(100, 41);
            botonFormulario5.TabIndex = 7;
            botonFormulario5.Text = "Gimnasio";
            botonFormulario5.UseVisualStyleBackColor = false;
            // 
            // botonFormulario6
            // 
            botonFormulario6.BackColor = Color.DimGray;
            botonFormulario6.Font = new Font("Segoe UI", 10F);
            botonFormulario6.ForeColor = Color.White;
            botonFormulario6.Location = new Point(542, 98);
            botonFormulario6.Name = "botonFormulario6";
            botonFormulario6.Size = new Size(129, 41);
            botonFormulario6.TabIndex = 8;
            botonFormulario6.Text = "Entrenamientos";
            botonFormulario6.UseVisualStyleBackColor = false;
            // 
            // BuscarRecinto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(683, 400);
            Controls.Add(botonFormulario6);
            Controls.Add(botonFormulario5);
            Controls.Add(botonFormulario4);
            Controls.Add(labelFormulario1);
            Controls.Add(botonFormulario3);
            Controls.Add(botonFormulario2);
            Controls.Add(botonFormulario1);
            Controls.Add(dataGridView1);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(btnBuscar);
            Name = "BuscarRecinto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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

        }
    }
}

