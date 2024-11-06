using AdministracionPolideportivo.CDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionPolideportivo.CPresentacion.SuperAdmin
{
    internal class BackupBDD : FormularioEstandar
    {
        private SaveFileDialog saveFileDialog;

        public BackupBDD()
        {
            InitializeComponent();

            
            string carpetaBackup = @"C:\BackupsComplejoPolideportivo";

        
            if (!Directory.Exists(carpetaBackup))
            {
                Directory.CreateDirectory(carpetaBackup);
            }

            saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivos de Backup (*.bak)|*.bak",
                Title = "Guardar Backup de la Base de Datos",
                InitialDirectory = carpetaBackup,
                FileName = "RespaldoComplejoPolideportivo.bak"
            };
        }

        override public void RefrescarCB()
        {
            // TODO
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupBDD));
            labelFormulario1 = new LabelFormulario();
            botonFormulario1 = new BotonFormulario();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelFormulario1
            // 
            labelFormulario1.AutoSize = true;
            labelFormulario1.Font = new Font("Segoe UI", 15F);
            labelFormulario1.ForeColor = Color.White;
            labelFormulario1.Location = new Point(183, 9);
            labelFormulario1.Name = "labelFormulario1";
            labelFormulario1.Size = new Size(247, 28);
            labelFormulario1.TabIndex = 0;
            labelFormulario1.Text = "Backup de la Base de datos";
            // 
            // botonFormulario1
            // 
            botonFormulario1.BackColor = Color.DimGray;
            botonFormulario1.Font = new Font("Segoe UI", 10F);
            botonFormulario1.ForeColor = Color.White;
            botonFormulario1.Location = new Point(229, 260);
            botonFormulario1.Name = "botonFormulario1";
            botonFormulario1.Size = new Size(150, 62);
            botonFormulario1.TabIndex = 0;
            botonFormulario1.Text = "Generar archivo de respaldo";
            botonFormulario1.UseVisualStyleBackColor = false;
            botonFormulario1.Click += botonFormulario1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(137, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(344, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BackupBDD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(647, 334);
            Controls.Add(pictureBox1);
            Controls.Add(botonFormulario1);
            Controls.Add(labelFormulario1);
            Name = "BackupBDD";
            Load += AgregarMedioPago_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void AgregarMedioPago_Load(object sender, EventArgs e)
        {
            // Código de inicialización si es necesario
        }

        private void botonFormulario1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string backupPath = saveFileDialog.FileName; // Obtiene la ruta seleccionada por el usuario

                using (SqlConnection connection = ConexionDB.GetConexion())
                {
                    string query = $"BACKUP DATABASE [complejoPolideportivo] TO DISK = '{backupPath}'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Backup creado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al crear el backup: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private LabelFormulario labelFormulario1;
        private BotonFormulario botonFormulario1;
        private PictureBox pictureBox1;
    }
}
