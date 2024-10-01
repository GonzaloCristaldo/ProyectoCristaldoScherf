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

namespace AdministracionPolideportivo.CPresentacion.Recepcionista
{
    public partial class AgregarRecinto : AdministracionPolideportivo.CPresentacion.FormularioEstandar
    {
        public AgregarRecinto()
        {
            InitializeComponent();
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
                for (int i=0;i<vacios.Count;i++)
                {
                    if (i + 1 < vacios.Count)
                    {
                        mensaje += vacios[i] + ", ";
                    }
                    else
                    {
                        mensaje += vacios[i]+".";
                    }
                    
                }
                MessageBox.Show(mensaje);
                return;
            }
        }
    }
}
