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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            botonFormulario1 = new BotonFormulario();
            botonFormulario2 = new BotonFormulario();
            botonFormulario3 = new BotonFormulario();
            botonFormulario4 = new BotonFormulario();
            botonFormulario5 = new BotonFormulario();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(206, 36);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(532, 264);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // botonFormulario1
            // 
            botonFormulario1.BackColor = Color.DimGray;
            botonFormulario1.Font = new Font("Segoe UI", 10F);
            botonFormulario1.ForeColor = Color.White;
            botonFormulario1.Location = new Point(54, 36);
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
            botonFormulario2.Location = new Point(54, 90);
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
            botonFormulario3.Location = new Point(54, 144);
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
            botonFormulario4.Location = new Point(54, 198);
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
            botonFormulario5.Location = new Point(54, 252);
            botonFormulario5.Name = "botonFormulario5";
            botonFormulario5.Size = new Size(146, 48);
            botonFormulario5.TabIndex = 4;
            botonFormulario5.Text = "Deporte con mas socios ";
            botonFormulario5.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(65, 330);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(679, 96);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Estadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(800, 450);
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
    }
}
