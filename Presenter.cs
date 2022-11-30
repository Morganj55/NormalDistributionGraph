using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormalDistributionGraph
{
    public class Presenter
    {
        private readonly IView _View;

        public Presenter(IView view)
        {
            this._View = view;
            _View.ValidatingTextBox += Validating;
            _View.ValidatedTextBox += Validated;
        }

        //Event Hnadlers
        private void Validating(object sender, CancelEventArgs e)
        {
            if (!IsTextBoxTextValid((sender as TextBox).Text))
            {
                NotValidText((sender as TextBox), _View.TextBoxErrorProvider, e);
            }
        }

        private void Validated(object sender, EventArgs e)
        {
            if (IsTextBoxTextValid((sender as TextBox).Text))
            {
                ValidText(((sender as TextBox).Text), (sender as TextBox), _View.TextBoxErrorProvider);
            }
        }

        //Methods 
        public bool IsTextBoxTextValid(string textBoxText)
        {
            if (textBoxText.Length > 0)
            {
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^(?=.)([+-]?([0-9]*)(\.([0-9]+))?)$");
                System.Text.RegularExpressions.Match match = regex.Match(textBoxText);
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

        public void NotValidText(TextBox whichTextBox, Dictionary<TextBox, ErrorProvider> textBoxErrorProvider, CancelEventArgs e)
        {
            e.Cancel = true;
            whichTextBox.Select(0, whichTextBox.Text.Length);
            textBoxErrorProvider[whichTextBox].SetError(whichTextBox, "Please enter a valid number");
        }


        public void ValidText(string textBoxText, TextBox whichTextBox, Dictionary<TextBox, ErrorProvider> TextBoxErrorProvider)
        {
            float textBoxStringToFloat = float.Parse(textBoxText);
            TextBoxErrorProvider[whichTextBox].SetError(whichTextBox, "");
            textBoxText = textBoxStringToFloat.ToString("0.000");
            whichTextBox.Text = textBoxText;
        }



    }
}
