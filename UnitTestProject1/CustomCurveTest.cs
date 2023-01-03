using BuisnessLogic_and_Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserInterface;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class CustomCurveTest
    {
        [ClassInitialize()]
        public static void ClassInitialise(TestContext tc)
        {
            _model = new Model();
           _customCurve = new CustomCurve();
        }

        static Model _model { get; set; }

        static CustomCurve _customCurve { get; set; }

        [TestMethod]
        [TestCategory("CustomControl")]
        public void DrawingCurve_CreateXCoordinates_Increments()
        {
            //Arrange
            _model.mean = 0f;
            _model.stdDev = 1f;
            
            float expectedResult = -2.969849246f;


            //Act
            _customCurve.CreateXCoordinates(_model.mean, _model.stdDev);
            float result = _customCurve.XValues[1];

            //Assert
            Assert.AreEqual(expectedResult, result);

        }


        [TestMethod]
        [TestCategory("CustomControl")]
        public void DrawingCurve_CreateXCoordinates_FirstValue()
        {
            //Arrange
            _model.mean = 0f;
            _model.stdDev = 1f;
            float expectedResult = -3f;


            //Act
            _customCurve.CreateXCoordinates(_model.mean, _model.stdDev);
            float result = _customCurve.XValues[0];

            //Assert
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        [TestCategory("CustomControl")]
        public void DrawingCurve_CreateYCoordinates_AllValues()
        {
            //Arrange
            _model.mean = 0f;
            _model.stdDev = 1f;
            _customCurve.CreateXCoordinates(_model.mean, _model.stdDev);
            float expectedResult = 0.004431849f;


            //Act
            _customCurve.CreateYCoordinates(_model.mean, _model.stdDev);
            float result = _customCurve.YValues[0];

            //Assert
            Assert.AreEqual(expectedResult, result);

        }
    }
}
