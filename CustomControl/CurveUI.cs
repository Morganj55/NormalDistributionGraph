using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CustomControl
{
    public partial class CurveUI : UserControl
    {
        public CurveUI()
        {
            InitializeComponent();
        }

        public Rectangle rectangleArea { get; set; }
        public PointF startingPoint { get; set; }
        public PointF[] graphXYArray { get; set; }
        public PointF[] graphSDLines { get; set; }
        public List<float> xValues { get; set; }
        public string mean { get; set; }
        public float stdDev { get; set; }

        public void PaintRectangle(PaintEventArgs e)
        {
            // Fill the background of the working area of the control in solid black
            Brush graphBackgroundBrush = new SolidBrush(Color.White);
            Rectangle rectGraph = new Rectangle
                (
                ClientRectangle.Left + Margin.Left + Padding.Left,
                ClientRectangle.Top + Margin.Top + Padding.Top,
                ClientRectangle.Width - (Margin.Left + Margin.Right) - (Padding.Left + Padding.Right),
                ClientRectangle.Height - (Margin.Top + Margin.Bottom) - (Padding.Top + Padding.Bottom)
                );

            rectangleArea = rectGraph;

            e.Graphics.FillRectangle(graphBackgroundBrush, rectangleArea);
            graphBackgroundBrush.Dispose();
            Point pBottomLeft = new Point(rectangleArea.Left, rectangleArea.Bottom);
            startingPoint = pBottomLeft;
            graphBackgroundBrush.Dispose();
        }
        public void DrawCurve(PaintEventArgs e)
        {
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
        }
        public void DrawNumber(PaintEventArgs e, string value, int index)
        {
            int xSpacing = 8;
            int ySpacing = 10;
            float YCoordinate = graphSDLines[6].Y + ySpacing + 16;
            Brush brush = new SolidBrush(Color.Black);

            e.Graphics.DrawString(
                    value,
                    Font, brush,
                    new PointF(graphSDLines[index].X + xSpacing, YCoordinate));
        }
        public void DrawNumberFormatted(PaintEventArgs e)
        {
            string format = "0.000";
            if (xValues[100].ToString(format) == mean) { DrawNumber(e, xValues[100].ToString("0"), 0); }
            else DrawNumber(e, mean, 0);

            if (xValues[33].ToString(format) == (stdDev * -2f).ToString(format)) { DrawNumber(e, xValues[33].ToString(format), 6); }
            else DrawNumber(e, (float.Parse(mean) + (stdDev * -2f)).ToString(format), 6);

            if (xValues[66].ToString(format) == (stdDev * -1f).ToString(format)) { DrawNumber(e, xValues[66].ToString(format), 2); }
            else DrawNumber(e, (float.Parse(mean) + (stdDev * -1f)).ToString(format), 2);

            if (xValues[133].ToString(format) == (stdDev * 1f).ToString(format)) { DrawNumber(e, xValues[133].ToString(format), 4); }
            else DrawNumber(e, (float.Parse(mean) + (stdDev * 1f)).ToString(format), 4);

            if (xValues[166].ToString(format) == (stdDev * 2f).ToString(format)) { DrawNumber(e, xValues[166].ToString(format), 8); }
            else DrawNumber(e, (float.Parse(mean) + (stdDev * 2f)).ToString(format), 8);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            PaintRectangle(e);
            if (graphXYArray == null && graphSDLines == null) { return; }
            DrawCurve(e);
            DrawNumberFormatted(e);
        }
    }
}
