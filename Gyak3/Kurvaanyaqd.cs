using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak3
{
    internal class Kurvaanyaqd : Button
    {

            public Kurvaanyaqd()
            {
                MouseEnter += OnMouseEnter;
                MouseLeave += OnMouseLeave;

            }

            private void OnMouseLeave(object? sender, EventArgs e)
            {
                BackColor = SystemColors.ButtonFace;
            }

            private void OnMouseEnter(object? sender, EventArgs e)
            {
                BackColor = Color.Fuchsia;
            }
        }
}
