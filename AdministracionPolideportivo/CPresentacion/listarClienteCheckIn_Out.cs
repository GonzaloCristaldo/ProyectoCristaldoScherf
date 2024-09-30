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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listarClienteCheckIn_Out));
            dataGridView1 = new DataGridView();
            botonFormulario1 = new BotonFormulario();
            botonFormulario2 = new BotonFormulario();
            txtBuscar = new Texto();
            cbBuscar = new ComboBoxEstandar();
            pictureBox1 = new PictureBox();
            labelFormulario1 = new LabelFormulario();
            label1 = new Label();
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
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.WindowFrame;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(46, 323);
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
            cbBuscar.Location = new Point(64, 250);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(183, 23);
            cbBuscar.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.Font = new Font("Segoe UI", 15F);
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(101, 219);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(108, 28);
            labelFormulario1.TabIndex = 8;
            labelFormulario1.Text = "Buscar por:";
            labelFormulario1.Click += labelFormulario1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(79, 305);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 9;
            label1.Text = "Ingrese a continuacion:";
            // 
            // listarClienteCheckIn_Out
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(labelFormulario1);
            Controls.Add(pictureBox1);
            Controls.Add(cbBuscar);
            Controls.Add(txtBuscar);
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
        private Texto txtBuscar;
        private ComboBoxEstandar cbBuscar;
        private PictureBox pictureBox1;
        private LabelFormulario labelFormulario1;
        private Label label1;
        private BotonFormulario botonFormulario2;

        private void labelFormulario1_Click(object sender, EventArgs e)
        {

        }
    }


}
