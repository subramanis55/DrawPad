using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class ColorPanel : Panel
    {
        private Color[] colorArray;
        public ColorPanel(){

            colorArray = new Color[] { Color.Black, Color.Red, Color.Green, Color.Yellow, Color.Brown, Color.Violet, Color.DarkBlue, Color.DodgerBlue, Color.DimGray, Color.DeepPink, Color.LightGreen, Color.Gold, Color.Fuchsia, Color.Lavender, Color.Aqua, Color.White };
            Resize += ColorPanelResize;
        }

        private void ColorPanelResize(object? sender, EventArgs e)
        {
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int height = (Height -6)/ 2;
            int width = ((Width-8) /8);
            int x=1,y = 2; 
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            for (int i = 0; i < colorArray.Length; i++)
            {

                using (SolidBrush P = new SolidBrush(colorArray[i]))
                {
                    
                    g.FillEllipse(P, x, y, width, height);
                }
                x+= width + 1;
                if (i == 7)
                {
                    y += height + 2;
                    x = 1;
                }
                    
            }
        }

    }
}
