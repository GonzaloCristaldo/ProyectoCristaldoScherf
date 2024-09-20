namespace AdministracionPolideportivo.CPresentacion.Recepcionista
{
    partial class AgregarCancha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botonFormulario1 = new BotonFormulario();
            SuspendLayout();
            // 
            // botonFormulario1
            // 
            botonFormulario1.BackColor = Color.DimGray;
            botonFormulario1.Font = new Font("Segoe UI", 10F);
            botonFormulario1.ForeColor = Color.White;
            botonFormulario1.Location = new Point(58, 49);
            botonFormulario1.Name = "botonFormulario1";
            botonFormulario1.Size = new Size(146, 41);
            botonFormulario1.TabIndex = 0;
            botonFormulario1.Text = "botonFormulario1";
            botonFormulario1.UseVisualStyleBackColor = false;
            // 
            // AgregarCancha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonFormulario1);
            Name = "AgregarCancha";
            Text = "AgregarCancha";
            ResumeLayout(false);
        }

        #endregion

        private BotonFormulario botonFormulario1;
    }
}