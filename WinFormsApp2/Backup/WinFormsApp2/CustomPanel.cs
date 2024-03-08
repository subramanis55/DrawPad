﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinFormsApp2
{
    public class CustomPanel : Panel
    {
        private int borderRadius = 1;
        private Color borderColor = Color.Black;
        private int borderMarginSize = 0;
        private int topLeftRadius = 1;
        private int bottomLeftRadius = 1;
        private int topRightRadius = 1;
        private int bottomRight = 1;
        public int AllBorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                borderRadius = value;
                topLeftRadius = bottomLeftRadius = topRightRadius = bottomRight = value;
                Invalidate();
            }
        }
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        public int BorderMarginSize
        {
            get
            {
                return borderMarginSize;
            }

            set
            {
                borderMarginSize = value;
                Invalidate();
            }
        }
        public int TopLeftRadius
        {
            get
            {
                return topLeftRadius;
            }

            set
            {
                topLeftRadius = value;
            }
        }
        public int BottomLeftRadius
        {
            get
            {
                return bottomLeftRadius;
            }

            set
            {
                bottomLeftRadius = value;
            }
        }

        public int TopRightRadius
        {
            get
            {
                return topRightRadius;
            }

            set
            {
                topRightRadius = value;
            }
        }

        public int BottomRight
        {
            get
            {
                return bottomRight;
            }

            set
            {
                bottomRight = value;
            }
        }
     
        public CustomPanel() : base()
        {

            DoubleBuffered = true;
         
        }

      
        public GraphicsPath GetPath(Rectangle rec)
        {
            GraphicsPath g = new GraphicsPath();
            g.StartFigure();
            g.AddArc(rec.X, rec.Y, topLeftRadius, topLeftRadius, 180, 90);
            g.AddArc(rec.Width - borderRadius - borderMarginSize, rec.Y, topRightRadius, topRightRadius, 270, 90);
            g.AddArc(rec.Width - borderRadius - borderMarginSize, rec.Height - borderRadius - borderMarginSize, bottomRight, bottomRight, 0, 90);
            g.AddArc(rec.X, rec.Height - borderRadius - borderMarginSize, bottomLeftRadius, bottomLeftRadius, 90, 90);
            g.CloseFigure();
            return g;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            DoubleBuffered = true;
            base.OnPaint(e);
            GraphicsPath path = GetPath(ClientRectangle);
            this.Region = new Region(path);
            var eg = e.Graphics;
            eg.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen Drawpen = new Pen(borderColor, BorderMarginSize))
            {
                eg.DrawPath(Drawpen, path);
            }
        }
       
    }
}