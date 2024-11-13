using AdministracionPolideportivo.CDatos;
using AdministracionPolideportivo.CNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace AdministracionPolideportivo.CPresentacion
{
    public partial class FormularioCobro : FormularioEstandar
    {
        private ComboBox cbReservas;
        private ComboBox cbMediosPago;
        private TextBox txtMonto;
        private Button btnCobrar;
        private TextBox txtPagosRealizados;
        private Label lblTotal;

        private double totalPagado = 0;

        public FormularioCobro()
        {
            InitializeComponent();
            CrearComponentes();
            CargarDatos();
        }

        private void CrearComponentes()
        {
            // ComboBox para seleccionar reserva
            cbReservas = new ComboBox { Location = new Point(20, 20), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            cbReservas.SelectedIndexChanged += (s, e) => ActualizarTotal();
            Controls.Add(cbReservas);

            // ComboBox para seleccionar medio de pago
            cbMediosPago = new ComboBox { Location = new Point(20, 60), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            Controls.Add(cbMediosPago);

            // TextBox para ingresar el monto
            txtMonto = new TextBox { Location = new Point(20, 100), Width = 200 };
            Controls.Add(txtMonto);

            // Botón para realizar el cobro
            btnCobrar = new Button { Text = "Cobrar", Location = new Point(20, 140), Width = 100 };
            btnCobrar.Click += BtnCobrar_Click;
            Controls.Add(btnCobrar);

            // TextBox multiline para los pagos realizados
            txtPagosRealizados = new TextBox { Location = new Point(250, 20), Width = 300, Height = 200, Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical };
            Controls.Add(txtPagosRealizados);

            // Label para mostrar el total calculado
            lblTotal = new Label { Text = "Total: $0.00", Location = new Point(250, 230), AutoSize = true, ForeColor = Color.White };
            Controls.Add(lblTotal);
        }

        private void CargarDatos()
        {
            // Cargar reservas y medios de pago desde la base de datos
            cbReservas.DataSource = DALReserva.ObtenerReservas();
            cbReservas.DisplayMember = "idReserva";

            cbMediosPago.DataSource = DALMedioPago.ObtenerMediosPago();
            cbMediosPago.DisplayMember = "nombreMedioPago";
        }

        private void ActualizarTotal()
        {
            if (cbReservas.SelectedItem is Reserva reserva)
            {
                // Cálculo del total según el precio del recinto y servicios adicionales de la reserva
                double total = reserva.PrecioRecinto + reserva.ServiciosAdicionales.Sum(s => s.Precio);
                lblTotal.Text = $"Total: ${total:0.00}";
            }
        }

        private void BtnCobrar_Click(object sender, EventArgs e)
        {
            if (cbReservas.SelectedItem is Reserva reserva && cbMediosPago.SelectedItem is MedioPago medioPago && double.TryParse(txtMonto.Text, out double monto))
            {
                // Crear un objeto PagoMedioPago y registrarlo
                PagoMedioPago pagoMedioPago = new PagoMedioPago(new Pago(0, reserva), medioPago, monto);
                DALPagoMedioPago.AgregarPagoMedioPago(pagoMedioPago);

                // Actualizar el total pagado y agregar el pago a la lista de pagos realizados
                totalPagado += monto;
                txtPagosRealizados.AppendText($"Medio: {medioPago.Nombre}, Monto: ${monto:0.00}\r\n");

                // Vaciar el campo de monto
                txtMonto.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, completa todos los campos correctamente.");
            }
        }
    }
}
