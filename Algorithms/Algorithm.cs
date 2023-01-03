using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Algorithm
    {
        public static float CalculateDefiniteIntegralWithInputNum(float inputNum, float mean, float stdDev)
        {
            float zScore = (inputNum - mean) / (stdDev);
            float top = ((float)SpecialFunctions.Erf((zScore / (float)Math.Sqrt(2f))));
            return 0.5f * top;
        }
        public static float CalculateDefiniteIntegralWithoutInputNum(float boundry)
        {
            float top = ((float)SpecialFunctions.Erf((boundry / (float)Math.Sqrt(2f))));
            return 0.5f * top;
        }
        public static string CalculateProbabilityPercentage_XLessThanA(string A1, float mean, float stdDev)
        {
            if (A1 == "" || A1 == null) {  return null; }
            float A1Float = float.Parse(A1);
            float upper = CalculateDefiniteIntegralWithInputNum(A1Float, mean, stdDev);
            float lower = CalculateDefiniteIntegralWithoutInputNum(-100f);
            float result = (upper - lower) * 100f;
            return result.ToString();
        }
        public static string CalculateProbabilityPercentage_ALessThanXLessThanB(string A2, string B2, float mean, float stdDev)
        {
            if (A2 == "" || B2 == "" || A2 == null || B2 == null) { return null; }
            float A2Float = float.Parse(A2);
            float B2Float = float.Parse(B2);
            float upper = CalculateDefiniteIntegralWithInputNum(B2Float, mean, stdDev);
            float lower = CalculateDefiniteIntegralWithInputNum(A2Float, mean, stdDev);
            float result = (upper - lower) * 100f;
            return result.ToString();
        }
        public static string CalculateProbabilityPercentage_XGreaterThanB(string B1, float mean, float stdDev)
        {
            if (B1 == "" || B1 == null) { return null; }
            float B1Float = float.Parse(B1);
            float upper = CalculateDefiniteIntegralWithoutInputNum(100f);
            float lower = CalculateDefiniteIntegralWithInputNum(B1Float, mean, stdDev);
            float result = (upper - lower) * 100f;
            return result.ToString();
        }

        public static float Gaussian(float mean, float stdDev, float xValue)
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
        }
    }
}
