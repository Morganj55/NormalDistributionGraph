using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserInterface;
using Algorithms;
using BuisnessLogic_and_Data;

namespace UnitTestProject1
{
    [TestClass]
    public class ModelUnitTest
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


        [TestMethod]
        [TestCategory("MethodsCalledByPresenter")]
        public void Update_PanelAndButton_True()
        {
            //Arrange
            _model.meanValidated = true;
            _model.stdDevValidated = true;


            //Act
            _model.UpdateProbabiltyPanelAndDistributionButton();
            bool result = _model.enableProbPanelDistBtn;

            //Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        [TestCategory("MethodsCalledByPresenter")]
        public void Update_PanelAndButton_False1()
        {
            //Arrange
            _model.meanValidated = false;
            _model.stdDevValidated = true;


            //Act
            _model.UpdateProbabiltyPanelAndDistributionButton();
            bool result = _model.enableProbPanelDistBtn;

            //Assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        [TestCategory("MethodsCalledByPresenter")]
        public void Update_PanelAndButton_False2()
        {
            //Arrange
            _model.meanValidated = true;
            _model.stdDevValidated = false;


            //Act
            _model.UpdateProbabiltyPanelAndDistributionButton();
            bool result = _model.enableProbPanelDistBtn;

            //Assert
            Assert.IsFalse(result);

        }

     



     

    }
}
