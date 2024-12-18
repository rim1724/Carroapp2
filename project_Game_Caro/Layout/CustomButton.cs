using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Game_Caro.Layout
{
    internal class CustomButton : Button
    {
        
        public CustomButton()
        {
            SetStyle(ControlStyles.Opaque | ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.FromArgb(80,192,255,255);
            FlatAppearance.MouseDownBackColor = BackColor;
            FlatAppearance.MouseOverBackColor = BackColor;

        }
        

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Không vẽ nền để tạo hiệu ứng trong suốt
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            
            TextRenderer.DrawText(pevent.Graphics, Text, Font, ClientRectangle, ForeColor);
            
        }


    }
}
