using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormalDistributionGraph
{
    public class Presenter : IObserver<ModelUpdate>
    {
        private readonly IView _view;
        private readonly IModel _model;
        private readonly IDisposable _ModelUnsubscriber;

        public Presenter(IView view)
        {
            this._view = view;
            _view.ValidatingTextBox += Validating;
            _view.ValidatedTextBox += Validated;
            _view.GenerateNormalDistribution += GenerateNormalDistribution;
            Model model = new Model();
            _model = model;
            _ModelUnsubscriber = model.Subscribe(this);
            Debug.Assert(_ModelUnsubscriber != null, "Subscribing to model must return an unsubscriber");
        }

        //Event Handlers
        private void Validating(object sender, CancelEventArgs e)
        {
            TextBox clickedTextBox = (sender as TextBox);
            if (!IsTextBoxTextValid(clickedTextBox.Text))
            {
                NotValidText(clickedTextBox, _view.TextBoxErrorProvider, e);
                UpdateModelInvalidState(clickedTextBox);
                _model.UpdateProbabiltyPanelAndDistributionButton();
            }

        }

        private void Validated(object sender, EventArgs e)
        {
            TextBox clickedTextBox = (sender as TextBox);
            if (IsTextBoxTextValid(clickedTextBox.Text))
            {
                ValidText((clickedTextBox.Text), clickedTextBox, _view.TextBoxErrorProvider);
                UpdateModelValidState(clickedTextBox);
                _model.UpdateProbabiltyPanelAndDistributionButton();
            }
        }

        private void GenerateNormalDistribution(object sender, EventArgs e)
        {

        }

        //IObserverable methods 
        public void OnNext(ModelUpdate update)
        {
            _view._probabilityPanel.Enabled = update._enableProbPanelDistBtn;
            _view._btnGenNormDistribution.Enabled = update._enableProbPanelDistBtn;

        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }



        //Validation Methods 
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

        public void NotValidText(TextBox clickedTextBox, Dictionary<TextBox, ErrorProvider> textBoxErrorProvider, CancelEventArgs e)
        {
            e.Cancel = true;
            clickedTextBox.Select(0, clickedTextBox.Text.Length);
            textBoxErrorProvider[clickedTextBox].SetError(clickedTextBox, "Please enter a valid number");
        }

        public void ValidText(string textBoxText, TextBox clickedTextBox, Dictionary<TextBox, ErrorProvider> textBoxErrorProvider)
        {
            float inputNum = float.Parse(textBoxText);
            textBoxErrorProvider[clickedTextBox].SetError(clickedTextBox, "");
            textBoxText = inputNum.ToString("0.000");
            clickedTextBox.Text = textBoxText;
        }

        //Updating Model Methods 
        public void UpdateModelValidState(TextBox clickedTextBox)
        {
            switch (clickedTextBox.Name)
            {
                case "textBoxMean":
                    {
                        //meanValue = currentTextBoxString;
                        _model.meanValidated = true;
                        break;
                    }
                case "textBoxStdDev":
                    {
                        //stdDev = currentTextBoxString;
                        _model.stdDevValidated = true;
                        break;
                    }
                default:
                    break;
            }
        }
        public void UpdateModelInvalidState(TextBox clickedTextBox)
        {
            switch (clickedTextBox.Name)
            {
                case "textBoxMean":
                    {
                        _model.meanValidated = false;
                        break;
                    }
                case "textBoxStdDev":
                    {
                        _model.stdDevValidated = false;
                        break;
                    }
                default:
                    break;
            }
        }

        

    }
}
