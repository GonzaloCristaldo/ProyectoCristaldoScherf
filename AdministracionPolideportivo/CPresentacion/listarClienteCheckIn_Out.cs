using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class listarClienteCheckIn_Out : FormularioEstandar
    {

        public listarClienteCheckIn_Out()
        {
            InitializeComponent();
        }

        public void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            botonFormulario1 = new BotonFormulario();
            botonFormulario2 = new BotonFormulario();
            pictureBox1 = new PictureBox();
            txtBuscar = new Texto();
            cbBuscar = new ComboBoxEstandar();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(322, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(466, 334);
            dataGridView1.TabIndex = 0;
            // 
            // botonFormulario1
            // 
            botonFormulario1.BackColor = Color.DimGray;
            botonFormulario1.Font = new Font("Segoe UI", 10F);
            botonFormulario1.ForeColor = Color.White;
            botonFormulario1.Location = new Point(409, 373);
            botonFormulario1.Name = "botonFormulario1";
            botonFormulario1.Size = new Size(146, 41);
            botonFormulario1.TabIndex = 0;
            botonFormulario1.Text = "Check-In Usuario";
            botonFormulario1.UseVisualStyleBackColor = false;
            botonFormulario1.Click += botonFormulario1_Click;
            // 
            // botonFormulario2
            // 
            botonFormulario2.BackColor = Color.DimGray;
            botonFormulario2.Font = new Font("Segoe UI", 10F);
            botonFormulario2.ForeColor = Color.White;
            botonFormulario2.Location = new Point(561, 373);
            botonFormulario2.Name = "botonFormulario2";
            botonFormulario2.Size = new Size(146, 41);
            botonFormulario2.TabIndex = 0;
            botonFormulario2.Text = "Check-out";
            botonFormulario2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(80, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 152);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.WindowFrame;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(50, 265);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(210, 23);
            txtBuscar.TabIndex = 2;
            // 
            // cbBuscar
            // 
            cbBuscar.BackColor = SystemColors.WindowFrame;
            cbBuscar.ForeColor = Color.White;
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Items.AddRange(new object[] { "ID", "DNI", "Nombre", "Apellido", "Telefono" });
            cbBuscar.Location = new Point(64, 214);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(183, 23);
            cbBuscar.TabIndex = 3;
            // 
            // listarClienteCheckIn_Out
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(800, 450);
            Controls.Add(cbBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(pictureBox1);
            Controls.Add(botonFormulario2);
            Controls.Add(botonFormulario1);
            Controls.Add(dataGridView1);
            Name = "listarClienteCheckIn_Out";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void botonFormulario1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private DataGridView dataGridView1;
        private BotonFormulario botonFormulario1;
        private PictureBox pictureBox1;
        private Texto txtBuscar;
        private ComboBoxEstandar cbBuscar;
        private BotonFormulario botonFormulario2;
    }


}
