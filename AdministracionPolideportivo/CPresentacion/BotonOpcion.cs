using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionPolideportivo.CPresentacion
{
    internal class BotonOpcion : Button
    {

        public BotonOpcion() {

            BackColor = Color.FromArgb(64, 64, 64);
            Dock = DockStyle.Fill;
            FlatAppearance.BorderColor = Color.Red;
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Segoe UI", 12F);
            ForeColor = SystemColors.ButtonHighlight;
            Location = new Point(3, 3);
            Name = "button1";
            Size = new Size(191, 44);
            TabIndex = 0;
            Text = "Agregar Cancha";
            UseVisualStyleBackColor = false;

        }

    }
}
