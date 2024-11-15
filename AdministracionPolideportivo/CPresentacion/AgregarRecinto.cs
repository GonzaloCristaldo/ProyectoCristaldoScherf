using AdministracionPolideportivo.CNegocio;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministracionPolideportivo.CDatos;


namespace AdministracionPolideportivo.CPresentacion.Recepcionista
{
    public partial class AgregarRecinto : AdministracionPolideportivo.CPresentacion.FormularioEstandar
    {
        public AgregarRecinto()
        {
            InitializeComponent();
            ubiPanel1 = 20;
            anchoPaneles = (this.Width / 2) - 50;
            ubiPanel2 += anchoPaneles + 30;
            UbicarControles();
            RefrescarCB();
            cbHabilitado.Hide();
            modoEdicion = false;
            nroRecinto = -1;
            cbTipo.Enabled = true;
        }
        bool modoEdicion;
        int nroRecinto;
        public AgregarRecinto(bool editar, int nro_recinto)
        {
            modoEdicion= editar;
            nroRecinto = nro_recinto;

            


            InitializeComponent();
            ubiPanel1 = 20;
            anchoPaneles = (this.Width / 2) - 50;
            ubiPanel2 += anchoPaneles + 30;
            UbicarControles();
            RefrescarCB();
            btnAgregar.Text = "Editar";
            lblNumero.Text="Estado del recinto";
            cbTipo.Enabled = false;
            cbHabilitado.Location = txtNumCancha.Location;
            txtNumCancha.Hide();
        }
        


        List<String> servicios = new List<String>();

        int anchoPaneles;

        int ubiPanel1;
        int ubiPanel2;

        override public void RefrescarCB()
        {
            cbTipo.DataSource = DALTipoRecinto.ListarTiposRecinto();
            cbServicioAdicional.DataSource = DALServicioAdicional.ListarServicios();
        }

        private void UbicarControles()
        {
            anchoPaneles = (this.Width / 2) - 25;
            panelIzquierda.Width = anchoPaneles;
            panelDerecha.Width = anchoPaneles;

            ubiPanel1 = 20;

            ubiPanel2 = anchoPaneles + 30;

            lblTitulo.Location = new Point((this.Width - lblTitulo.Width) / 2, lblTitulo.Location.Y);

            panelIzquierda.Location = new Point(ubiPanel1, panelIzquierda.Location.Y);
            panelDerecha.Location = new Point(ubiPanel2, panelDerecha.Location.Y);

            txtNumCancha.Width = panelIzquierda.Width - 40;
            txtNumCancha.Location = new Point(ubiPanel1, txtNumCancha.Location.Y);

            cbServicioAdicional.Width = panelDerecha.Width - 40;
            cbServicioAdicional.Location = new Point(ubiPanel1, cbServicioAdicional.Location.Y);

            txtServiciosAgregados.Width = panelDerecha.Width;
            txtServiciosAgregados.Location = new Point((panelDerecha.Width - txtServiciosAgregados.Width) / 2, txtServiciosAgregados.Location.Y);


            lblNumero.Location = new Point((panelIzquierda.Width - lblNumero.Width) / 2, lblNumero.Location.Y);
            lblTarifa.Location = new Point((panelIzquierda.Width - lblTarifa.Width) / 2, lblTarifa.Location.Y);
            lblTipo.Location = new Point((panelIzquierda.Width - lblTipo.Width) / 2, lblTipo.Location.Y);
            lblUbicacion.Location = new Point((panelIzquierda.Width - lblUbicacion.Width) / 2, lblUbicacion.Location.Y);
            btnAgregar.Location = new Point((panelIzquierda.Width - btnAgregar.Width) / 2, btnAgregar.Location.Y);
            cbTipo.Location = new Point((panelIzquierda.Width - cbTipo.Width) / 2, cbTipo.Location.Y);

            lblServicio.Location = new Point((panelDerecha.Width - lblServicio.Width) / 2, lblServicio.Location.Y);
            btnAgregarServicio.Location = new Point((panelDerecha.Width - btnAgregarServicio.Width) / 2, btnAgregarServicio.Location.Y);

            cbTipo.Width = panelDerecha.Width - 40;
            cbTipo.Location = new Point((panelIzquierda.Width - cbTipo.Width) / 2, cbTipo.Location.Y);

            txtTarifa.Width = panelIzquierda.Width - 40;
            txtTarifa.Location = new Point((panelIzquierda.Width - txtTarifa.Width) / 2, txtTarifa.Location.Y);

            txtUbicacion.Width = panelIzquierda.Width - 40;
            txtUbicacion.Location = new Point((panelIzquierda.Width - txtUbicacion.Width) / 2, txtUbicacion.Location.Y);
        }

        private void labelFormulario1_Click(object sender, EventArgs e)
        {

        }

        private void labelFormulario1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelFormulario1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int resultado;
            if (modoEdicion)
            {
                if (txtTarifa.Text.IsNullOrEmpty() || txtUbicacion.Text.IsNullOrEmpty() || cbTipo.Text.IsNullOrEmpty())
                {
                    List<String> vacios = new List<String>();
                    if (txtTarifa.Text.IsNullOrEmpty())
                    {
                        vacios.Add("Tarifa");
                    }
                    if (txtUbicacion.Text.IsNullOrEmpty())
                    {
                        vacios.Add("Ubicacion");
                    }
                    if (cbTipo.Text.IsNullOrEmpty())
                    {
                        vacios.Add("tipo de recinto");
                    }
                    String mensaje = "Por favor, complete los siguientes campos: ";
                    for (int i = 0; i < vacios.Count; i++)
                    {
                        if (i + 1 < vacios.Count)
                        {
                            mensaje += vacios[i] + ", ";
                        }
                        else
                        {
                            mensaje += vacios[i] + ".";
                        }

                    }
                    MessageBox.Show(mensaje);
                    return;
                }
                else
                {
                    var confirmResult = MessageBox.Show("¿Estas seguro que deseas modificar un recinto?",
                                         "Confirmar edición recinto",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (confirmResult == DialogResult.Yes)
                    {
                        Recinto recinto = new Recinto();
                        recinto.TarifaHora = Int32.Parse(txtTarifa.Text);
                        

                        if (cbHabilitado.Checked)
                        {
                            recinto.estado = DALEstado.BuscarEstadoNombre("funcionando");
                        }
                        else
                        {
                            recinto.estado = DALEstado.BuscarEstadoNombre("deshabilitado");
                        }

                        recinto.tipoRecinto = (TipoRecinto)cbTipo.SelectedItem;
                        recinto.Ubicacion = txtUbicacion.Text;
                        recinto.NroRecinto = this.nroRecinto;
                        

                        resultado = DALRecinto.EditarRecinto(recinto);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Recinto editado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("Error al editar el recinto.");
                        }

                        if (resultado>0)
                        {
                            for (int i = 0; i < servicios.Count; i++)
                            {
                                ServicioAdicional servicio = DALServicioAdicional.BuscarPorNombre(servicios.ElementAt(i)).First();
                                resultado = DALRecintoServicio.AgregarRelacion(recinto, servicio);
                                if (resultado > 0)
                                {
                                    MessageBox.Show("Servicio agregado al recinto editado exitosamente.");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al agregar el servicio " + servicio.NombreServicio + " al recinto editado.");
                                }
                            } 
                        }
                        Close();
                    }
                }
            }
            else//modo insercion o no edicion
            {
                if (txtNumCancha.Text.IsNullOrEmpty() || txtTarifa.Text.IsNullOrEmpty() || txtUbicacion.Text.IsNullOrEmpty() || cbTipo.Text.IsNullOrEmpty())
                {
                    List<String> vacios = new List<String>();
                    if (txtNumCancha.Text.IsNullOrEmpty())
                    {
                        vacios.Add("Numero de Recinto");
                    }
                    if (txtTarifa.Text.IsNullOrEmpty())
                    {
                        vacios.Add("Tarifa");
                    }
                    if (txtUbicacion.Text.IsNullOrEmpty())
                    {
                        vacios.Add("Ubicacion");
                    }
                    if (cbTipo.Text.IsNullOrEmpty())
                    {
                        vacios.Add("tipo de recinto");
                    }
                    String mensaje = "Por favor, complete los siguientes campos: ";
                    for (int i = 0; i < vacios.Count; i++)
                    {
                        if (i + 1 < vacios.Count)
                        {
                            mensaje += vacios[i] + ", ";
                        }
                        else
                        {
                            mensaje += vacios[i] + ".";
                        }

                    }
                    MessageBox.Show(mensaje);
                    return;
                }
                else
                {
                    var confirmResult = MessageBox.Show("¿Estas seguro que deseas agregar un nuevo recinto?",
                                         "Confirmar alta de recinto",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (confirmResult == DialogResult.Yes)
                    {
                        Recinto recinto = new Recinto();
                        recinto.TarifaHora = Int32.Parse(txtTarifa.Text);
                        recinto.estado = DALEstado.BuscarEstadoNombre("funcionando");
                        recinto.tipoRecinto = (TipoRecinto)cbTipo.SelectedItem;
                        recinto.Ubicacion = txtUbicacion.Text;
                        recinto.NroRecinto = Int32.Parse(txtNumCancha.Text);
                        DALRecinto.AgregarRecinto(recinto);

                        for (int i = 0; i < servicios.Count; i++)
                        {
                            DALRecintoServicio.AgregarRelacion(recinto, DALServicioAdicional.BuscarPorNombre(servicios.ElementAt(i)).First());
                        }
                        LimpiarCampos();
                    }
                }
            }

               
        }

        // Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtNumCancha.Clear();
            txtServiciosAgregados.Clear();
            txtTarifa.Clear();
            txtUbicacion.Clear();
            servicios = new List<string>();
        }

        private void AgregarRecinto_Resize(object sender, EventArgs e)
        {
            UbicarControles();
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            if (!servicios.Contains(cbServicioAdicional.Text))
            {
                servicios.Add(cbServicioAdicional.Text);
                txtServiciosAgregados.AppendText(cbServicioAdicional.Text);
                txtServiciosAgregados.AppendText(Environment.NewLine);
            }
            
        }
    }
}
