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
        }

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


            lblNumero.Location = new Point((panelIzquierda.Width-lblNumero.Width)/2,lblNumero.Location.Y);
            lblTarifa.Location = new Point((panelIzquierda.Width - lblTarifa.Width) / 2, lblTarifa.Location.Y);
            lblTipo.Location = new Point((panelIzquierda.Width - lblTipo.Width) / 2, lblTipo.Location.Y);
            lblUbicacion.Location = new Point((panelIzquierda.Width - lblUbicacion.Width) / 2, lblUbicacion.Location.Y);
            btnAgregar.Location = new Point((panelIzquierda.Width - btnAgregar.Width) / 2, btnAgregar.Location.Y);
            cbTipo.Location = new Point((panelIzquierda.Width - cbTipo.Width) / 2, cbTipo.Location.Y);

            lblServicio.Location = new Point((panelDerecha.Width - lblServicio.Width) / 2, lblServicio.Location.Y);
            btnAgregarServicio.Location = new Point((panelDerecha.Width - btnAgregarServicio.Width) / 2, btnAgregarServicio.Location.Y);

            cbTipo.Width = panelDerecha.Width - 40;
            cbTipo.Location = new Point((panelIzquierda.Width-cbTipo.Width)/2,cbTipo.Location.Y);

            txtTarifa.Width = panelIzquierda.Width - 40;
            txtTarifa.Location = new Point((panelIzquierda.Width - txtTarifa.Width) / 2, txtTarifa.Location.Y);

            txtUbicacion.Width = panelIzquierda.Width - 40;
            txtUbicacion.Location = new Point((panelIzquierda.Width - txtUbicacion.Width ) / 2, txtUbicacion.Location.Y);
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
                    recinto.estado = DALEstado.BuscarEstado("funcionando");
                    recinto.tipoRecinto = (TipoRecinto)cbTipo.SelectedItem;
                    recinto.Ubicacion = txtUbicacion.Text;
                    recinto.NroRecinto = Int32.Parse(txtNumCancha.Text);
                    DALRecinto.AgregarRecinto(recinto);
                }
            }
        }

        private void AgregarRecinto_Resize(object sender, EventArgs e)
        {
            UbicarControles();
        }
    }
}
