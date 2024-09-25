using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion.Recepcionista
{
    internal class ProgramarPartido : FormularioEstandar
    {

        public ProgramarPartido()
        {

            InitializeComponent();

        }



        private void InitializeComponent()
        {
            comboBoxEstandar1 = new ComboBoxEstandar();
            labelFormulario1 = new LabelFormulario();
            labelFormulario2 = new LabelFormulario();
            labelFormulario3 = new LabelFormulario();
            comboBoxEstandar2 = new ComboBoxEstandar();
            dateTimePicker1 = new DateTimePicker();
            labelFormulario4 = new LabelFormulario();
            comboBoxEstandar3 = new ComboBoxEstandar();
            labelFormulario5 = new LabelFormulario();
            btnAgendar = new BotonFormulario();
            SuspendLayout();
            // 
            // comboBoxEstandar1
            // 
            comboBoxEstandar1.BackColor = SystemColors.WindowFrame;
            comboBoxEstandar1.ForeColor = Color.White;
            comboBoxEstandar1.FormattingEnabled = true;
            comboBoxEstandar1.Location = new Point(24, 92);
            comboBoxEstandar1.Name = "comboBoxEstandar1";
            comboBoxEstandar1.Size = new Size(274, 23);
            comboBoxEstandar1.TabIndex = 0;
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(85, 19);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(142, 15);
            labelFormulario1.TabIndex = 1;
            labelFormulario1.Text = "Programar Nuevo Partido";
            // 
            // labelFormulario2
            // 
            labelFormulario2.AutoSize = true;
            labelFormulario2.ForeColor = Color.White;
            labelFormulario2.Location = new Point(118, 65);
            labelFormulario2.Name = "labelFormulario2";
            labelFormulario2.Size = new Size(47, 15);
            labelFormulario2.TabIndex = 2;
            labelFormulario2.Text = "Cliente:";
            // 
            // labelFormulario3
            // 
            labelFormulario3.AutoSize = true;
            labelFormulario3.ForeColor = Color.White;
            labelFormulario3.Location = new Point(118, 125);
            labelFormulario3.Name = "labelFormulario3";
            labelFormulario3.Size = new Size(50, 15);
            labelFormulario3.TabIndex = 4;
            labelFormulario3.Text = "Cancha:";
            // 
            // comboBoxEstandar2
            // 
            comboBoxEstandar2.BackColor = SystemColors.WindowFrame;
            comboBoxEstandar2.ForeColor = Color.White;
            comboBoxEstandar2.FormattingEnabled = true;
            comboBoxEstandar2.Location = new Point(24, 152);
            comboBoxEstandar2.Name = "comboBoxEstandar2";
            comboBoxEstandar2.Size = new Size(274, 23);
            comboBoxEstandar2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(24, 210);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(274, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // labelFormulario4
            // 
            labelFormulario4.AutoSize = true;
            labelFormulario4.ForeColor = Color.White;
            labelFormulario4.Location = new Point(118, 192);
            labelFormulario4.Name = "labelFormulario4";
            labelFormulario4.Size = new Size(41, 15);
            labelFormulario4.TabIndex = 6;
            labelFormulario4.Text = "Fecha:";
            // 
            // comboBoxEstandar3
            // 
            comboBoxEstandar3.BackColor = SystemColors.WindowFrame;
            comboBoxEstandar3.ForeColor = Color.White;
            comboBoxEstandar3.FormattingEnabled = true;
            comboBoxEstandar3.Items.AddRange(new object[] { "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" });
            comboBoxEstandar3.Location = new Point(96, 277);
            comboBoxEstandar3.Name = "comboBoxEstandar3";
            comboBoxEstandar3.Size = new Size(82, 23);
            comboBoxEstandar3.TabIndex = 0;
            // 
            // labelFormulario5
            // 
            labelFormulario5.AutoSize = true;
            labelFormulario5.ForeColor = Color.White;
            labelFormulario5.Location = new Point(118, 259);
            labelFormulario5.Name = "labelFormulario5";
            labelFormulario5.Size = new Size(36, 15);
            labelFormulario5.TabIndex = 7;
            labelFormulario5.Text = "Hora:";
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = Color.DimGray;
            btnAgendar.Font = new Font("Segoe UI", 10F);
            btnAgendar.ForeColor = Color.White;
            btnAgendar.Location = new Point(85, 334);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(146, 41);
            btnAgendar.TabIndex = 0;
            btnAgendar.Text = "Agendar Partido";
            btnAgendar.UseVisualStyleBackColor = false;
            // 
            // ProgramarPartido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(323, 396);
            Controls.Add(btnAgendar);
            Controls.Add(labelFormulario5);
            Controls.Add(comboBoxEstandar3);
            Controls.Add(labelFormulario4);
            Controls.Add(dateTimePicker1);
            Controls.Add(labelFormulario3);
            Controls.Add(comboBoxEstandar2);
            Controls.Add(labelFormulario2);
            Controls.Add(labelFormulario1);
            Controls.Add(comboBoxEstandar1);
            Name = "ProgramarPartido";
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBoxEstandar comboBoxEstandar1;
        private LabelFormulario labelFormulario1;
        private LabelFormulario labelFormulario2;
        private LabelFormulario labelFormulario3;
        private DateTimePicker dateTimePicker1;
        private LabelFormulario labelFormulario4;
        private ComboBoxEstandar comboBoxEstandar3;
        private LabelFormulario labelFormulario5;
        private BotonFormulario btnAgendar;
        private ComboBoxEstandar comboBoxEstandar2;
    }
}
