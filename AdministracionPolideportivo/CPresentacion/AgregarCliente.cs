﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionPolideportivo.CDatos;
using AdministracionPolideportivo.CNegocio;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class AgregarCliente : FormularioEstandar
    {
        public AgregarCliente()
        {
            InitializeComponent();

            /* calculamos el punto de
            inicio de los textbox teniendo en cuenta el largo y la ubicacion
            del label mas largo del formulario mas 10 pixeles de separacion entre label
            y textbox*/
            coordenadaXTextbox = lblTelefono.Width + lblTelefono.Location.X + 10;
            modoEdicion=false;
            /*le asignamos la ubicacion calculada a los textbox*/
            txtApellido.Location = new Point(coordenadaXTextbox, txtApellido.Location.Y);
            txtDNI.Location = new Point(coordenadaXTextbox,txtDNI.Location.Y);
            txtNombre.Location = new Point(coordenadaXTextbox,txtNombre.Location.Y);
            txtTelefono.Location = new Point(coordenadaXTextbox,txtTelefono.Location.Y);

        }
        bool modoEdicion;
        int idCliente;
        public AgregarCliente(bool editar,int id_cliente)
        {
            InitializeComponent();
            idCliente= id_cliente;
            /* calculamos el punto de
            inicio de los textbox teniendo en cuenta el largo y la ubicacion
            del label mas largo del formulario mas 10 pixeles de separacion entre label
            y textbox*/
            coordenadaXTextbox = lblTelefono.Width + lblTelefono.Location.X + 10;
            modoEdicion = editar;
            /*le asignamos la ubicacion calculada a los textbox*/
            txtApellido.Location = new Point(coordenadaXTextbox, txtApellido.Location.Y);
            txtDNI.Location = new Point(coordenadaXTextbox, txtDNI.Location.Y);
            txtNombre.Location = new Point(coordenadaXTextbox, txtNombre.Location.Y);
            txtTelefono.Location = new Point(coordenadaXTextbox, txtTelefono.Location.Y);
            btnAgregarCliente.Text = "Editar";

        }


        private LabelFormulario lblDNI;
        private LabelFormulario lblNombre;
        public Texto txtNombre;
        private LabelFormulario lblApellido;
        public Texto txtApellido;
        private LabelFormulario lblTelefono;
        public TextoNumerico txtTelefono;
        private BotonFormulario btnAgregarCliente;
        public TextoNumerico txtDNI;

        
        int coordenadaXTextbox;

        override public void RefrescarCB()
        {
            //TODO
        }

        private void InitializeComponent()
        {
            lblDNI = new LabelFormulario();
            txtDNI = new TextoNumerico();
            lblNombre = new LabelFormulario();
            txtNombre = new Texto();
            lblApellido = new LabelFormulario();
            txtApellido = new Texto();
            lblTelefono = new LabelFormulario();
            txtTelefono = new TextoNumerico();
            btnAgregarCliente = new BotonFormulario();
            SuspendLayout();
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 13F);
            lblDNI.ForeColor = Color.White;
            lblDNI.Location = new Point(22, 21);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(55, 25);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "D.N.I.";
            // 
            // txtDNI
            // 
            txtDNI.BackColor = SystemColors.WindowFrame;
            txtDNI.ForeColor = Color.White;
            txtDNI.Location = new Point(106, 24);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(210, 23);
            txtDNI.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 13F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(22, 67);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.WindowFrame;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(106, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 23);
            txtNombre.TabIndex = 0;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 13F);
            lblApellido.ForeColor = Color.White;
            lblApellido.Location = new Point(22, 118);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 25);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = SystemColors.WindowFrame;
            txtApellido.ForeColor = Color.White;
            txtApellido.Location = new Point(106, 118);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(210, 23);
            txtApellido.TabIndex = 0;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 13F);
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(22, 166);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(79, 25);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.WindowFrame;
            txtTelefono.ForeColor = Color.White;
            txtTelefono.Location = new Point(106, 169);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(210, 23);
            txtTelefono.TabIndex = 1;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = Color.DimGray;
            btnAgregarCliente.Font = new Font("Segoe UI", 10F);
            btnAgregarCliente.ForeColor = Color.White;
            btnAgregarCliente.Location = new Point(106, 225);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(146, 41);
            btnAgregarCliente.TabIndex = 0;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // AgregarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(327, 275);
            Controls.Add(btnAgregarCliente);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            MinimumSize = new Size(327, 275);
            Name = "AgregarCliente";
            Resize += AgregarCliente_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (modoEdicion)
            {
                try
                {
                    // Validación de campos en el formulario
                    if (string.IsNullOrEmpty(txtDNI.Text) || !int.TryParse(txtDNI.Text, out int dni))
                    {
                        MessageBox.Show("Por favor, ingrese un DNI válido.");
                        return;
                    }

                    if (string.IsNullOrEmpty(txtNombre.Text))
                    {
                        MessageBox.Show("Por favor, ingrese un nombre.");
                        return;
                    }

                    if (string.IsNullOrEmpty(txtApellido.Text))
                    {
                        MessageBox.Show("Por favor, ingrese un apellido.");
                        return;
                    }

                    if (string.IsNullOrEmpty(txtTelefono.Text) || txtTelefono.Text.Length < 7)
                    {
                        MessageBox.Show("Por favor, ingrese un teléfono válido.");
                        return;
                    }

                    var confirmResult = MessageBox.Show("¿Estas seguro que deseas editar los datos del cliente?",
                                         "Confirmar edicion de cliente",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (confirmResult == DialogResult.Yes)
                    {

                        // Crea el cliente y llama a la capa de datos
                        Cliente cliente = new Cliente(dni, txtNombre.Text, txtApellido.Text, txtTelefono.Text);
                        cliente.IdCliente = this.idCliente;
                        int resultado = DALCliente.EditarCliente(cliente);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Cliente editado exitosamente.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al editar el cliente.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    // Validación de campos en el formulario
                    if (string.IsNullOrEmpty(txtDNI.Text) || !int.TryParse(txtDNI.Text, out int dni))
                    {
                        MessageBox.Show("Por favor, ingrese un DNI válido.");
                        return;
                    }

                    if (string.IsNullOrEmpty(txtNombre.Text))
                    {
                        MessageBox.Show("Por favor, ingrese un nombre.");
                        return;
                    }

                    if (string.IsNullOrEmpty(txtApellido.Text))
                    {
                        MessageBox.Show("Por favor, ingrese un apellido.");
                        return;
                    }

                    if (string.IsNullOrEmpty(txtTelefono.Text) || txtTelefono.Text.Length < 7)
                    {
                        MessageBox.Show("Por favor, ingrese un teléfono válido.");
                        return;
                    }

                    var confirmResult = MessageBox.Show("¿Estas seguro que deseas agregar un nuevo cliente?",
                                         "Confirmar alta de cliente",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (confirmResult == DialogResult.Yes)
                    {

                        // Crea el cliente y llama a la capa de datos
                        Cliente cliente = new Cliente(dni, txtNombre.Text, txtApellido.Text, txtTelefono.Text);
                        int resultado = DALCliente.AgregarCliente(cliente);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Cliente agregado exitosamente.");
                            LimpiarCampos(); // Limpia los campos después de agregar el cliente
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar el cliente.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            
        }

        // Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
        }

        private void AgregarCliente_Resize(object sender, EventArgs e)
        {

            /*Calculamos dinamicamente el espacio que debe ocupar los textbox
             tomando como referencia el ancho de la ventana y restando el espacio
            que ocupan los label y una cantidad de pixeles de separacion con el margen
            de la ventana*/
            int anchoTextBox = this.Width - coordenadaXTextbox - 20;

            //Le asignamos el nuevo tamaño calculado a cada textbox
            txtApellido.Width = anchoTextBox;
            txtTelefono.Width = anchoTextBox;
            txtDNI.Width = anchoTextBox;
            txtNombre.Width = anchoTextBox;
        }
    }
}
