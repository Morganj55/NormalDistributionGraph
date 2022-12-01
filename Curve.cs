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
    public partial class Curve : UserControl
    {
        public Curve()
        {
            InitializeComponent();
            mean = 100.000f;
            standardDeviation = 1.000f;
            FirstXCoordinate(mean,standardDeviation);
            ConsecutiveXCoordinates();
            CreateYCoordinates();
            AddXandYToPointArray();
            
        }

        
        List<float> XValues = new List<float>();
        List<float> YValues = new List<float>();
        PointF[] XYPointArray = new PointF[200];



        
        List<float> GraphXValues = new List<float>();
        List<float> GraphYValues = new List<float>();
        PointF[] GraphXYArray = new PointF[200];

        float standardDeviation;
        float mean;
        float firstXCoordinate;



        public void FirstXCoordinate(float mean, float stdDev)
        {
            firstXCoordinate = mean - (3.00f * standardDeviation);
        }

        public void ConsecutiveXCoordinates()
        {
            XValues.Add(firstXCoordinate);
            float currentValue = firstXCoordinate;
            float previousValue;
            float increment = (6.00f * standardDeviation) / 199; // 6 is used because that covers the full range of -3 SD to +3SD, 199 is used because I want 200 x coordinates and I have already added one into the list
            for (int i = 0; i < 199; i++)
            {
                float nextXValue = currentValue + increment;     
                XValues.Add(nextXValue);
                previousValue = currentValue;
                currentValue = nextXValue;
            }
        }

        public void CreateYCoordinates()
        {
            for (int i = 0; i < XValues.Count; i++)
            {
                float y = GaussianAlgorithm(mean, standardDeviation, XValues[i]);
                YValues.Add(y);
                
            }
        }

        public float GaussianAlgorithm(float mean, float stdDev, float xValue)
        {
            float x;
            x =
                (
                (1f / (float)Math.Sqrt(2 * (float)Math.PI * (float)Math.Pow(stdDev, 2)))
                *
                ((float)Math.Pow((float)Math.E,
                (-1f * ((float)Math.Pow(xValue - mean, 2f)) / (2 * ((float)Math.Pow(stdDev, 2f)))))
                )
                );
              
            return x;
        }

        public void AddXandYToPointArray()
        {
            for (int i = 0; i < XValues.Count; i++)
            {
                XYPointArray[i] = new PointF(XValues[i], YValues[i]);
            }
        }

        public void CreateGraphXCoordinates(Rectangle rectangle, Point startingPoint)
        {
            GraphXValues.Add(startingPoint.X);
            float currentValue = startingPoint.X;
            float previousValue;
            float increment = (rectangle.Width / XValues.Count); // 6 is used because that covers the full range of -3 SD to +3SD, 199 is used because I want 200 x coordinates and I have already added one into the list
            for (int i = 0; i < 199; i++)
            {
                float nextXValue = currentValue + increment;
                GraphXValues.Add(nextXValue);
                previousValue = currentValue;
                currentValue = nextXValue;
            }

        }

        public void CreateGraphYCoordinates(Rectangle rectangle, Point startingPoint)
        {
            GraphYValues.Add(startingPoint.Y);
            
            for (int i = 0; i < XValues.Count - 1; i++)
            {
                float currentValue = startingPoint.Y;
                float nextYValue = currentValue - (YValues[i] * (rectangle.Height * 2.25f));
                GraphYValues.Add(nextYValue);

            }
        }

        public void GraphAddXandYToPointArray()
        {
            for (int i = 0; i < XValues.Count; i++)
            {
                GraphXYArray[i] = new PointF(GraphXValues[i], GraphYValues[i]);
            }
        }




        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Fill the background of the working area of the control in solid black
            Brush graphBackgroundBrush = new SolidBrush(Color.White);
            Rectangle rectGraph = new Rectangle(ClientRectangle.Left + Margin.Left + Padding.Left,
                ClientRectangle.Top + Margin.Top + Padding.Top,
                ClientRectangle.Width - (Margin.Left + Margin.Right) - (Padding.Left + Padding.Right),
                ClientRectangle.Height - (Margin.Top + Margin.Bottom) - (Padding.Top + Padding.Bottom));

            e.Graphics.FillRectangle(graphBackgroundBrush, ClientRectangle);
            // Used ClientRectangle which fills whole Panel, can also use rectGraph that John provided, may need to use johns for the resising purpose.

            graphBackgroundBrush.Dispose();

            Point pTopLeft = new Point(rectGraph.Left, rectGraph.Top);
            Point pTopRight = new Point(rectGraph.Right, rectGraph.Top);
            Point pBottomLeft = new Point(rectGraph.Left, rectGraph.Bottom);
            Point pBottomRight = new Point(rectGraph.Right, rectGraph.Bottom);

            CreateGraphXCoordinates(rectGraph, pBottomLeft);
            CreateGraphYCoordinates(rectGraph, pBottomLeft);
            GraphAddXandYToPointArray();


            Pen pen = new Pen(Color.Blue, 4);
            
            e.Graphics.DrawLines(pen, GraphXYArray);
            //for (int i = 0; i < XValues.Count; i++)
            //    {
            //    e.Graphics.DrawLine(pen,XValues[i],YValues[i],XValues[i+1] );

            //    }
            pen.Dispose();
            //Brush brush = new SolidBrush(Color.White);
            //e.Graphics.DrawString("This is a custom control", Font, brush, new Point(ClientRectangle.Left + Margin.Left + Padding.Left, ClientRectangle.Top + Margin.Top + Padding.Top));
            //brush.Dispose();
        }
    }
}
