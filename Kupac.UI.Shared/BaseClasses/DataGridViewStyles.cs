﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kupac.UI.Shared.BaseClasses
{
    public class DataGridViewStyles
    {
        public static DataGridViewCellStyle DefaultRowStyle()
        {
            return new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.Black,
                SelectionBackColor = Color.FromArgb(254, 190, 152),
                SelectionForeColor = Color.White,
            };
        }

        public static DataGridViewCellStyle AlternatingRowStyle()
        {
            return new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(240, 240, 240),
                ForeColor = Color.Black
            };
        }

        public static DataGridViewCellStyle HeaderStyle()
        {
            return new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(82, 42, 40),
                ForeColor = Color.White,
                Font = new Font("Arial", 12F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
        }

    }
}
