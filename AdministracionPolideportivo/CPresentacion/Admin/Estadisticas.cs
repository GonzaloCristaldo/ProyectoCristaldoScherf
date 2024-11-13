using AdministracionPolideportivo.CDatos;
using AdministracionPolideportivo.CNegocio;
using System;
using System.Collections.Generic;
using System.Data;
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

        override public void RefrescarCB()
        {
            //TODO
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            botonFormulario1 = new BotonFormulario();
            botonFormulario2 = new BotonFormulario();
            botonFormulario3 = new BotonFormulario();
            botonFormulario4 = new BotonFormulario();
            botonFormulario5 = new BotonFormulario();
            richTextBox1 = new RichTextBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            botonFormulario6 = new BotonFormulario();
            labelFormulario1 = new LabelFormulario();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(182, 60);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
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
            botonFormulario2.Click += botonFormulario2_Click;
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
            botonFormulario3.Click += botonFormulario3_Click;
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
            botonFormulario4.Text = "Tipo de recinto mas utilizado";
            botonFormulario4.UseVisualStyleBackColor = false;
            botonFormulario4.Click += botonFormulario4_Click;
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
            botonFormulario5.Text = "Servicio adicional mas utilizado";
            botonFormulario5.UseVisualStyleBackColor = false;
            botonFormulario5.Click += botonFormulario5_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(640, 60);
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
            botonFormulario6.Click += botonFormulario6_Click;
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.Font = new Font("Segoe UI", 18F);
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(355, 9);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(99, 32);
            labelFormulario1.TabIndex = 13;
            labelFormulario1.Text = "Graficos";
            // 
            // Estadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(800, 450);
            Controls.Add(labelFormulario1);
            Controls.Add(botonFormulario6);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
 // Obtén las fechas de los DateTimePicker
    DateTime fechaInicio = dateTimePicker1.Value.Date;
    DateTime fechaFin = dateTimePicker2.Value.Date;

    // Consulta base para obtener el mes con más reservas, agregando el filtro de fechas
    string consultaBase = @"
    SELECT DATENAME(month, fecha_reserva) AS Mes, COUNT(*) AS CantidadReservas
    FROM Reserva
    WHERE fecha_reserva >= @fechaInicio AND fecha_reserva <= @fechaFin
    GROUP BY DATENAME(month, fecha_reserva), MONTH(fecha_reserva)
    ORDER BY COUNT(*) DESC";  // Ordenar por la cantidad de reservas (de mayor a menor)

    // Ejecutar la consulta con las fechas filtradas
    DataHelper dataHelper = new DataHelper();
    DataTable result = dataHelper.ExecuteQueryConParametros(consultaBase, fechaInicio, fechaFin);

    // Crear un diccionario para traducir los meses de inglés a español
    Dictionary<string, string> mesesEnEspañol = new Dictionary<string, string>
    {
        { "January", "Enero" },
        { "February", "Febrero" },
        { "March", "Marzo" },
        { "April", "Abril" },
        { "May", "Mayo" },
        { "June", "Junio" },
        { "July", "Julio" },
        { "August", "Agosto" },
        { "September", "Septiembre" },
        { "October", "Octubre" },
        { "November", "Noviembre" },
        { "December", "Diciembre" }
    };

    // Limpiar el gráfico actual
    chart1.Series.Clear();

    // Crear una nueva serie para el gráfico
    var series = chart1.Series.Add("Mes con más reservas");
    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

    // Inicializar variables para encontrar el mes con más reservas
    string mesConMasReservas = "";
    int cantidadMaxima = 0;

    // Añadir los datos al gráfico, traduciendo los meses y actualizando el mensaje
    foreach (DataRow row in result.Rows)
    {
        string mesIngles = row["Mes"].ToString();
        string mesEnEspanol = mesesEnEspañol.ContainsKey(mesIngles) ? mesesEnEspañol[mesIngles] : mesIngles;
        int cantidadReservas = Convert.ToInt32(row["CantidadReservas"]);

        series.Points.AddXY(mesEnEspanol, cantidadReservas);

        // Si encontramos un valor mayor, actualizamos el mes con más reservas
        if (cantidadReservas > cantidadMaxima)
        {
            cantidadMaxima = cantidadReservas;
            mesConMasReservas = mesEnEspanol;
        }
    }

    // Mostrar el resultado en el RichTextBox
    richTextBox1.Text = $"El mes con más reservas es {mesConMasReservas} con {cantidadMaxima} reservas.";
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
        private LabelFormulario labelFormulario1;

        private void botonFormulario2_Click(object sender, EventArgs e)
        {
            // Obtén las fechas de los DateTimePicker
            DateTime fechaInicio = dateTimePicker1.Value.Date;
            DateTime fechaFin = dateTimePicker2.Value.Date;

            // Consulta base para el horario pico
            string consultaBase = @"
    SELECT hora_reserva AS Hora, COUNT(*) AS CantidadReservas
    FROM Reserva
    WHERE fecha_reserva >= @fechaInicio AND fecha_reserva <= @fechaFin
    GROUP BY hora_reserva
    ORDER BY CantidadReservas DESC";

            // Ejecutar la consulta con las fechas filtradas
            DataHelper dataHelper = new DataHelper();
            DataTable result = dataHelper.ExecuteQueryConParametros(consultaBase, fechaInicio, fechaFin);

            // Limpiar el gráfico actual
            chart1.Series.Clear();

            // Crear una nueva serie para el gráfico
            var series = chart1.Series.Add("Horario pico");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            // Inicializar variables para encontrar el horario pico
            string horaPico = "";
            int maxReservas = 0;

            // Añadir los datos al gráfico
            foreach (DataRow row in result.Rows)
            {
                series.Points.AddXY(row["Hora"], row["CantidadReservas"]);
            }
            if (result.Rows.Count > 0)
            {
                DataRow maxRow = result.Rows[0]; // Como está ordenado por cantidad de reservas descendente, el primero es el mayor
                richTextBox1.Text = $"El horario pico con más reservas es a las {maxRow["Hora"]} con {maxRow["CantidadReservas"]} reservas.";
            }

        }

        private void botonFormulario3_Click(object sender, EventArgs e)
        {
            // Obtén las fechas de los DateTimePicker
            DateTime fechaInicio = dateTimePicker1.Value.Date;
            DateTime fechaFin = dateTimePicker2.Value.Date;

            // Consulta base para los recintos más utilizados
            string consultaBase = @"
    SELECT R.nro_recinto, COUNT(*) AS CantidadReservas
    FROM Reserva AS R
    WHERE fecha_reserva >= @fechaInicio AND fecha_reserva <= @fechaFin
    GROUP BY R.nro_recinto
    ORDER BY CantidadReservas DESC";

            // Ejecutar la consulta con las fechas filtradas
            DataHelper dataHelper = new DataHelper();
            DataTable result = dataHelper.ExecuteQueryConParametros(consultaBase, fechaInicio, fechaFin);

            // Limpiar el gráfico actual
            chart1.Series.Clear();

            // Crear una nueva serie para el gráfico
            var series = chart1.Series.Add("Recintos más utilizados");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            // Añadir los datos al gráfico
            foreach (DataRow row in result.Rows)
            {
                series.Points.AddXY(row["nro_recinto"], row["CantidadReservas"]);
            }

            // Mostrar el recinto con más reservas en el RichTextBox
            if (result.Rows.Count > 0)
            {
                DataRow maxRow = result.Rows[0]; // El primer recinto es el más utilizado
                richTextBox1.Text = $"El recinto más utilizado es el número {maxRow["nro_recinto"]} con {maxRow["CantidadReservas"]} reservas.";
            }
        }

        private void botonFormulario4_Click(object sender, EventArgs e)
        {
            // Obtén las fechas de los DateTimePicker
            DateTime fechaInicio = dateTimePicker1.Value.Date;
            DateTime fechaFin = dateTimePicker2.Value.Date;

            // Consulta base para el deporte más utilizado
            string consultaBase = @"
    SELECT TR.nombre_tipo_recinto AS Deporte, COUNT(*) AS CantidadReservas
    FROM Reserva AS R
    JOIN Recinto AS RC ON R.nro_recinto = RC.nro_recinto
    JOIN Tipo_Recinto AS TR ON RC.id_tipo_recinto = TR.id_tipo_recinto
    WHERE fecha_reserva >= @fechaInicio AND fecha_reserva <= @fechaFin
    GROUP BY TR.nombre_tipo_recinto
    ORDER BY CantidadReservas DESC";

            // Ejecutar la consulta con las fechas filtradas
            DataHelper dataHelper = new DataHelper();
            DataTable result = dataHelper.ExecuteQueryConParametros(consultaBase, fechaInicio, fechaFin);

            // Limpiar el gráfico actual
            chart1.Series.Clear();

            // Crear una nueva serie para el gráfico
            var series = chart1.Series.Add("Tipo recinto mas utilizado");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            // Añadir los datos al gráfico
            foreach (DataRow row in result.Rows)
            {
                series.Points.AddXY(row["Deporte"], row["CantidadReservas"]);
            }

            // Mostrar el deporte más utilizado en el RichTextBox
            if (result.Rows.Count > 0)
            {
                DataRow maxRow = result.Rows[0]; 
                richTextBox1.Text = $"El tipo de recinto más utilizado es {maxRow["Deporte"]} con {maxRow["CantidadReservas"]} reservas.";
            }
        }

        private void botonFormulario5_Click(object sender, EventArgs e)
        {
            // Obtén las fechas de los DateTimePicker
            DateTime fechaInicio = dateTimePicker1.Value.Date;
            DateTime fechaFin = dateTimePicker2.Value.Date;

            // Consulta base para el servicio adicional más utilizado
            string consultaBase = @"
    SELECT SA.nombre_servicio AS Servicio, COUNT(*) AS CantidadUsos
    FROM Servicio_Reserva AS SR
    JOIN Servicio_Adicional AS SA ON SR.id_servicio = SA.id_servicio
    JOIN Reserva AS R ON SR.id_reserva = R.id_reserva
    WHERE R.fecha_reserva >= @fechaInicio AND R.fecha_reserva <= @fechaFin
    GROUP BY SA.nombre_servicio
    ORDER BY CantidadUsos DESC";

            // Ejecutar la consulta con las fechas filtradas
            DataHelper dataHelper = new DataHelper();
            DataTable result = dataHelper.ExecuteQueryConParametros(consultaBase, fechaInicio, fechaFin);

            // Limpiar el gráfico actual
            chart1.Series.Clear();

            // Crear una nueva serie para el gráfico
            var series = chart1.Series.Add("Servicio adicional más utilizado");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            // Añadir los datos al gráfico
            foreach (DataRow row in result.Rows)
            {
                series.Points.AddXY(row["Servicio"], row["CantidadUsos"]);
            }

            // Mostrar el servicio más utilizado en el RichTextBox
            if (result.Rows.Count > 0)
            {
                DataRow maxRow = result.Rows[0]; // El primer servicio es el más utilizado
                richTextBox1.Text = $"El servicio adicional más utilizado es {maxRow["Servicio"]} con {maxRow["CantidadUsos"]} usos.";
            }
        }

        private void botonFormulario6_Click(object sender, EventArgs e)
        {
            // Obtén las fechas de los DateTimePicker
            DateTime fechaInicio = dateTimePicker1.Value.Date;  // Usa .Date para eliminar la hora
            DateTime fechaFin = dateTimePicker2.Value.Date;

            // Consulta base que ya tiene la lógica para obtener el mes y la cantidad de reservas
            string consultaBase = @"
    SELECT DATENAME(month, fecha_reserva) AS Mes, COUNT(*) AS CantidadReservas
    FROM Reserva
    WHERE fecha_reserva >= @fechaInicio AND fecha_reserva <= @fechaFin
    GROUP BY DATENAME(month, fecha_reserva), MONTH(fecha_reserva)
    ORDER BY MONTH(fecha_reserva)";

            // Ejecutar la consulta con las fechas filtradas
            DataHelper dataHelper = new DataHelper();
            DataTable result = dataHelper.ExecuteQueryConParametros(consultaBase, fechaInicio, fechaFin);

            // Limpiar el gráfico actual
            chart1.Series.Clear();

            // Crear una nueva serie para el gráfico filtrado
            var series = chart1.Series.Add("Filtrado");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            /* Añadir los datos al gráfico
            foreach (DataRow row in result.Rows)
            {
                series.Points.AddXY(row["Mes"], row["CantidadReservas"]);
            }*/
        }
        private string ConstruirConsultaConFechas(string consultaBase, DateTime? fechaInicio, DateTime? fechaFin)
        {
            // Añadir la condición WHERE correctamente
            StringBuilder queryBuilder = new StringBuilder(consultaBase);

            // Agregar la cláusula WHERE solo si es necesario
            if (fechaInicio.HasValue || fechaFin.HasValue)
            {
                queryBuilder.Append(" WHERE ");
                if (fechaInicio.HasValue)
                {
                    queryBuilder.Append("fecha_reserva >= @fechaInicio ");
                }
                if (fechaFin.HasValue)
                {
                    if (fechaInicio.HasValue) queryBuilder.Append("AND ");
                    queryBuilder.Append("fecha_reserva <= @fechaFin ");
                }
            }

            // Asegurarse de que ORDER BY esté al final
            queryBuilder.Append("ORDER BY MONTH(fecha_reserva)");

            return queryBuilder.ToString();
        }

    }
}
