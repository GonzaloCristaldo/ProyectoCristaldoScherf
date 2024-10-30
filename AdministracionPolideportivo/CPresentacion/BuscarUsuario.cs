using AdministracionPolideportivo.CDatos;
using AdministracionPolideportivo.CNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class BuscarUsuario : FormularioEstandar
    {

        public BuscarUsuario()
        {
            InitializeComponent();
            tablaDatos1.setDatoModelo(new Usuario());

            byte[] imageData= DALUsuario.pruebaFoto();
            Bitmap bmp;
            using (var ms = new MemoryStream(imageData))
            {
                bmp = new Bitmap(ms);
            }

            fotoUsuario.Image = bmp;
        }


        private TablaDatos tablaDatos1;


        private void InitializeComponent()
        {
            tablaDatos1 = new TablaDatos();
            btnBuscar = new BotonFormulario();
            cbBuscar = new ComboBoxEstandar();
            txtBuscar = new Texto();
            labelFormulario1 = new LabelFormulario();
            fotoUsuario = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)tablaDatos1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fotoUsuario).BeginInit();
            SuspendLayout();
            // 
            // tablaDatos1
            // 
            tablaDatos1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaDatos1.Location = new Point(12, 159);
            tablaDatos1.MultiSelect = false;
            tablaDatos1.Name = "tablaDatos1";
            tablaDatos1.ReadOnly = true;
            tablaDatos1.Size = new Size(776, 279);
            tablaDatos1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DimGray;
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(336, 112);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 41);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar Usuario";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cbBuscar
            // 
            cbBuscar.BackColor = SystemColors.WindowFrame;
            cbBuscar.ForeColor = Color.White;
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Location = new Point(303, 40);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(210, 23);
            cbBuscar.TabIndex = 0;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.WindowFrame;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(267, 72);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(291, 23);
            txtBuscar.TabIndex = 0;
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.Font = new Font("Segoe UI", 15F);
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(321, 9);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(180, 28);
            labelFormulario1.TabIndex = 1;
            labelFormulario1.Text = "Buscar Usuario por:";
            // 
            // fotoUsuario
            // 
            fotoUsuario.Location = new Point(584, 9);
            fotoUsuario.Name = "fotoUsuario";
            fotoUsuario.Size = new Size(154, 144);
            fotoUsuario.TabIndex = 2;
            fotoUsuario.TabStop = false;
            // 
            // BuscarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(800, 450);
            Controls.Add(fotoUsuario);
            Controls.Add(labelFormulario1);
            Controls.Add(txtBuscar);
            Controls.Add(cbBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(tablaDatos1);
            MinimumSize = new Size(800, 450);
            Name = "BuscarUsuario";
            ((System.ComponentModel.ISupportInitialize)tablaDatos1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fotoUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private BotonFormulario btnBuscar;
        private ComboBoxEstandar cbBuscar;
        private Texto txtBuscar;
        private LabelFormulario labelFormulario1;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Usuario> resultadoBusqueda = DALUsuario.ListarUsuarios();
            tablaDatos1.Rows.Clear();
            for (int i = 0; i < resultadoBusqueda.Count; i++)
            {
                resultadoBusqueda[i].CargarEnTabla(tablaDatos1);
            }
        }

        private PictureBox fotoUsuario;
    }
}
