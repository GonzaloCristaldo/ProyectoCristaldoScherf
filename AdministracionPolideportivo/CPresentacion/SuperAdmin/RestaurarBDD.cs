using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion.SuperAdmin
{
    internal class RestaurarBDD : FormularioEstandar
    {

        public RestaurarBDD()
        {

            InitializeComponent();

        }



        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurarBDD));
            labelFormulario1 = new LabelFormulario();
            botonFormulario1 = new BotonFormulario();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.Font = new Font("Segoe UI", 15F);
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(188, 9);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(238, 28);
            labelFormulario1.TabIndex = 0;
            labelFormulario1.Text = "Restaurar la Base de datos";
            labelFormulario1.Click += labelFormulario1_Click;
            // 
            // botonFormulario1
            // 
            botonFormulario1.BackColor = Color.DimGray;
            botonFormulario1.Font = new Font("Segoe UI", 10F);
            botonFormulario1.ForeColor = Color.White;
            botonFormulario1.Location = new Point(229, 260);
            botonFormulario1.Name = "botonFormulario1";
            botonFormulario1.Size = new Size(150, 62);
            botonFormulario1.TabIndex = 0;
            botonFormulario1.Text = "Obtener archivo de respaldo";
            botonFormulario1.UseVisualStyleBackColor = false;
            botonFormulario1.Click += botonFormulario1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(137, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(344, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // RestaurarBDD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(647, 334);
            Controls.Add(pictureBox1);
            Controls.Add(botonFormulario1);
            Controls.Add(labelFormulario1);
            Name = "RestaurarBDD";
            Load += AgregarMedioPago_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void AgregarMedioPago_Load(object sender, EventArgs e)
        {

        }

        private LabelFormulario labelFormulario1;
        private BotonFormulario botonFormulario1;
        private PictureBox pictureBox1;

        private void labelFormulario1_Click(object sender, EventArgs e)
        {

        }

        private void botonFormulario1_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Backup restaurado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
           

        }
    }
}
