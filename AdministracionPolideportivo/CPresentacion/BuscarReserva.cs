using AdministracionPolideportivo.CDatos;
using AdministracionPolideportivo.CNegocio;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion.Recepcionista
{
    internal class BuscarReserva : FormularioEstandar
    {
        public BuscarReserva()
        {

            InitializeComponent();
            tablaDatos1.setDatoModelo(new Reserva(1, new Recinto(), new Cliente(), new DateOnly(), new TimeOnly(), new Usuario()));

        }

        override public void RefrescarCB()
        {
            //TODO
        }
        private void InitializeComponent()
        {
            labelFormulario1 = new LabelFormulario();
            cbBuscar = new ComboBoxEstandar();
            txtBuscar = new Texto();
            btnBuscar = new BotonFormulario();
            tablaDatos1 = new TablaDatos();
            ((System.ComponentModel.ISupportInitialize)tablaDatos1).BeginInit();
            SuspendLayout();
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.Font = new Font("Segoe UI", 15F);
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(301, 9);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(175, 28);
            labelFormulario1.TabIndex = 0;
            labelFormulario1.Text = "Buscar Reserva por";
            // 
            // cbBuscar
            // 
            cbBuscar.BackColor = SystemColors.WindowFrame;
            cbBuscar.ForeColor = Color.White;
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Items.AddRange(new object[] { "ID", "Fecha (aaaa-mm-dd)", "ID de Cliente", "Numero de Recinto", "ID de Usuario", "Hora", "Listar Reservas" });
            cbBuscar.Location = new Point(289, 40);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(210, 23);
            cbBuscar.TabIndex = 0;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.WindowFrame;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(269, 86);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(249, 23);
            txtBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DimGray;
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(319, 130);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 41);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar Reserva";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tablaDatos1
            // 
            tablaDatos1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaDatos1.Location = new Point(12, 187);
            tablaDatos1.Name = "tablaDatos1";
            tablaDatos1.Size = new Size(766, 212);
            tablaDatos1.TabIndex = 1;
            // 
            // BuscarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(790, 411);
            Controls.Add(tablaDatos1);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(cbBuscar);
            Controls.Add(labelFormulario1);
            MinimumSize = new Size(790, 411);
            Name = "BuscarReserva";
            ((System.ComponentModel.ISupportInitialize)tablaDatos1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private LabelFormulario labelFormulario1;
        private ComboBoxEstandar cbBuscar;
        private Texto txtBuscar;
        private TablaDatos tablaDatos1;
        private BotonFormulario btnBuscar;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!txtBuscar.Text.IsNullOrEmpty())
            {
                List<Reserva> resultadoBusqueda = new List<Reserva>();
                if (!cbBuscar.Text.Equals("Listar Reservas"))
                {
                    int num;
                    
                    if (cbBuscar.Text.Equals("ID") && int.TryParse(txtBuscar.Text,out num))
                    {
                        resultadoBusqueda = DALReserva.BuscarPorID(txtBuscar.Text);
                    }
                    else if (cbBuscar.Text.Equals("ID de Cliente") && int.TryParse(txtBuscar.Text, out num))
                    {
                        resultadoBusqueda = DALReserva.BuscarPorIDCliente(txtBuscar.Text);
                    }
                    else if (cbBuscar.Text.Equals("Numero de Recinto") && int.TryParse(txtBuscar.Text, out num))
                    {
                        resultadoBusqueda = DALReserva.BuscarPorNroRecinto(txtBuscar.Text);
                    }
                    else if (cbBuscar.Text.Equals("ID de Usuario") && int.TryParse(txtBuscar.Text, out num))
                    {
                        resultadoBusqueda = DALReserva.BuscarPorIDUsuario(txtBuscar.Text);
                    }
                    else if (cbBuscar.Text.Equals("Hora") && int.TryParse(txtBuscar.Text, out num))
                    {
                        resultadoBusqueda = DALReserva.BuscarPorHora(txtBuscar.Text);
                    }
                    else if (cbBuscar.Text.Equals("Fecha (aaaa-mm-dd)") )
                    {
                        DateOnly fecha;
                        bool conversion=DateOnly.TryParse(txtBuscar.Text, out fecha);
                        if (conversion)
                        {
                            resultadoBusqueda = DALReserva.BuscarPorFecha(fecha);
                        }
                        else
                        {
                            MessageBox.Show("Error de conversion en la fecha. Por favor utilice el formato aaaa-mm--dd.");
                        }
                    }
                }

                else
                {
                    resultadoBusqueda = DALReserva.ListarReservas();
                }
                tablaDatos1.Rows.Clear();
                for (int i = 0; i < resultadoBusqueda.Count; i++)
                {
                    resultadoBusqueda[i].CargarEnTabla(tablaDatos1);
                }
            }
            else if (cbBuscar.Text.Equals("Listar Reservas"))
            {
                List<Reserva> resultadoBusqueda = DALReserva.ListarReservas();
                tablaDatos1.Rows.Clear();
                for (int i = 0; i < resultadoBusqueda.Count; i++)
                {
                    resultadoBusqueda[i].CargarEnTabla(tablaDatos1);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor para realizar la busqueda.");
            }
        }
    }
}
