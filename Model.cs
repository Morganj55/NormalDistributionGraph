using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms;
using MathNet.Numerics;

namespace NormalDistributionGraph
{
    public class Model : IModel
    {
        //View properties
        public bool meanValidated { get; set; }
        public bool stdDevValidated { get; set; }
        public bool enableProbPanelDistBtn { get; set; }
        public float mean { get; set; }
        public float stdDev { get; set; }
        public string A1 { get; set; }
        public string A2 { get; set; }
        public string B1 { get; set; }
        public string B2 { get; set; }
      
        //Probability Properties 
        public string A1Probability { get; set; } 
        public string A2B2Probability { get; set; }
        public string B1Probability {get; set;}

        //Observer Properties
        public List<IObserver<ModelUpdate>> _observers; 

        //Constructor
        public Model()
        {
            _observers = new List<IObserver<ModelUpdate>>();
            
        }

        //IObserverable methods 
        public void SendMessage(ModelUpdate update)
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(update);
            }
        }
        public IDisposable Subscribe(IObserver<ModelUpdate> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            return new ObserverableUnsubscriber<ModelUpdate>(_observers, observer);
        }

        //Methods called by presenters 
        public void UpdateProbabiltyPanelAndDistributionButton()
        {
            if (meanValidated == true && stdDevValidated == true)
            {
                enableProbPanelDistBtn = true;
                SendMessage(new ModelUpdate(enableProbPanelDistBtn));
            }
            else
            {
                enableProbPanelDistBtn = false;
                SendMessage(new ModelUpdate(enableProbPanelDistBtn));
            }
        }
        public PointF[] GenerateCurve()
        {
            CreateXCoordinates();
            CreateYCoordinates();
            CreateGraphXCoordinates(rectangle, startingPoint);
            CreateGraphYCoordinates(rectangle, startingPoint);
            GraphAddXandYToPointArray();
            return GraphXYArray;
        }
        public PointF[] GenerateSDLines()
        {
            CreateSDLinePoints();
            return GraphSDLines;
        }
        public void UpdateProbabilities()
        {
           A1Probability = Algorithm.CalculateProbabilityPercentage_XLessThanA(A1, mean, stdDev);
           A2B2Probability = Algorithm.CalculateProbabilityPercentage_ALessThanXLessThanB(A2, B2, mean, stdDev);
           B1Probability = Algorithm.CalculateProbabilityPercentage_XGreaterThanB(B1, mean, stdDev);
            SendMessage(new ModelUpdate(enableProbPanelDistBtn, A1Probability, A2B2Probability, B1Probability));
        }

        //Custom control------------------------------------------------
        //Custom control properties 
        public List<float> XValues = new List<float>();
        public List<float> YValues = new List<float>();
        public List<float> GraphXValues = new List<float>();
        public List<float> GraphYValues = new List<float>();
        public PointF[] GraphXYArray = new PointF[200];
        public PointF[] GraphSDLines = new PointF[10];
        public Rectangle rectangle { get; set; }
        public PointF startingPoint { get; set; }


        //Custom Control Methods : Drawing the Curve 
        public void CreateXCoordinates()
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
        public float GaussianAlgorithm(float mean, float stdDev, float xValue)
        {
            //Overall equation 
            // (1/a) * e^(b/c)
            // a = SQRT(2*Pi*stdDev^2)
            // b = -1 * (x - mean)^2
            // c = 2 * stdDev^2

            float a = ((float)Math.Sqrt(2 * (float)Math.PI * (float)Math.Pow(stdDev, 2)));
            float b = -1f * ((float)Math.Pow(xValue - mean, 2f));
            float c = (2 * ((float)Math.Pow(stdDev, 2f)));
            float y = (1 / a) * ((float)Math.Pow((float)Math.E, b / c));
            return y;

            //Old implementation of algorithm
            //float x;
            //x =
            //    (
            //    (1f / (float)Math.Sqrt(2 * (float)Math.PI * (float)Math.Pow(stdDev, 2)))
            //    *
            //    ((float)Math.Pow((float)Math.E,
            //    (-1f * ((float)Math.Pow(xValue - mean, 2f)) / (2 * ((float)Math.Pow(stdDev, 2f)))))
            //    )
            //    );
            //return x;


        }
        public void CreateYCoordinates()
        {
            for (int i = 0; i < XValues.Count; i++)
            {
                float y = GaussianAlgorithm(mean, stdDev, XValues[i]);
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

            for (int i = 0; i < XValues.Count - 1; i++)
            {
                float currentValue = startingPoint.Y;
                float nextYValue = currentValue - (YValues[i] * (rectangle.Height * 2.25f)); // 2.25f is used so that the curve takes up more space, could use any number
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



        //Probability calculations --------------------------
        
        public float CalculateDefiniteIntegralWithInputNum(float inputNum, float mean, float stdDev)
        {
            float zScore = (inputNum - mean) / (stdDev);
            float top = ((float)SpecialFunctions.Erf((zScore/ (float)Math.Sqrt(2f))));
            return 0.5f * top;
        }
        public float CalculateDefiniteIntegralWithoutInputNum(float boundry)
        {
            float top = ((float)SpecialFunctions.Erf((boundry / (float)Math.Sqrt(2f))));
            return 0.5f * top;
        }
        public void CalculateProbabilityPercentage_XLessThanA()
        {
            if (A1 == "" || A1 == null) { A1Probability = null; return; }
            float A1Float = float.Parse(A1);
            float upper = CalculateDefiniteIntegralWithInputNum(A1Float, mean, stdDev);
            float lower = CalculateDefiniteIntegralWithoutInputNum(-100f);
            float result = (upper - lower) * 100f;
            A1Probability = result.ToString();
        }
        public void CalculateProbabilityPercentage_ALessThanXLessThanB()
        {
            if (A2 == "" || B2 == "" || A2 == null || B2 == null) { A2B2Probability = null; return; }
            float A2Float = float.Parse(A2);
            float B2Float = float.Parse(B2);
            float upper = CalculateDefiniteIntegralWithInputNum(B2Float, mean, stdDev);
            float lower = CalculateDefiniteIntegralWithInputNum(A2Float, mean, stdDev);
            float result = (upper - lower) * 100f;
            A2B2Probability = result.ToString();
        }
        public void CalculateProbabilityPercentage_XGreaterThanB()
        {
            if (B1 == "" || B1 == null) { B1Probability = null; return; }
            float B1Float = float.Parse(B1);
            float upper = CalculateDefiniteIntegralWithoutInputNum(100f);
            float lower = CalculateDefiniteIntegralWithInputNum(B1Float, mean, stdDev);
            float result = (upper - lower) * 100f;
            B1Probability = result.ToString();
        }
    }
}
