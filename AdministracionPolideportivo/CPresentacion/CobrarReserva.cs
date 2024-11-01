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
            comboBoxEstandar1 = new ComboBoxEstandar();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.Font = new Font("Segoe UI", 15F);
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(166, 9);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(204, 28);
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
            dataGridView1.Location = new Point(274, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(274, 202);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(469, 202);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "$ _ _ _ _";
            // 
            // comboBoxEstandar1
            // 
            comboBoxEstandar1.BackColor = SystemColors.WindowFrame;
            comboBoxEstandar1.ForeColor = Color.White;
            comboBoxEstandar1.FormattingEnabled = true;
            comboBoxEstandar1.Items.AddRange(new object[] { "Efectivo", "Tarjeta de credito", "Tarjeta de debito", "Mercado Pago", "QR MODO" });
            comboBoxEstandar1.Location = new Point(36, 60);
            comboBoxEstandar1.Name = "comboBoxEstandar1";
            comboBoxEstandar1.Size = new Size(210, 23);
            comboBoxEstandar1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(95, 40);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 4;
            label3.Text = "Forma de pago";
            // 
            // CobrarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(537, 287);
            Controls.Add(label3);
            Controls.Add(comboBoxEstandar1);
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

        override public void RefrescarCB()
        {
            //TODO
        }

        private LabelFormulario labelFormulario1;
        private BotonFormulario botonFormulario1;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBoxEstandar comboBoxEstandar1;
        private Label label3;
        private Label label2;
    }
}
