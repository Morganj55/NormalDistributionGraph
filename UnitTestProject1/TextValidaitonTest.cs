using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserInterface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BuisnessLogic_and_Data;

namespace UnitTestProject1
{
    [TestClass]
    public class TextValidaitonTest
    {
        //Properties 
        
        
        static Dictionary<TextBox, ErrorProvider> textBoxErrorProvider { get; set; }
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

        [TestMethod]
        [TestCategory("TextValidation")]
        public void Valid_StatsText_ValidText_Int()
        {
            //arrange
            string validText = "0";

            //Act
            bool result = TextValidation.TextBoxTextIsValid_Stats(validText);

            //Assert
            Assert.IsTrue(result);

        }
        [TestMethod]
        [TestCategory("TextValidation")]
        public void Valid_StatsText_ValidText_Decimal()
        {
            //arrange
            string validText = "0.12345";

            //Act
            bool result = TextValidation.TextBoxTextIsValid_Stats(validText);

            //Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        [TestCategory("TextValidation")]
        public void Valid_StatsText_InValidText_Alphabet()
        {
            //arrange
            string validText = "0a";

            //Act
            bool result = TextValidation.TextBoxTextIsValid_Stats(validText);

            //Assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        [TestCategory("TextValidation")]
        public void Valid_StatsText_InValidText_TwoDecimals()
        {
            //arrange
            string validText = "0.123.123";

            //Act
            bool result = TextValidation.TextBoxTextIsValid_Stats(validText);

            //Assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        [TestCategory("TextValidation")]
        public void Valid_StatsText_InValidText_SpecialCharacters()
        {
            //arrange
            string validText = "!";

            //Act
            bool result = TextValidation.TextBoxTextIsValid_Stats(validText);

            //Assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        [TestCategory("TextValidation")]
        public void Valid_StatsText_InValidText_null()
        {
            //arrange
            string validText = "";

            //Act
            bool result = TextValidation.TextBoxTextIsValid_Stats(validText);

            //Assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        [TestCategory("TextValidation")]
        public void Valid_ProbabilityText_ValidInt()
        {
            //arrange
            string validText = "1";

            //Act
            bool result = TextValidation.TextBoxTextIsValid_Probability(validText);

            //Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        [TestCategory("TextValidation")]
        public void Valid_ProbabilityText_ValidDecimal()
        {
            //arrange
            string validText = "0.8787656";

            //Act
            bool result = TextValidation.TextBoxTextIsValid_Probability(validText);

            //Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        [TestCategory("TextValidation")]
        public void Valid_ProbabilityText_ValidIsNull()
        {
            //arrange
            string validText = "";

            //Act
            bool result = TextValidation.TextBoxTextIsValid_Probability(validText);

            //Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        [TestCategory("TextValidation")]
        public void Valid_Probability_IfNullInsertEmpty()
        {
            //arrange
            string validText = null;
            string expectedResult = "";

            //Act
            TextValidation.ValidTextProbability(validText, textBox, textBoxErrorProvider);


            //Assert
            Assert.AreEqual(expectedResult, textBox.Text);

        }

        [TestMethod]
        [TestCategory("TextFormatting")]
        public void Valid_Stats_FormatTo3dp()
        {
            //arrange
            string validText = "1.67854";
            string expectedResult = "1.679";

            //Act
            TextValidation.SetFormattedTextClearError_Stats(validText, textBox, textBoxErrorProvider);


            //Assert
            Assert.AreEqual(expectedResult, textBox.Text);

        }

        [TestMethod]
        [TestCategory("TextFormatting")]
        public void FormatText_FormatTo3dp()
        {
            //arrange
            textBox.Text = "1.67854";
            float expectedResult = 1.679f;

            //Act
            float result = TextValidation.ParseTextBoxTextFormatted(textBox);


            //Assert
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        [TestCategory("TextFormatting")]
        public void FormatText_Unformatted()
        {
            //arrange
            textBox.Text = "1.67854";
            string expectedResult = "1.67854";

            //Act
            string result = TextValidation.ParseTextBoxUnformatted(textBox);


            //Assert
            Assert.AreEqual(expectedResult, result);

        }

    }
}
