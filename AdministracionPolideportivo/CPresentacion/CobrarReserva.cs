using AdministracionPolideportivo.CDatos;
using AdministracionPolideportivo.CNegocio;
using AdministracionPolideportivo.Properties;
using Microsoft.IdentityModel.Tokens;

//using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class CobrarReserva : FormularioEstandar
    {

        public CobrarReserva(Usuario user)
        {
            InitializeComponent();
            usuario=user;
        }

        Usuario usuario;

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
            lblTotal.Click += lblTotal_Click;
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
            panel2.Controls.Add(cbReserva);
            panel2.Controls.Add(lblReserva);
            panel2.Controls.Add(cbMedioPago);
            panel2.Controls.Add(lblMedioPago);
            panel2.Location = new Point(12, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 185);
            panel2.TabIndex = 6;
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
            cbReserva.DataSource = DALReserva.ListarReservasSinPagar();

        }

        private LabelFormulario labelFormulario1;
        private BotonFormulario btnCobrar;
        private Label label1;
        private ComboBoxEstandar cbMedioPago;
        private Label lblMedioPago;
        private Panel panel1;
        private Panel panel2;
        private ComboBoxEstandar cbReserva;
        private Label lblReserva;
        private Texto txtDetalle;
        private BotonFormulario btnFactura;
        private Label lblTotal;

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            //totalReserva -= int.Parse(txtMonto.Text);
            //txtMonto.Clear();
            //lblTotal.Text = "$" + totalReserva.ToString();

            if (!cbReserva.Text.IsNullOrEmpty())
            {
                int resultado = DALPago.AgregarPago(new Pago(0, (Reserva)cbReserva.SelectedItem, usuario, (MedioPago)cbMedioPago.SelectedItem, (int)totalReservaAbsoluto));
                if (resultado > 0)
                {
                    MessageBox.Show("Reserva saldada. El pago se registro correctamente.");
                    cbReserva.SelectedIndex=-1;
                    RefrescarCB();
                } 
            }
        
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
            
            DialogResult result = MessageBox.Show("¿Deseas generar la factura?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
                GenerarFacturaHTML();
            }
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

            // Información del complejo deportivo
            string razonSocial = "Complejo Polideportivo Taraguinense";
            string cuit = "30-12345678-9";
            string direccionComplejo = "Ruta 12 Km 1037, Corrientes, Argentina";
            string inicioActividades = "01/02/2023";

            // Hora actual de expedición de la factura
            string horaExpedicion = DateTime.Now.ToString("HH:mm:ss");

            // Ruta del logo de fondo en la carpeta de Resources
            string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources", "Logo_Taraguinense.png");

            // Convertir el logo a Base64
            string logoBase64 = "";
            if (File.Exists(logoPath))
            {
                byte[] imageBytes = File.ReadAllBytes(logoPath);
                logoBase64 = Convert.ToBase64String(imageBytes);
            }

            // Generar el HTML con los detalles, usando el logo en Base64
            string htmlContent = $@"
<html>
<head>
    <title>Factura de Reserva</title>
    <style>
        body {{ font-family: Arial, sans-serif; color: #333; background-color: #f9f9f9; margin: 0; padding: 20px; }}
        .container {{
            width: 80%;
            margin: auto;
            padding: 20px;
            background-color: #fff;
            box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
            position: relative;
        }}
        .logo {{
            position: absolute;
            top: 50px;
            left: 50%;
            transform: translateX(-50%);
            opacity: 0.1;
            width: 300px;
            height: auto;
        }}
        h1 {{ color: #444; text-align: center; font-size: 24px; }}
        p {{ font-size: 14px; line-height: 1.6; }}
        
        /* Sección de encabezado (Cliente y Complejo) */
        .factura-header {{
            display: flex;
            justify-content: space-between;
            margin-bottom: 20px;
            width: 100%;
        }}
        .factura-column-iz {{
            text-align: center;
            width: 45%;
            margin: 0;
            box-sizing: border-box;
        }}

        .factura-column-der {{
            text-align: center;
            width: 45%;
            margin: 0;
            box-sizing: border-box;
        }}
        
        /* Tabla de servicios */
        table {{
            width: 60%;
            margin: 20px auto;
            border-collapse: collapse;
        }}
        th, td {{
            border: 1px solid #ddd;
            padding: 10px;
            text-align: left;
            font-size: 14px;
        }}
        th {{ background-color: #f2f2f2; font-weight: bold; }}
        .total {{ font-weight: bold; color: #333; }}
        .precio-col {{
            width: 100px;
            text-align: right;
        }}
    </style>
</head>
<body>
    <div class='container'>
        <img src='data:image/png;base64,{logoBase64}' class='logo' alt='Logo' />
        <h1>Factura de Reserva</h1>
        
        <div class='factura-header'>
            <!-- Columna de Cliente -->
            <div class='factura-column-iz'>
                <p><strong>Cliente:</strong> {cliente.NombreCliente} {cliente.ApellidoCliente}</p>
                <p><strong>DNI:</strong> {cliente.DniCliente}</p>
                <p><strong>Fecha de Reserva:</strong> {reservaSeleccionada.Fecha.ToShortDateString()}</p>
            </div>
            <!-- Columna del Complejo -->
            <div class='factura-column-der'>
                <p><strong>Razón Social:</strong> {razonSocial}</p>
                <p><strong>CUIT:</strong> {cuit}</p>
                <p><strong>Dirección:</strong> {direccionComplejo}</p>
                <p><strong>Inicio de Actividades:</strong> {inicioActividades}</p>
                <p><strong>Hora de Expedición:</strong> {horaExpedicion}</p>
            </div>
        </div>

        <table>
            <tr>
                <th>Detalle</th>
                <th class='precio-col'>Precio</th>
            </tr>";

            // Agregar servicios adicionales
            foreach (var servicio in servicios)
            {
                htmlContent += $@"
            <tr>
                <td>{servicio.NombreServicio}</td>
                <td class='precio-col'>${servicio.Precio}</td>
            </tr>";
            }

            // Agregar tarifa del recinto
            decimal precioRecinto = (decimal)DALRecinto.BuscarPorID(reservaSeleccionada.recinto.NroRecinto.ToString()).First().TarifaHora;
            htmlContent += $@"
            <tr>
                <td>Tarifa del Recinto</td>
                <td class='precio-col'>${precioRecinto}</td>
            </tr>";

            // Agregar total
            htmlContent += $@"
            <tr class='total'>
                <td>Total</td>
                <td class='precio-col'>${totalReservaAbsoluto}</td>
            </tr>
        </table>
    </div>
</body>
</html>";

            // Guardar el archivo HTML
            string filePath = Path.Combine(carpetaFacturas, "factura_reserva" + reservaSeleccionada.idReserva + ".html");
            File.WriteAllText(filePath, htmlContent);

            MessageBox.Show("Factura generada exitosamente en: " + filePath, "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = carpetaFacturas,
                FileName = "explorer.exe",

            };
            Process.Start(startInfo);
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
