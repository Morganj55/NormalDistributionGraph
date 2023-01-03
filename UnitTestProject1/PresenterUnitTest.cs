using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UserInterface;
using System.Windows.Forms;
using System.Drawing;
using BuisnessLogic_and_Data;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for PresenterUnitTest
    /// </summary>
    [TestClass]
    public class PresenterUnitTest
    {

        //Properties 
        static Presenter _presenter { get; set; }
        static IView _view { get; set; }
        static Dictionary<TextBox, ErrorProvider> textBoxErrorProvider { get; set;}
        static TextBox textBox { get; set; }
        static ErrorProvider errorProvider { get; set; }
        private TestContext testContextInstance;

        

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [ClassInitialize()]
        public static void ClassInitialise(TestContext tc)
        {
            tc.WriteLine("In ClassInitalise");
            tc.WriteLine("Creating View and presenter");
            _view = new UserInterface.View();
            _presenter = new Presenter(_view);
            tc.WriteLine("Creating TextBox, TextBoxErrorProvider");

            textBoxErrorProvider = new Dictionary<TextBox, ErrorProvider>();
            textBox = new TextBox();
            errorProvider = new ErrorProvider();
            textBoxErrorProvider.Add(textBox, errorProvider);

            tc.WriteLine("Creating Model for UpdateModel tests");
            
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            // Dispose of all objects that are un-needed 
        }



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
        [TestCategory("UpdateModelStates")]
        public void UpdateModel_ValidState_MeanTextBox()
        {
            //arrange
            textBox.Name = "textBoxMean";
            

            //Act
            _presenter.UpdateModelValidState(textBox);
            bool result = _presenter._model.meanValidated;


            //Assert
            
            Assert.IsTrue(result);

        }

        [TestMethod]
        [TestCategory("UpdateModelStates")]
        public void UpdateModel_ValidState_StdDevTextBox()
        {
            //arrange
            textBox.Name = "textBoxStdDev";
            

            //Act
            _presenter.UpdateModelValidState(textBox);
            bool result = _presenter._model.meanValidated;


            //Assert
            Assert.IsTrue(result);

        }
        [TestMethod]
        [TestCategory("UpdateModelStates")]
        public void UpdateModel_InvalidState_MeanTextBox()
        {
            //arrange
            textBox.Name = "textBoxMean";


            //Act
            _presenter.UpdateModelInvalidState(textBox);
            bool result = _presenter._model.meanValidated;


            //Assert

            Assert.IsFalse(result);

        }

        [TestMethod]
        [TestCategory("UpdateModelStates")]
        public void UpdateModel_InvalidState_StdDevTextBox()
        {
            //arrange
            textBox.Name = "textBoxStdDev";


            //Act
            _presenter.UpdateModelInvalidState(textBox);
            bool result = _presenter._model.meanValidated;


            //Assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        [TestCategory("UpdateModelStates")]
        public void UpdateModel_InputNums_Mean()
        {
            //arrange
            textBox.Name = "textBoxMean";
            textBox.Text = "0.0000";
            float expectedResult = 0.000f;

            //Act
            _presenter.UpdateModelInputNumbers(textBox);
            float result = _presenter._model.mean;


            //Assert
            Assert.AreEqual(expectedResult,result);

        }

        [TestMethod]
        [TestCategory("UpdateModelStates")]
        public void UpdateModel_InputNums_StdDev()
        {
            //arrange
            textBox.Name = "textBoxStdDev";
            textBox.Text = "0.1245";
            float expectedResult = 0.125f;

            //Act
            _presenter.UpdateModelInputNumbers(textBox);
            float result = _presenter._model.stdDev;


            //Assert
            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        [TestCategory("UpdateModelStates")]
        public void UpdateModel_InputNums_A1()
        {
            //arrange
            textBox.Name = "textBoxA1";
            textBox.Text = "0.12456789";
            string expectedResult = "0.12456789";

            //Act
            _presenter.UpdateModelInputNumbers(textBox);
            string result = _presenter._model.A1;


            //Assert
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        [TestCategory("UpdateModelStates")]
        public void UpdateModel_InputNums_A2()
        {
            //arrange
            textBox.Name = "textBoxA2";
            textBox.Text = "0.12456789";
            string expectedResult = "0.12456789";

            //Act
            _presenter.UpdateModelInputNumbers(textBox);
            string result = _presenter._model.A2;


            //Assert
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        [TestCategory("UpdateModelStates")]
        public void UpdateModel_InputNums_B1()
        {
            //arrange
            textBox.Name = "textBoxB1";
            textBox.Text = "0.12456789";
            string expectedResult = "0.12456789";

            //Act
            _presenter.UpdateModelInputNumbers(textBox);
            string result = _presenter._model.B1;


            //Assert
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        [TestCategory("UpdateModelStates")]
        public void UpdateModel_InputNums_B2()
        {
            //arrange
            textBox.Name = "textBoxB2";
            textBox.Text = "0.12456789";
            string expectedResult = "0.12456789";

            //Act
            _presenter.UpdateModelInputNumbers(textBox);
            string result = _presenter._model.B2;


            //Assert
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        [TestCategory("UpdateModelStates")]
        public void UpdateModel_CustomControl_Rectangle()
        {
            //arrange
            Rectangle expectedResult = _view._rectangleArea;
            

            //Act
            _presenter.SetCustomControlProperteis();
            Rectangle result = _presenter._model.rectangle;


            //Assert
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        [TestCategory("UpdateModelStates")]
        public void UpdateModel_CustomControl_StartingPoint()
        {
            //arrange
            PointF expectedResult = _view._startingPoint;


            //Act
            _presenter.SetCustomControlProperteis();
            PointF result = _presenter._model.startingPoint;


            //Assert
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        [TestCategory("IObserverable")]
        public void IObserverable_OnNext_ProbabilityPanel_True()
        {
            //arrange

            ModelUpdate update = new ModelUpdate(true);

            //Act
            _presenter.OnNext(update);
            bool result = _view._probabilityPanel.Enabled;


            //Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        [TestCategory("IObserverable")]
        public void IObserverable_OnNext_ProbabilityPanel_False()
        {
            //arrange

            ModelUpdate update = new ModelUpdate(false);

            //Act
            _presenter.OnNext(update);
            bool result = _view._probabilityPanel.Enabled;


            //Assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        [TestCategory("IObserverable")]
        public void IObserverable_OnNext_GenerateDistributionButton_True()
        {
            //arrange

            ModelUpdate update = new ModelUpdate(true);

            //Act
            _presenter.OnNext(update);
            bool result = _view._btnGenNormDistribution.Enabled;


            //Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        [TestCategory("IObserverable")]
        public void IObserverable_OnNext_GenerateDistributionButton_False()
        {
            //arrange
            ModelUpdate update = new ModelUpdate(false);

            //Act
            _presenter.OnNext(update);
            bool result = _view._btnGenNormDistribution.Enabled;


            //Assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        [TestCategory("IObserverable")]
        public void IObserverable_OnNext_SetLabelText_Steve()
        {
            //arrange
            string expectedResult = "96.876546";
            ModelUpdate update = new ModelUpdate(false,expectedResult, null, null);

            //Act
            _presenter.OnNext(update);
            string result = _view._lblPXACalculationSteve.Text;


            //Assert
            Assert.AreEqual(expectedResult + "%",result);

        }

        [TestMethod]
        [TestCategory("IObserverable")]
        public void IObserverable_OnNext_SetLabelText_Mike()
        {
            //arrange
            string expectedResult = "96.876546";
            ModelUpdate update = new ModelUpdate(false, null, expectedResult, null);

            //Act
            _presenter.OnNext(update);
            string result = _view._lblAXBCalculationMike.Text;


            //Assert
            Assert.AreEqual(expectedResult + "%", result);

        }

        [TestMethod]
        [TestCategory("IObserverable")]
        public void IObserverable_OnNext_SetLabelText_Tony()
        {
            //arrange
            string expectedResult = "96.876546";
            ModelUpdate update = new ModelUpdate(false, null, null, expectedResult);

            //Act
            _presenter.OnNext(update);
            string result = _view._lblPXBCalculationTony.Text;


            //Assert
            Assert.AreEqual(expectedResult + "%", result);

        }


    }
}




 