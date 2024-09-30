using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class CobrarReserva : FormularioEstandar
    {

        public CobrarReserva()
        {
            InitializeComponent();
        }



        private void InitializeComponent()
        {
            labelFormulario1 = new LabelFormulario();
            botonFormulario1 = new BotonFormulario();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(205, 9);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(123, 15);
            labelFormulario1.TabIndex = 0;
            labelFormulario1.Text = "Proceder con el cobro";
            // 
            // botonFormulario1
            // 
            botonFormulario1.BackColor = Color.ForestGreen;
            botonFormulario1.Font = new Font("Segoe UI", 10F);
            botonFormulario1.ForeColor = Color.White;
            botonFormulario1.Location = new Point(379, 234);
            botonFormulario1.Name = "botonFormulario1";
            botonFormulario1.Size = new Size(146, 41);
            botonFormulario1.TabIndex = 0;
            botonFormulario1.Text = "Cobrar";
            botonFormulario1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(142, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(142, 202);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(337, 202);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "$ _ _ _ _";
            // 
            // CobrarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(537, 287);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(botonFormulario1);
            Controls.Add(labelFormulario1);
            Name = "CobrarReserva";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private LabelFormulario labelFormulario1;
        private BotonFormulario botonFormulario1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
    }
}
