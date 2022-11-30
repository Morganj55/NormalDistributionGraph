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
            mean = 0.000f;
            standardDeviation = 1.000f;
            FirstXCoordinate(mean,standardDeviation);
            ConsecutiveXCoordinates();
            CreateYCoordinates();
        }

        List<Point> GraphPoints;
        List<float> XValues = new List<float>();
        List<float> YValues = new List<float>();
        float standardDeviation;
        float mean;
        float firstXCoordinate;

        //public void SetPoints(List<float>xValues, float[]YValues)
        //{

        //}

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

            Pen pen = new Pen(Color.Blue, 4);
            
            e.Graphics.DrawLine(pen, pBottomLeft, pTopRight);
            pen.Dispose();
            //Brush brush = new SolidBrush(Color.White);
            //e.Graphics.DrawString("This is a custom control", Font, brush, new Point(ClientRectangle.Left + Margin.Left + Padding.Left, ClientRectangle.Top + Margin.Top + Padding.Top));
            //brush.Dispose();
        }
    }
}
