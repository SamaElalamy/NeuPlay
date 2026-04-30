using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NeuPlay
{
    public class RoundedButton : Button
    {
        //Making rounded Buttons without the need to use a styling library
        public int BorderRadius { get; set; } = 20;

        public RoundedButton()
        {
            
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.MediumSlateBlue; 
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (BorderRadius > this.Height)
                BorderRadius = this.Height;
        }

        
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -1, -1);
            int smoothSize = 2;
            if (BorderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, BorderRadius - 1))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(this.FlatAppearance.BorderColor, 1))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias; 

                    
                    this.Region = new Region(pathSurface);

                    
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    
                    if (this.FlatAppearance.BorderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                this.Region = new Region(rectSurface);
                if (this.FlatAppearance.BorderSize >= 1)
                {
                    using (Pen penBorder = new Pen(this.FlatAppearance.BorderColor, this.FlatAppearance.BorderSize))
                    {
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90); 
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90); 
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90); 
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}