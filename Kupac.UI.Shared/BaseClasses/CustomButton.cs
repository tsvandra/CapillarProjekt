using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kupac.UI.Shared.BaseClasses
{
    public class CustomButton : Button
    {
        public CustomButton()
        {
            // Alapértelmezett stílusok beállítása
            this.AutoSize = true;
            this.BackColor = Color.Transparent;
            this.BackgroundImageLayout = ImageLayout.Center;
            this.Cursor = Cursors.Hand;
            this.FlatStyle = FlatStyle.Flat;

            // FlatStyle beállítások
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(198, 187, 171);
            this.FlatAppearance.MouseOverBackColor = Color.AntiqueWhite;

            // Szöveg alapértelmezett színe (ha van szöveg)
            this.ForeColor = Color.Transparent;
        }
    }
}
