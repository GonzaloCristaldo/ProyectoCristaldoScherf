using AdministracionPolideportivo.CDatos;
using AdministracionPolideportivo.CNegocio;
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
            btnCobrar = new BotonFormulario();
            label1 = new Label();
            lblTotal = new Label();
            cbMedioPago = new ComboBoxEstandar();
            lblMedioPago = new Label();
            panel1 = new Panel();
            txtDetalle = new Texto();
            panel2 = new Panel();
            lblMonto = new Label();
            txtMonto = new TextoNumerico();
            cbReserva = new ComboBoxEstandar();
            lblReserva = new Label();
            btnFactura = new BotonFormulario();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            // btnCobrar
            // 
            btnCobrar.BackColor = Color.ForestGreen;
            btnCobrar.Font = new Font("Segoe UI", 10F);
            btnCobrar.ForeColor = Color.White;
            btnCobrar.Location = new Point(194, 234);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(146, 41);
            btnCobrar.TabIndex = 0;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = false;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(14, 156);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = SystemColors.ButtonFace;
            lblTotal.Location = new Point(208, 156);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 15);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "$ _ _ _ _";
            // 
            // cbMedioPago
            // 
            cbMedioPago.BackColor = SystemColors.WindowFrame;
            cbMedioPago.ForeColor = Color.White;
            cbMedioPago.FormattingEnabled = true;
            cbMedioPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta de credito", "Tarjeta de debito", "Mercado Pago", "QR MODO" });
            cbMedioPago.Location = new Point(23, 81);
            cbMedioPago.Name = "cbMedioPago";
            cbMedioPago.Size = new Size(210, 23);
            cbMedioPago.TabIndex = 0;
            // 
            // lblMedioPago
            // 
            lblMedioPago.AutoSize = true;
            lblMedioPago.ForeColor = SystemColors.ButtonHighlight;
            lblMedioPago.Location = new Point(82, 61);
            lblMedioPago.Name = "lblMedioPago";
            lblMedioPago.Size = new Size(87, 15);
            lblMedioPago.TabIndex = 4;
            lblMedioPago.Text = "Forma de pago";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtDetalle);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTotal);
            panel1.Location = new Point(269, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 185);
            panel1.TabIndex = 5;
            // 
            // txtDetalle
            // 
            txtDetalle.BackColor = SystemColors.WindowFrame;
            txtDetalle.ForeColor = Color.White;
            txtDetalle.Location = new Point(3, 3);
            txtDetalle.Multiline = true;
            txtDetalle.Name = "txtDetalle";
            txtDetalle.ScrollBars = ScrollBars.Both;
            txtDetalle.Size = new Size(250, 150);
            txtDetalle.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblMonto);
            panel2.Controls.Add(txtMonto);
            panel2.Controls.Add(cbReserva);
            panel2.Controls.Add(lblReserva);
            panel2.Controls.Add(cbMedioPago);
            panel2.Controls.Add(lblMedioPago);
            panel2.Location = new Point(12, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 185);
            panel2.TabIndex = 6;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.ForeColor = SystemColors.ButtonHighlight;
            lblMonto.Location = new Point(23, 133);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 7;
            lblMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.BackColor = SystemColors.WindowFrame;
            txtMonto.ForeColor = Color.White;
            txtMonto.Location = new Point(72, 130);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(84, 23);
            txtMonto.TabIndex = 1;
            // 
            // cbReserva
            // 
            cbReserva.BackColor = SystemColors.WindowFrame;
            cbReserva.ForeColor = Color.White;
            cbReserva.FormattingEnabled = true;
            cbReserva.Items.AddRange(new object[] { "Efectivo", "Tarjeta de credito", "Tarjeta de debito", "Mercado Pago", "QR MODO" });
            cbReserva.Location = new Point(23, 35);
            cbReserva.Name = "cbReserva";
            cbReserva.Size = new Size(210, 23);
            cbReserva.TabIndex = 5;
            cbReserva.SelectedValueChanged += cbReserva_SelectedValueChanged;
            // 
            // lblReserva
            // 
            lblReserva.AutoSize = true;
            lblReserva.ForeColor = SystemColors.ButtonHighlight;
            lblReserva.Location = new Point(82, 15);
            lblReserva.Name = "lblReserva";
            lblReserva.Size = new Size(47, 15);
            lblReserva.TabIndex = 6;
            lblReserva.Text = "Reserva";
            // 
            // btnFactura
            // 
            btnFactura.BackColor = Color.DimGray;
            btnFactura.Font = new Font("Segoe UI", 10F);
            btnFactura.ForeColor = Color.White;
            btnFactura.Location = new Point(376, 234);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(146, 41);
            btnFactura.TabIndex = 0;
            btnFactura.Text = "Ver Factura";
            btnFactura.UseVisualStyleBackColor = false;
            btnFactura.Click += btnFactura_Click;
            // 
            // CobrarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(537, 287);
            Controls.Add(btnFactura);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnCobrar);
            Controls.Add(labelFormulario1);
            Name = "CobrarReserva";
            Click += CobrarReserva_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        override public void RefrescarCB()
        {
            cbMedioPago.DataSource = DALMedioPago.ListarMedios();
            cbReserva.DataSource = DALReserva.ListarReservas();

        }

        private LabelFormulario labelFormulario1;
        private BotonFormulario btnCobrar;
        private Label label1;
        private ComboBoxEstandar cbMedioPago;
        private Label lblMedioPago;
        private Panel panel1;
        private Panel panel2;
        private Label lblMonto;
        private TextoNumerico txtMonto;
        private ComboBoxEstandar cbReserva;
        private Label lblReserva;
        private Texto txtDetalle;
        private BotonFormulario btnFactura;
        private Label lblTotal;

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            totalReserva -= int.Parse(txtMonto.Text);
            txtMonto.Clear();
            lblTotal.Text = "$" + totalReserva.ToString();
        }
        decimal totalReservaAbsoluto;
        decimal totalReserva;
        List<ServicioAdicional> servicios;
        List<ServicioReserva> serviciosReserva;
        private void cbReserva_SelectedValueChanged(object sender, EventArgs e)
        {
            txtDetalle.Clear();
            totalReserva = 0;
            serviciosReserva = DALServicioReserva.BuscarPorIdReserva(((Reserva)(cbReserva.SelectedItem)).idReserva.ToString());
            servicios = new List<ServicioAdicional>();
            totalReserva = 0;
            for (int i = 0; i < serviciosReserva.Count; i++)
            {
                servicios.Add(DALServicioAdicional.BuscarPorId(serviciosReserva.ElementAt(i).servicio.IdServicio.ToString()).First());
                txtDetalle.Text += servicios.ElementAt(i).NombreServicio + ". $" + servicios.ElementAt(i).Precio + Environment.NewLine;
                totalReserva += servicios.ElementAt(i).Precio;
            }
            decimal precioRecinto = (decimal)DALRecinto.BuscarPorID(((Reserva)(cbReserva.SelectedItem)).recinto.NroRecinto.ToString()).First().TarifaHora;
            totalReserva += precioRecinto;
            totalReservaAbsoluto = totalReserva;
            txtDetalle.Text += "Tarifa del recinto" + ". $" + precioRecinto + Environment.NewLine;
            lblTotal.Text = "$" + totalReserva.ToString();
        }

        private void CobrarReserva_Click(object sender, EventArgs e)
        {

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            GenerarFacturaHTML();
        }

        public void GenerarFacturaHTML()
        {
            string carpetaFacturas = @"C:\Facturas";


            if (!Directory.Exists(carpetaFacturas))
            {
                Directory.CreateDirectory(carpetaFacturas);
            }

            // Obtiene la información seleccionada (cliente y reserva)
            Reserva reservaSeleccionada = (Reserva)cbReserva.SelectedItem;
            Cliente cliente = DALCliente.BuscarPorID(reservaSeleccionada.cliente.IdCliente.ToString()).First();

            // Generar el HTML con los detalles
            string htmlContent = $@"
    <html>
    <head>
        <title>Factura de Reserva</title>
        <style>
            body {{ font-family: Arial, sans-serif; }}
            h1 {{ color: #333; }}
            table {{ width: 100%; border-collapse: collapse; margin-top: 20px; }}
            th, td {{ border: 1px solid #ddd; padding: 8px; text-align: left; }}
            th {{ background-color: #f2f2f2; }}
            .total {{ font-weight: bold; }}
        </style>
    </head>
    <body>
        <h1>Factura de Reserva</h1>
        <p><strong>Cliente:</strong> {cliente.NombreCliente} {cliente.ApellidoCliente}</p>
        <p><strong>DNI:</strong> {cliente.DniCliente}</p>
        <p><strong>Fecha de Reserva:</strong> {reservaSeleccionada.Fecha.ToShortDateString()}</p>

        <table>
            <tr>
                <th>Detalle</th>
                <th>Precio</th>
            </tr>";

            // Agregar servicios adicionales
            foreach (var servicio in servicios)
            {
                htmlContent += $@"
            <tr>
                <td>{servicio.NombreServicio}</td>
                <td>${servicio.Precio}</td>
            </tr>";
            }

            // Agregar tarifa del recinto
            decimal precioRecinto = (decimal)DALRecinto.BuscarPorID(reservaSeleccionada.recinto.NroRecinto.ToString()).First().TarifaHora;
            htmlContent += $@"
            <tr>
                <td>Tarifa del Recinto</td>
                <td>${precioRecinto}</td>
            </tr>";

            // Agregar total
            htmlContent += $@"
            <tr class='total'>
                <td>Total</td>
                <td>${totalReservaAbsoluto}</td>
            </tr>
        </table>
    </body>
    </html>";

            // Guardar el archivo HTML
            string filePath = carpetaFacturas+"\\factura_reserva"+reservaSeleccionada.idReserva+".html";
            File.WriteAllText(filePath, htmlContent);

            MessageBox.Show("Factura generada exitosamente en: " + filePath, "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
