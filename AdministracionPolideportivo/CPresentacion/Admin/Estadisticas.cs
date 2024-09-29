using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion.Admin
{
    internal class Estadisticas : FormularioEstandar
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            botonFormulario1 = new BotonFormulario();
            botonFormulario2 = new BotonFormulario();
            botonFormulario3 = new BotonFormulario();
            botonFormulario4 = new BotonFormulario();
            botonFormulario5 = new BotonFormulario();
            richTextBox1 = new RichTextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            botonFormulario6 = new BotonFormulario();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            chart1.Legends.Add(legend5);
            chart1.Location = new Point(182, 60);
            chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            chart1.Series.Add(series5);
            chart1.Size = new Size(405, 264);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // botonFormulario1
            // 
            botonFormulario1.BackColor = Color.DimGray;
            botonFormulario1.Font = new Font("Segoe UI", 10F);
            botonFormulario1.ForeColor = Color.White;
            botonFormulario1.Location = new Point(30, 60);
            botonFormulario1.Name = "botonFormulario1";
            botonFormulario1.Size = new Size(146, 48);
            botonFormulario1.TabIndex = 0;
            botonFormulario1.Text = "Mes con mas reservas";
            botonFormulario1.UseVisualStyleBackColor = false;
            botonFormulario1.Click += botonFormulario1_Click;
            // 
            // botonFormulario2
            // 
            botonFormulario2.BackColor = Color.DimGray;
            botonFormulario2.Font = new Font("Segoe UI", 10F);
            botonFormulario2.ForeColor = Color.White;
            botonFormulario2.Location = new Point(30, 114);
            botonFormulario2.Name = "botonFormulario2";
            botonFormulario2.Size = new Size(146, 48);
            botonFormulario2.TabIndex = 1;
            botonFormulario2.Text = "Horario pico";
            botonFormulario2.UseVisualStyleBackColor = false;
            // 
            // botonFormulario3
            // 
            botonFormulario3.BackColor = Color.DimGray;
            botonFormulario3.Font = new Font("Segoe UI", 10F);
            botonFormulario3.ForeColor = Color.White;
            botonFormulario3.Location = new Point(30, 168);
            botonFormulario3.Name = "botonFormulario3";
            botonFormulario3.Size = new Size(146, 48);
            botonFormulario3.TabIndex = 2;
            botonFormulario3.Text = "Recintos mas utilizados";
            botonFormulario3.UseVisualStyleBackColor = false;
            // 
            // botonFormulario4
            // 
            botonFormulario4.BackColor = Color.DimGray;
            botonFormulario4.Font = new Font("Segoe UI", 10F);
            botonFormulario4.ForeColor = Color.White;
            botonFormulario4.Location = new Point(30, 222);
            botonFormulario4.Name = "botonFormulario4";
            botonFormulario4.Size = new Size(146, 48);
            botonFormulario4.TabIndex = 3;
            botonFormulario4.Text = "Deporte con mas reservas";
            botonFormulario4.UseVisualStyleBackColor = false;
            // 
            // botonFormulario5
            // 
            botonFormulario5.BackColor = Color.DimGray;
            botonFormulario5.Font = new Font("Segoe UI", 10F);
            botonFormulario5.ForeColor = Color.White;
            botonFormulario5.Location = new Point(30, 276);
            botonFormulario5.Name = "botonFormulario5";
            botonFormulario5.Size = new Size(146, 48);
            botonFormulario5.TabIndex = 4;
            botonFormulario5.Text = "Deporte con mas socios ";
            botonFormulario5.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(60, 330);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(684, 96);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(593, 114);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(372, 30);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 8;
            label1.Text = "Graficos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(649, 60);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 9;
            label2.Text = "Filtrar por fechas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(669, 93);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 10;
            label3.Text = "Desde:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(669, 158);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 11;
            label4.Text = "Hasta:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(593, 180);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 12;
            // 
            // botonFormulario6
            // 
            botonFormulario6.BackColor = Color.DimGray;
            botonFormulario6.Font = new Font("Segoe UI", 10F);
            botonFormulario6.ForeColor = Color.White;
            botonFormulario6.Location = new Point(618, 229);
            botonFormulario6.Name = "botonFormulario6";
            botonFormulario6.Size = new Size(146, 41);
            botonFormulario6.TabIndex = 0;
            botonFormulario6.Text = "Filtrar";
            botonFormulario6.UseVisualStyleBackColor = false;
            // 
            // Estadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(800, 450);
            Controls.Add(botonFormulario6);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(richTextBox1);
            Controls.Add(botonFormulario5);
            Controls.Add(botonFormulario4);
            Controls.Add(botonFormulario3);
            Controls.Add(botonFormulario2);
            Controls.Add(botonFormulario1);
            Controls.Add(chart1);
            Name = "Estadisticas";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void botonFormulario1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private BotonFormulario botonFormulario1;
        private BotonFormulario botonFormulario2;
        private BotonFormulario botonFormulario3;
        private BotonFormulario botonFormulario4;
        private BotonFormulario botonFormulario5;
        private RichTextBox richTextBox1;

        private void labelFormulario1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private BotonFormulario botonFormulario6;
    }
}
