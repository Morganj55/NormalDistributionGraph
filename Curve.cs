using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormalDistributionGraph
{
    public partial class Curve : UserControl, ICurve
    {
        public Curve()
        {
            InitializeComponent(); 
        }

       public Rectangle rectangleArea { get; set; }
       public PointF startingPoint { get; set; }
       public PointF[] graphXYArray { get; set; }
       public PointF[] graphSDLines { get; set; }

          protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Fill the background of the working area of the control in solid black
            Brush graphBackgroundBrush = new SolidBrush(Color.White);
            Rectangle rectGraph = new Rectangle(ClientRectangle.Left + Margin.Left + Padding.Left,
                ClientRectangle.Top + Margin.Top + Padding.Top,
                ClientRectangle.Width - (Margin.Left + Margin.Right) - (Padding.Left + Padding.Right),
                ClientRectangle.Height - (Margin.Top + Margin.Bottom) - (Padding.Top + Padding.Bottom));
            rectangleArea = rectGraph;
            e.Graphics.FillRectangle(graphBackgroundBrush, rectangleArea);
            graphBackgroundBrush.Dispose();
           Point pBottomLeft = new Point(rectangleArea.Left, rectangleArea.Bottom);
            startingPoint = pBottomLeft;

            if (graphXYArray == null && graphSDLines == null)
            {
                return;
            }

            Pen pen = new Pen(Color.Blue, 4);
            Pen penOrange = new Pen(Color.Orange, 4);
            Pen penGreen = new Pen(Color.Green, 4);
            Pen penRed = new Pen(Color.Red, 4);

            // draws curve
            e.Graphics.DrawLines(pen, graphXYArray);  

            //draws sd lines 
            e.Graphics.DrawLine(penOrange, graphSDLines[0], graphSDLines[1]);
            e.Graphics.DrawLine(penGreen, graphSDLines[2], graphSDLines[3]);
            e.Graphics.DrawLine(penGreen, graphSDLines[4], graphSDLines[5]);
            e.Graphics.DrawLine(penRed, graphSDLines[6], graphSDLines[7]);
            e.Graphics.DrawLine(penRed, graphSDLines[8], graphSDLines[9]);
            pen.Dispose();
            penOrange.Dispose();
            penGreen.Dispose();
            penRed.Dispose();

            
            //Brush brush = new SolidBrush(Color.White);
            //e.Graphics.DrawString("This is a custom control", Font, brush, new Point(ClientRectangle.Left + Margin.Left + Padding.Left, ClientRectangle.Top + Margin.Top + Padding.Top));
            //brush.Dispose();
        }
    }
}
