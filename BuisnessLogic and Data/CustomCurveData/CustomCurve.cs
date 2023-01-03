using Algorithms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic_and_Data
{
    public class CustomCurve
    {
        public List<float> XValues = new List<float>();
        public List<float> YValues = new List<float>();
        public List<float> GraphXValues = new List<float>();
        public List<float> GraphYValues = new List<float>();
        public PointF[] GraphXYArray = new PointF[200];
        public PointF[] GraphSDLines = new PointF[10];
        public Rectangle rectangle { get; set; }
        public PointF startingPoint { get; set; }
   

        public CustomCurve()
        {
           
        }

        
        //Drawing the curve: Parent method
        public void GenerateGraphPoints(float _mean, float _stdDev)
        {
            float mean = _mean;
            float stdDev = _stdDev;
            CreateXCoordinates(mean, stdDev);
            CreateYCoordinates(mean, stdDev);
            CreateGraphXCoordinates(rectangle, startingPoint);
            CreateGraphYCoordinates(rectangle, startingPoint);
            GraphAddXandYToPointArray();
        }

        //Child Methods 
        public void CreateXCoordinates(float mean, float stdDev)
        {
            float firstXCoordinate = mean - (3.00f * stdDev);
            XValues.Add(firstXCoordinate);
            float currentValue = firstXCoordinate;
            float increment = (6.00f * stdDev) / 199; // 6 is used because that covers the full range of -3 SD to +3SD, 199 is used because I want 200 x coordinates and I have already added one into the list
            for (int i = 0; i < 199; i++)
            {
                float nextXValue = currentValue + increment;
                XValues.Add(nextXValue);
                currentValue = nextXValue;
            }
        }
        public void CreateYCoordinates(float mean, float stdDev)
        {
            for (int i = 0; i < XValues.Count; i++)
            {
                float y = Algorithm.Gaussian(mean, stdDev, XValues[i]);
                YValues.Add(y);
            }
        }
        public void CreateGraphXCoordinates(Rectangle rectangle, PointF startingPoint)
        {
            GraphXValues.Add(startingPoint.X);
            float percentageOfWidth = 0.005f; // if full width = 100% or 1, then 1 / 200 points equals 0.005 which is the percent increment of the total width for 200 points
            for (int i = 0; i < 199; i++)
            {
                float nextXValue = rectangle.Width * percentageOfWidth;
                GraphXValues.Add(nextXValue);
                percentageOfWidth += 0.005f;
            }

        }
        public void CreateGraphYCoordinates(Rectangle rectangle, PointF startingPoint)
        {
            GraphYValues.Add(startingPoint.Y);
            float maxValue = YValues.Max();
            for (int i = 0; i < XValues.Count-1; i++)
            {
                float currentValue = startingPoint.Y;
                float nextYValue = currentValue - ((YValues[i]/maxValue) * rectangle.Height); 
                GraphYValues.Add(nextYValue);
            }
        }
        public void GraphAddXandYToPointArray()
        {
            for (int i = 0; i < XValues.Count ; i++)
            {
                GraphXYArray[i] = new PointF(GraphXValues[i], GraphYValues[i]);
            }
        }
        public void Reset()
        {
            XValues = new List<float>();
            YValues = new List<float>();
            GraphXValues = new List<float>();
            GraphYValues = new List<float>();
            GraphXYArray = new PointF[200];
            GraphSDLines = new PointF[10];
        }


        //Custom Control Methods : Drawing the SD Lines 
        public void CreateSDLinePoints()
        {
            int meanIndex = GraphXValues.Count / 2;
            PointF meanTop = new PointF(GraphXValues[meanIndex], GraphYValues[meanIndex]);
            PointF meanBottom = new PointF(GraphXValues[meanIndex], startingPoint.Y);
            int negativeSD1TopIndex = 66;
            int negativeSD2TopIndex = 33;
            int positiveSD1TopIndex = 133;
            int positiveSD2TopIndex = 166;
            // Indexs of the 1st and 2nd SD, both positive and negative, based on the total number of x values which is 200.

            PointF negativeSD1Top = new PointF((GraphXValues[negativeSD1TopIndex]), GraphYValues[negativeSD1TopIndex]);
            PointF negativeSD1Bottom = new PointF((GraphXValues[negativeSD1TopIndex]), startingPoint.Y);

            PointF positiveSD1Top = new PointF((GraphXValues[positiveSD1TopIndex]), GraphYValues[positiveSD1TopIndex]);
            PointF positiveSD1Bottom = new PointF((GraphXValues[positiveSD1TopIndex]), startingPoint.Y);

            PointF negativeSD2Top = new PointF((GraphXValues[negativeSD2TopIndex]), GraphYValues[negativeSD2TopIndex]);
            PointF negativeSD2Bottom = new PointF((GraphXValues[negativeSD2TopIndex]), startingPoint.Y);

            PointF positiveSD2Top = new PointF((GraphXValues[positiveSD2TopIndex]), GraphYValues[positiveSD2TopIndex]);
            PointF positiveSD2Bottom = new PointF((GraphXValues[positiveSD2TopIndex]), startingPoint.Y);

            GraphSDLines[0] = meanTop;
            GraphSDLines[1] = meanBottom;
            GraphSDLines[2] = negativeSD1Top;
            GraphSDLines[3] = negativeSD1Bottom;
            GraphSDLines[4] = positiveSD1Top;
            GraphSDLines[5] = positiveSD1Bottom;
            GraphSDLines[6] = negativeSD2Top;
            GraphSDLines[7] = negativeSD2Bottom;
            GraphSDLines[8] = positiveSD2Top;
            GraphSDLines[9] = positiveSD2Bottom;

        }


    }
}
