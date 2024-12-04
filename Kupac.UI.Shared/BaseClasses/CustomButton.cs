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
            // Set default styles
            this.AutoSize = true;
            this.BackColor = Color.Transparent;
            this.BackgroundImageLayout = ImageLayout.Center;
            this.Cursor = Cursors.Hand;
            this.FlatStyle = FlatStyle.Flat;

            // Configure FlatStyle properties
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 190, 152);
            this.FlatAppearance.MouseOverBackColor = Color.AntiqueWhite;

            // Default text color (if text is present)
            this.ForeColor = Color.Transparent;
        }
    }
}
