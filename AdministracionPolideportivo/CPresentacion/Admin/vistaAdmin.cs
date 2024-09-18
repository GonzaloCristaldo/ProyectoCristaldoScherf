using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class VistaAdmin : VentanaMenu
    {
        public VistaAdmin() : base()
        {

            InitializeComponent();
        }
        private void InitializeComponent()
        {
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            customButton1 = new CustomButton();
            panelNavegacion.SuspendLayout();
            panelOpciones.SuspendLayout();
            panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelNavegacion
            // 
            panelNavegacion.Controls.Add(button2);
            panelNavegacion.Controls.Add(button1);
            panelNavegacion.Controls.Add(label1);
            // 
            // panelOpciones
            // 
            panelOpciones.Controls.Add(customButton1);
            panelOpciones.Controls.Add(label4);
            panelOpciones.Controls.Add(label2);
            panelOpciones.Controls.Add(label3);
            // 
            // panelFormulario
            // 
            panelFormulario.Controls.Add(dataGridView1);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(19, 60);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 0;
            label3.Text = "Gestionar Socio";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(286, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 0;
            label1.Text = "Gestion Socios del Club";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(19, 101);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 1;
            label2.Text = "Ver Listado de Socios";
            // 
            // button1
            // 
            button1.Location = new Point(619, 5);
            button1.Name = "button1";
            button1.Size = new Size(21, 23);
            button1.TabIndex = 1;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(646, 5);
            button2.Name = "button2";
            button2.Size = new Size(24, 23);
            button2.TabIndex = 2;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(19, 142);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 2;
            label4.Text = "Gestionar Canchas";
            label4.Click += label4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(379, 238);
            dataGridView1.TabIndex = 0;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Green;
            customButton1.Location = new Point(76, 216);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(75, 23);
            customButton1.TabIndex = 3;
            customButton1.Text = "customButton1";
            customButton1.UseVisualStyleBackColor = false;
            // 
            // VistaAdmin
            // 
            ClientSize = new Size(694, 450);
            Name = "VistaAdmin";
            panelNavegacion.ResumeLayout(false);
            panelNavegacion.PerformLayout();
            panelOpciones.ResumeLayout(false);
            panelOpciones.PerformLayout();
            panelFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private DataGridView dataGridView1;
        private CustomButton customButton1;
        private Label label1;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}