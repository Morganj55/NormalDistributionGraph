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

        
        //List<float> XValues = new List<float>();
        //List<float> YValues = new List<float>();
        //List<float> GraphXValues = new List<float>();
        //List<float> GraphYValues = new List<float>();
        //PointF[] GraphXYArray = new PointF[200];

       public Rectangle rectangleArea { get; set; }
       public PointF startingPoint { get; set; }
        public PointF[] graphXYArray { get; set; }
        public PointF[] graphSDLines { get; set; }


        //float standardDeviation= 1.000f;
        //float mean = 20.000f;


        //public void CreateXCoordinates(float mean, float stdDev)
        //{

        //    float firstXCoordinate = mean - (3.00f * stdDev);
        //    XValues.Add(firstXCoordinate);
        //    float currentValue = firstXCoordinate;
        //    float increment = (6.00f * standardDeviation) / 199; // 6 is used because that covers the full range of -3 SD to +3SD, 199 is used because I want 200 x coordinates and I have already added one into the list
        //    for (int i = 0; i < 199; i++)
        //    {
        //        float nextXValue = currentValue + increment;     
        //        XValues.Add(nextXValue);
        //        currentValue = nextXValue;
        //    }
        //}

        //public void CreateYCoordinates()
        //{
        //    for (int i = 0; i < XValues.Count; i++)
        //    {
        //        float y = GaussianAlgorithm(mean, standardDeviation, XValues[i]);
        //        YValues.Add(y);
        //    }
        //}

        //public float GaussianAlgorithm(float mean, float stdDev, float xValue)
        //{
        //    //Overall equation 
        //    // (1/a) * e^(b/c)
        //    // a = SQRT(2*Pi*stdDev^2)
        //    // b = -1 * (x - mean)^2
        //    // c = 2 * stdDev^2

        //    float a = ((float)Math.Sqrt(2 * (float)Math.PI * (float)Math.Pow(stdDev, 2)));
        //    float b = -1f * ((float)Math.Pow(xValue - mean, 2f));
        //    float c = (2 * ((float)Math.Pow(stdDev, 2f)));
        //    float y = (1 / a) * ((float)Math.Pow((float)Math.E, b / c));
        //    return y;

        //    //Old implementation of algorithm
        //    //float x;
        //    //x =
        //    //    (
        //    //    (1f / (float)Math.Sqrt(2 * (float)Math.PI * (float)Math.Pow(stdDev, 2)))
        //    //    *
        //    //    ((float)Math.Pow((float)Math.E,
        //    //    (-1f * ((float)Math.Pow(xValue - mean, 2f)) / (2 * ((float)Math.Pow(stdDev, 2f)))))
        //    //    )
        //    //    );
        //    //return x;


        //}

        //public void CreateGraphXCoordinates(Rectangle rectangle, Point startingPoint)
        //{
        //    GraphXValues.Add(startingPoint.X);
        //    float currentValue = startingPoint.X;
        //    float increment = (rectangle.Width / XValues.Count); // 6 is used because that covers the full range of -3 SD to +3SD, 199 is used because I want 200 x coordinates and I have already added one into the list
        //    for (int i = 0; i < 199; i++)
        //    {
        //        float nextXValue = currentValue + increment;
        //        GraphXValues.Add(nextXValue);
        //        currentValue = nextXValue;
        //    }

        //}

        //public void CreateGraphYCoordinates(Rectangle rectangle, Point startingPoint)
        //{
        //    GraphYValues.Add(startingPoint.Y);

        //    for (int i = 0; i < XValues.Count - 1; i++)
        //    {
        //        float currentValue = startingPoint.Y;
        //        float nextYValue = currentValue - (YValues[i] * (rectangle.Height * 2.25f)); // 2.25f is used so that the curve takes up more space, could use any number
        //        GraphYValues.Add(nextYValue);
        //    }
        //}

        //public void GraphAddXandYToPointArray()
        //{
        //    for (int i = 0; i < XValues.Count; i++)
        //    {
        //        GraphXYArray[i] = new PointF(GraphXValues[i], GraphYValues[i]);
        //    }
        //}

        //public void Reset()
        //{
        //    XValues = new List<float>();
        //    YValues = new List<float>();
        //    GraphXValues = new List<float>();
        //    GraphYValues = new List<float>();
        //    GraphXYArray = new PointF[200];
        //}


          protected override void OnPaint(PaintEventArgs e)
        {
            if (graphXYArray == null && graphSDLines == null)
            {
                return; 
            }
            base.OnPaint(e);
            // Fill the background of the working area of the control in solid black
            Brush graphBackgroundBrush = new SolidBrush(Color.White);
            Rectangle rectGraph = new Rectangle(ClientRectangle.Left + Margin.Left + Padding.Left,
                ClientRectangle.Top + Margin.Top + Padding.Top,
                ClientRectangle.Width - (Margin.Left + Margin.Right) - (Padding.Left + Padding.Right),
                ClientRectangle.Height - (Margin.Top + Margin.Bottom) - (Padding.Top + Padding.Bottom));
            rectangleArea = rectGraph;
            e.Graphics.FillRectangle(graphBackgroundBrush, rectGraph);
            graphBackgroundBrush.Dispose();
            
            Point pBottomLeft = new Point(rectGraph.Left, rectGraph.Bottom);
            startingPoint = pBottomLeft;
            //CreateXCoordinates(mean, standardDeviation);
            //CreateYCoordinates();
            //CreateGraphXCoordinates(rectGraph, pBottomLeft);
            //CreateGraphYCoordinates(rectGraph, pBottomLeft);
            //GraphAddXandYToPointArray();

            //Coloured Standard deviation Lines 
            //

            //int meanIndex = GraphXValues.Count / 2;
            //PointF meanTop = new PointF(GraphXValues[meanIndex], GraphYValues[meanIndex]);
            //PointF meanBottom = new PointF(GraphXValues[meanIndex], pBottomLeft.Y);


            //int negativeSD1TopIndex = 66;
            //int negativeSD2TopIndex = 33;
            //int positiveSD1TopIndex = 133;
            //int positiveSD2TopIndex = 166;
            // Indexs of the 1st and 2nd SD, both positive and negative, based on the total number of x values which is 200.

            //PointF negativeSD1Top = new PointF((GraphXValues[negativeSD1TopIndex]), GraphYValues[negativeSD1TopIndex]);
            //PointF negativeSD1Bottom = new PointF((GraphXValues[negativeSD1TopIndex]), pBottomLeft.Y);

            //PointF positiveSD1Top = new PointF((GraphXValues[positiveSD1TopIndex]), GraphYValues[positiveSD1TopIndex]);
            //PointF positiveSD1Bottom = new PointF((GraphXValues[positiveSD1TopIndex]), pBottomLeft.Y);

            //PointF negativeSD2Top = new PointF((GraphXValues[negativeSD2TopIndex]), GraphYValues[negativeSD2TopIndex]);
            //PointF negativeSD2Bottom = new PointF((GraphXValues[negativeSD2TopIndex]), pBottomLeft.Y);

            //PointF positiveSD2Top = new PointF((GraphXValues[positiveSD2TopIndex]), GraphYValues[positiveSD2TopIndex]);
            //PointF positiveSD2Bottom = new PointF((GraphXValues[positiveSD2TopIndex]), pBottomLeft.Y);

            Pen pen = new Pen(Color.Blue, 4);
            Pen penOrange = new Pen(Color.Orange, 4);
            Pen penGreen = new Pen(Color.Green, 4);
            Pen penRed = new Pen(Color.Red, 4);


            e.Graphics.DrawLines(pen, graphXYArray); // draws curve 

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

            //Reset();
            //Brush brush = new SolidBrush(Color.White);
            //e.Graphics.DrawString("This is a custom control", Font, brush, new Point(ClientRectangle.Left + Margin.Left + Padding.Left, ClientRectangle.Top + Margin.Top + Padding.Top));
            //brush.Dispose();
        }
    }
}
