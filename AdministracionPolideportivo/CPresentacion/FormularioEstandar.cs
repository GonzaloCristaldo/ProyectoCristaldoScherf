using AdministracionPolideportivo.CDatos;
using AdministracionPolideportivo.CNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionPolideportivo.CPresentacion
{
    public partial class FormularioEstandar : Form, Refrescable
    {
        
        public FormularioEstandar()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.BackColor = Color.FromArgb(49, 49, 49);
        }

        public virtual void RefrescarCB()
        {
            //todo
        }


        /*{
            //GENERICO
        }*/
    }
}
