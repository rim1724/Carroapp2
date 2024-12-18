using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Game_Caro.Layout
{
    internal class DoubleBufferedPanel:Panel
    {
          public DoubleBufferedPanel()
            {
                this.DoubleBuffered = true; // Bật double buffering
                this.ResizeRedraw = true; // Vẽ lại khi kích thước thay đổi
            }

            protected override void OnPaintBackground(PaintEventArgs e)
            {
                // Không vẽ lại nền để giảm nhấp nháy
            }
        
    }
}
