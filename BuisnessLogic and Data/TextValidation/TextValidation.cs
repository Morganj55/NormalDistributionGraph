using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.ComponentModel;

namespace BuisnessLogic_and_Data
{
    public static class TextValidation
    {

        public static bool TextBoxTextIsValid_Stats(string textBoxText)
        {
            if (textBoxText.Length > 0)
            {
                Regex regex = new Regex(@"^(?=.)([+-]?([0-9]*)(\.([0-9]+))?)$");
                Match match = regex.Match(textBoxText);
                if (match.Success)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            else
            {
                return false;
            }
        }
        public static bool TextBoxTextIsValid_Probability(string textBoxText)
        {
            if (textBoxText.Length > 0)
            {
                Regex regex = new Regex(@"^(?=.)([+-]?([0-9]*)(\.([0-9]+))?)$");
                Match match = regex.Match(textBoxText);
                if (match.Success)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            else
            {
                return true;
            }
        }
        public static void FocusAndHighlightTextSetError(TextBox clickedTextBox, Dictionary<TextBox, ErrorProvider> textBoxErrorProvider, CancelEventArgs e)
        {
            e.Cancel = true;
            clickedTextBox.Select(0, clickedTextBox.Text.Length);
            textBoxErrorProvider[clickedTextBox].SetError(clickedTextBox, "Please enter a valid number");
        }
        public static void SetFormattedTextClearError_Stats(string textBoxText, TextBox clickedTextBox, Dictionary<TextBox, ErrorProvider> textBoxErrorProvider)
        {
            float inputNum = float.Parse(textBoxText);
            textBoxErrorProvider[clickedTextBox].SetError(clickedTextBox, "");
            textBoxText = inputNum.ToString("0.000");
            clickedTextBox.Text = textBoxText;

        }
        public static  void ValidTextProbability(string textBoxText, TextBox clickedTextBox, Dictionary<TextBox, ErrorProvider> textBoxErrorProvider)
        {
            if (textBoxText == null)
            {
                clickedTextBox.Text = "";
            }
            textBoxErrorProvider[clickedTextBox].SetError(clickedTextBox, "");
        }
        public static float ParseTextBoxTextFormatted(TextBox clickedTextBox)
        {
            float inputNum = float.Parse(clickedTextBox.Text);
            string textBoxText = inputNum.ToString("0.000");
            return float.Parse(textBoxText);
        }
        public static string ParseTextBoxUnformatted(TextBox clickedTextBox)
        {
            return clickedTextBox.Text;
        }


    }
}
