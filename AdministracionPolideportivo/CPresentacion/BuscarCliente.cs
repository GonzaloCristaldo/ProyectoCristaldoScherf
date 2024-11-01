using AdministracionPolideportivo.CDatos;
using AdministracionPolideportivo.CNegocio;
using AdministracionPolideportivo.CPresentacion.Recepcionista;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class BuscarCliente : FormularioEstandar
    {
        public BuscarCliente()
        {

            InitializeComponent();
            tabla.setDatoModelo(new Cliente(1, 1, "", "", ""));

        }

        private BotonFormulario btnBuscar;
        private ComboBoxEstandar cbBuscar;
        private LabelFormulario lblBuscar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private TablaDatos tabla;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;

        /*private TablaDatos tablaClientes;*/
        private Texto txtBuscar;

        private void InitializeComponent()
        {
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            btnBuscar = new BotonFormulario();
            cbBuscar = new ComboBoxEstandar();
            lblBuscar = new LabelFormulario();
            txtBuscar = new Texto();
            tabla = new TablaDatos();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "DNI";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Apellido";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Telefono";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DimGray;
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(437, 40);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 41);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar Cliente";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cbBuscar
            // 
            cbBuscar.BackColor = SystemColors.WindowFrame;
            cbBuscar.ForeColor = Color.White;
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Items.AddRange(new object[] { "ID", "DNI", "Nombre", "Apellido", "Telefono", "Listar Clientes" });
            cbBuscar.Location = new Point(232, 12);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(183, 23);
            cbBuscar.TabIndex = 0;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 13F);
            lblBuscar.ForeColor = Color.White;
            lblBuscar.Location = new Point(68, 7);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(158, 25);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar Cliente por:";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.WindowFrame;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(68, 51);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(347, 23);
            txtBuscar.TabIndex = 0;
            // 
            // tabla
            // 
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16 });
            tabla.Location = new Point(12, 92);
            tabla.Name = "tabla";
            tabla.Size = new Size(644, 306);
            tabla.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Id";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "DNI";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Nombre";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "Apellido";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.HeaderText = "Telefono";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.HeaderText = "Modificar";
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // BuscarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(669, 410);
            Controls.Add(tabla);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(cbBuscar);
            Controls.Add(btnBuscar);
            MinimumSize = new Size(669, 410);
            Name = "BuscarCliente";
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void cargarResultado()
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (!txtBuscar.Text.IsNullOrEmpty())
            {
                List<Cliente> resultadoBusqueda = new List<Cliente>();
                if (!cbBuscar.Text.Equals("Listar Clientes"))
                {
                    if (cbBuscar.Text.Equals("ID"))
                    {
                        resultadoBusqueda = DALCliente.BuscarPorID(txtBuscar.Text);
                    }
                    else if (cbBuscar.Text.Equals("DNI"))
                    {
                        resultadoBusqueda = DALCliente.BuscarPorDNI(txtBuscar.Text);
                    }
                    else if (cbBuscar.Text.Equals("Nombre"))
                    {
                        resultadoBusqueda = DALCliente.BuscarPorNombre(txtBuscar.Text);
                    }
                    else if (cbBuscar.Text.Equals("Apellido"))
                    {
                        resultadoBusqueda = DALCliente.BuscarPorApellido(txtBuscar.Text);
                    }
                    else if (cbBuscar.Text.Equals("Telefono"))
                    {
                        resultadoBusqueda = DALCliente.BuscarPorTelefono(txtBuscar.Text);
                    }
                }
                
                else
                {
                    resultadoBusqueda = DALCliente.ListarClientes();
                }
                tabla.Rows.Clear();
                for (int i = 0; i < resultadoBusqueda.Count; i++)
                {
                    resultadoBusqueda[i].CargarEnTabla(tabla);
                }
            }
            else if(cbBuscar.Text.Equals("Listar Clientes"))
            {
                List<Cliente> resultadoBusqueda = DALCliente.ListarClientes();
                tabla.Rows.Clear();
                for (int i = 0; i < resultadoBusqueda.Count; i++)
                {
                    resultadoBusqueda[i].CargarEnTabla(tabla);
                }
            }else
            {
                MessageBox.Show("Por favor, ingrese un valor para realizar la busqueda.");
            }

        }
    }


}
