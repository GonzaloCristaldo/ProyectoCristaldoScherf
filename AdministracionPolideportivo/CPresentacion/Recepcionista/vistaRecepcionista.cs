using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion.Recepcionista
{
    internal class vistaRecepcionista : VentanaMenu
    {
        public vistaRecepcionista()
        {
            InitializeComponent();
            tablaOpciones.Width = panelOpciones.Width;
            tablaOpciones.Height = tablaOpciones.RowCount * 80;
            agregarOpcion(opcionAgregarCancha);
            agregarOpcion(botonOpcion2);
        }

        private void InitializeComponent()
        {
            tablaOpciones = new TableLayoutPanel();
            opcionAgregarCancha = new BotonOpcion(new AgregarCancha(),this,formActual);
            botonOpcion2 = new BotonOpcion(new Form1(), this, formActual);
            botonOpcion3 = new BotonOpcion(null, this, formActual);
            botonOpcion4 = new BotonOpcion(null, this, formActual);
            botonOpcion5 = new BotonOpcion(null, this, formActual);
            panelOpciones.SuspendLayout();
            tablaOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // panelOpciones
            // 
            panelOpciones.Controls.Add(tablaOpciones);
            // 
            // tablaOpciones
            // 
            tablaOpciones.ColumnCount = 1;
            tablaOpciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablaOpciones.Controls.Add(opcionAgregarCancha, 0, 0);
            tablaOpciones.Controls.Add(botonOpcion2, 0, 1);
            tablaOpciones.Controls.Add(botonOpcion3, 0, 2);
            tablaOpciones.Controls.Add(botonOpcion4, 0, 3);
            tablaOpciones.Controls.Add(botonOpcion5, 0, 4);
            tablaOpciones.Location = new Point(0, 0);
            tablaOpciones.Name = "tablaOpciones";
            tablaOpciones.RowCount = 5;
            tablaOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablaOpciones.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tablaOpciones.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tablaOpciones.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tablaOpciones.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tablaOpciones.Size = new Size(200, 298);
            tablaOpciones.TabIndex = 0;
            // 
            // botonOpcion1
            // 
            opcionAgregarCancha.BackColor = Color.FromArgb(64, 64, 64);
            opcionAgregarCancha.Dock = DockStyle.Fill;
            opcionAgregarCancha.FlatAppearance.BorderColor = Color.Red;
            opcionAgregarCancha.FlatAppearance.BorderSize = 0;
            opcionAgregarCancha.FlatStyle = FlatStyle.Flat;
            opcionAgregarCancha.Font = new Font("Segoe UI", 12F);
            opcionAgregarCancha.ForeColor = SystemColors.ButtonHighlight;
            opcionAgregarCancha.Location = new Point(3, 3);
            opcionAgregarCancha.Name = "botonOpcion1";
            opcionAgregarCancha.Size = new Size(194, 45);
            opcionAgregarCancha.TabIndex = 0;
            opcionAgregarCancha.Text = "Agregar Cancha";
            opcionAgregarCancha.UseVisualStyleBackColor = false;
            
            // 
            // botonOpcion2
            // 
            botonOpcion2.BackColor = Color.FromArgb(64, 64, 64);
            botonOpcion2.Dock = DockStyle.Fill;
            botonOpcion2.FlatAppearance.BorderColor = Color.Red;
            botonOpcion2.FlatAppearance.BorderSize = 0;
            botonOpcion2.FlatStyle = FlatStyle.Flat;
            botonOpcion2.Font = new Font("Segoe UI", 12F);
            botonOpcion2.ForeColor = SystemColors.ButtonHighlight;
            botonOpcion2.Location = new Point(3, 54);
            botonOpcion2.Name = "botonOpcion2";
            botonOpcion2.Size = new Size(194, 44);
            botonOpcion2.TabIndex = 0;
            botonOpcion2.Text = "botonOpcion2";
            botonOpcion2.UseVisualStyleBackColor = false;
            // 
            // botonOpcion3
            // 
            botonOpcion3.BackColor = Color.FromArgb(64, 64, 64);
            botonOpcion3.Dock = DockStyle.Fill;
            botonOpcion3.FlatAppearance.BorderColor = Color.Red;
            botonOpcion3.FlatAppearance.BorderSize = 0;
            botonOpcion3.FlatStyle = FlatStyle.Flat;
            botonOpcion3.Font = new Font("Segoe UI", 12F);
            botonOpcion3.ForeColor = SystemColors.ButtonHighlight;
            botonOpcion3.Location = new Point(3, 104);
            botonOpcion3.Name = "botonOpcion3";
            botonOpcion3.Size = new Size(194, 48);
            botonOpcion3.TabIndex = 0;
            botonOpcion3.Text = "botonOpcion3";
            botonOpcion3.UseVisualStyleBackColor = false;
            // 
            // botonOpcion4
            // 
            botonOpcion4.BackColor = Color.FromArgb(64, 64, 64);
            botonOpcion4.Dock = DockStyle.Fill;
            botonOpcion4.FlatAppearance.BorderColor = Color.Red;
            botonOpcion4.FlatAppearance.BorderSize = 0;
            botonOpcion4.FlatStyle = FlatStyle.Flat;
            botonOpcion4.Font = new Font("Segoe UI", 12F);
            botonOpcion4.ForeColor = SystemColors.ButtonHighlight;
            botonOpcion4.Location = new Point(3, 158);
            botonOpcion4.Name = "botonOpcion4";
            botonOpcion4.Size = new Size(194, 49);
            botonOpcion4.TabIndex = 0;
            botonOpcion4.Text = "botonOpcion4";
            botonOpcion4.UseVisualStyleBackColor = false;
            // 
            // botonOpcion5
            // 
            botonOpcion5.BackColor = Color.FromArgb(64, 64, 64);
            botonOpcion5.Dock = DockStyle.Fill;
            botonOpcion5.FlatAppearance.BorderColor = Color.Red;
            botonOpcion5.FlatAppearance.BorderSize = 0;
            botonOpcion5.FlatStyle = FlatStyle.Flat;
            botonOpcion5.Font = new Font("Segoe UI", 12F);
            botonOpcion5.ForeColor = SystemColors.ButtonHighlight;
            botonOpcion5.Location = new Point(3, 213);
            botonOpcion5.Name = "botonOpcion5";
            botonOpcion5.Size = new Size(194, 82);
            botonOpcion5.TabIndex = 0;
            botonOpcion5.Text = "botonOpcion5";
            botonOpcion5.UseVisualStyleBackColor = false;
            // 
            // vistaRecepcionista
            // 
            ClientSize = new Size(694, 450);
            Name = "vistaRecepcionista";
            panelOpciones.ResumeLayout(false);
            tablaOpciones.ResumeLayout(false);
            ResumeLayout(false);
        }

        private BotonOpcion opcionAgregarCancha;
        private BotonOpcion botonOpcion2;
        private BotonOpcion botonOpcion3;
        private BotonOpcion botonOpcion4;
        private BotonOpcion botonOpcion5;
        
        /*private void button1_Click(object sender, EventArgs e)
        {
            Form1 formularioNuevo = new Form1();//Se instancia el formulario que se desea agregar al panel
            formularioNuevo.TopLevel = false;//se cambia la propiedad toplevel para que el formulario pueda ser hijo del formulario principal
            this.panelFormulario.Controls.Add(formularioNuevo);//se agrega el formulario al panel
            formularioNuevo.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//se saca el borde
            formularioNuevo.Dock = DockStyle.Fill;//El formulario cubre toda el area de su panel padre
            formularioNuevo.Show();
            if (formActual != null) { this.panelFormulario.Controls.Remove(formActual); }
            formActual = formularioNuevo;

        }*/

        private TableLayoutPanel tablaOpciones;

    }
}
