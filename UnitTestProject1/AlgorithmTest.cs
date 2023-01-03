using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UserInterface;
using Algorithms;
using BuisnessLogic_and_Data;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class AlgorithmTest
    {
        [ClassInitialize()]
        public static void ClassInitialise(TestContext tc)
        {
            _model = new Model();
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            // Dispose of all objects that are un-needed 
        }

        static Model _model { get; set; }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
        [TestMethod]
        [TestCategory("ProbabilityCalculations")]
        public void Probability_DefiniteIntegralWithoutNum()
        {
            //Arrange
            float inputNum = -100f;
            float expectedResult = -0.5f;


            //Act
            float result = Algorithm.CalculateDefiniteIntegralWithoutInputNum(inputNum);


            //Assert
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        [TestCategory("ProbabilityCalculations")]
        public void Probability_DefiniteIntegralWithNum()
        {
            //Arrange
            _model.mean = 46f;
            _model.stdDev = 8f;
            float inputNum = 40f;
            float expectedResult = -0.27337265f;


            //Act
            float result = Algorithm.CalculateDefiniteIntegralWithInputNum(inputNum, _model.mean, _model.stdDev);


            //Assert
            Assert.AreEqual(expectedResult, result);

        }



        [TestMethod]
        [TestCategory("ProbabilityCalculations")]
        public void Model_XLessThanA_Calculation()
        {
            //assert

            _model.A1 = "40";
            _model.mean = 46f;
            _model.stdDev = 8f;
            string expextedResult = (0.226627352f * 100f).ToString();

            //act
            string result = Algorithm.CalculateProbabilityPercentage_XLessThanA(_model.A1, _model.mean, _model.stdDev);


            //arrange
            Assert.AreEqual(expextedResult, result);
        }

        [TestMethod]
        [TestCategory("ProbabilityCalculations")]
        public void Model_ALessThanXLessThanB_CalculationCalculation()
        {
            //assert
            _model.A2 = "-1";
            _model.B2 = "1";
            _model.mean = 0f;
            _model.stdDev = 1f;
            string expectedResult = (0.6826894921370859f * 100f).ToString();

            //act
            string result = Algorithm.CalculateProbabilityPercentage_ALessThanXLessThanB(_model.A2, _model.B2, _model.mean, _model.stdDev);

            //arrange
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [TestCategory("ProbabilityCalculations")]
        public void Model_XGreaterThanB_CalculationCalculation()
        {
            //assert
            _model.B1 = "1";
            _model.mean = 0f;
            _model.stdDev = 1f;

            string expectedResult = (0.1586552539314571f * 100f).ToString();
            //act
            string result = Algorithm.CalculateProbabilityPercentage_XGreaterThanB(_model.B1, _model.mean, _model.stdDev);

            //arrange
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [TestCategory("CustomControl")]
        public void DrawingCurve_GuassianAlgorithm()
        {
            //Arrange
            BuisnessLogic_and_Data.CustomCurve _customCurve = new BuisnessLogic_and_Data.CustomCurve();
            _model.mean = 0f;
            _model.stdDev = 1f;
            _customCurve.CreateXCoordinates(_model.mean,_model.stdDev);
            float xValue = _customCurve.XValues[0];
            float expectedResult = 0.004431849f;


            //Act
            float result = Algorithm.Gaussian(_model.mean, _model.stdDev, xValue);


            //Assert
            Assert.AreEqual(expectedResult, result);

        }
    }
}
