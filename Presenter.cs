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
        //Properties 
        private readonly IView _view;
        public readonly IModel _model;
        private readonly IDisposable _ModelUnsubscriber;

        //Constructor
        public Presenter(IView view)
        {
            this._view = view;
            _view.ValidatingStatsTextBox += ValidatingStats;
            _view.ValidatedStatsTextBox += ValidatedStats;
            _view.GenerateNormalDistribution += GenerateNormalDistribution;
            _view.ValidatedProbabilityTextBox += ValidatedProbability;
            _view.ValidatingProbabilityTextBox += ValidatingProbability;
            Model model = new Model();
            _model = model;
            _ModelUnsubscriber = model.Subscribe(this);
            Debug.Assert(_ModelUnsubscriber != null, "Subscribing to model must return an unsubscriber");
          
        }

        //Event Handlers
        private void ValidatingStats(object sender, CancelEventArgs e)
        {
            TextBox clickedTextBox = (sender as TextBox);
            if (!IsTextBoxTextValidStats(clickedTextBox.Text))
            {
                NotValidText(clickedTextBox, _view.TextBoxErrorProvider, e);
                UpdateModelInvalidState(clickedTextBox);
                _model.UpdateProbabiltyPanelAndDistributionButton();
            }

        }
        private void ValidatedStats(object sender, EventArgs e)
        {
            TextBox clickedTextBox = (sender as TextBox);
            if (IsTextBoxTextValidStats(clickedTextBox.Text))
            {
                ValidTextStats((clickedTextBox.Text), clickedTextBox, _view.TextBoxErrorProvider);
                UpdateModelValidState(clickedTextBox);
                UpdateModelInputNumbers(clickedTextBox);
                _model.UpdateProbabiltyPanelAndDistributionButton();
            }
            if (_model.enableProbPanelDistBtn)
            {
                _model.UpdateProbabilities();
            }

        }
        private void GenerateNormalDistribution(object sender, EventArgs e)
        {
            SetCustomControlProperteis();
            _view._graphXYArray = _model.GenerateCurve();
            _view._graphSDLines = _model.GenerateSDLines();
            _view.PaintCurve();
            _model.Reset();
        }
        private void ValidatingProbability(object sender, CancelEventArgs e)
        {
            TextBox clickedTextBox = (sender as TextBox);
            if (!IsTextBoxTextValidProbability(clickedTextBox.Text))
            {
                NotValidText(clickedTextBox, _view.TextBoxErrorProvider, e);
                UpdateModelInvalidState(clickedTextBox);
                _model.UpdateProbabiltyPanelAndDistributionButton();
            }

        }
        private void ValidatedProbability(object sender, EventArgs e)
        {
            TextBox clickedTextBox = (sender as TextBox);
            if (IsTextBoxTextValidProbability(clickedTextBox.Text))
            {
                ValidTextProbability((clickedTextBox.Text), clickedTextBox, _view.TextBoxErrorProvider);
                UpdateModelValidState(clickedTextBox);
                UpdateModelInputNumbers(clickedTextBox);
                _model.UpdateProbabiltyPanelAndDistributionButton();
            }
            if (_model.enableProbPanelDistBtn)
            {
                _model.UpdateProbabilities();
            }
        }

        //IObserverable methods 
        public void OnNext(ModelUpdate update)
        {
            _view._probabilityPanel.Enabled = update._enableProbPanelDistBtn;
            _view._btnGenNormDistribution.Enabled = update._enableProbPanelDistBtn;
           _view._lblPXACalculationSteve.Text = update._XLessThanA; 
            _view._lblAXBCalculationMike.Text = update._ALessThanXLessThanB;
            _view._lblPXBCalculationTony.Text = update._XGreaterThanB; 
            
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
        public bool IsTextBoxTextValidStats(string textBoxText)
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
        public bool IsTextBoxTextValidProbability(string textBoxText)
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
                return true;
            }
        }
        public void NotValidText(TextBox clickedTextBox, Dictionary<TextBox, ErrorProvider> textBoxErrorProvider, CancelEventArgs e)
        {
            e.Cancel = true;
            clickedTextBox.Select(0, clickedTextBox.Text.Length);
            textBoxErrorProvider[clickedTextBox].SetError(clickedTextBox, "Please enter a valid number");
        }
        public void ValidTextStats(string textBoxText, TextBox clickedTextBox, Dictionary<TextBox, ErrorProvider> textBoxErrorProvider)
        {
            float inputNum = float.Parse(textBoxText);
            textBoxErrorProvider[clickedTextBox].SetError(clickedTextBox, "");
            textBoxText = inputNum.ToString("0.000");
            clickedTextBox.Text = textBoxText;
            
        }
        public void ValidTextProbability(string textBoxText, TextBox clickedTextBox, Dictionary<TextBox, ErrorProvider> textBoxErrorProvider)
        {
            if (textBoxText == null)
            {
                clickedTextBox.Text = "";   
            }
            textBoxErrorProvider[clickedTextBox].SetError(clickedTextBox, "");
        }
        public float ParseTextBoxTextFormat(TextBox clickedTextBox)
        {
            float inputNum = float.Parse(clickedTextBox.Text);
            string textBoxText = inputNum.ToString("0.000");
            return float.Parse(textBoxText);
        }
        public string ParseTextBoxUnformatted(TextBox clickedTextBox)
        {
            return clickedTextBox.Text;
        }

        //Updating Model Methods 
        public void UpdateModelValidState(TextBox clickedTextBox)
        {
            switch (clickedTextBox.Name)
            {
                case "textBoxMean":
                    {
                        _model.meanValidated = true;
                        break;
                    }
                case "textBoxStdDev":
                    {
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
        public void UpdateModelInputNumbers(TextBox clickedTextBox)
        {
            switch (clickedTextBox.Name)
            {
                case "textBoxMean":
                    _model.mean = ParseTextBoxTextFormat(clickedTextBox);
                    break;
                case "textBoxStdDev":
                    _model.stdDev = ParseTextBoxTextFormat(clickedTextBox);
                    break;
                case "textBoxA1":
                    _model.A1 = ParseTextBoxUnformatted(clickedTextBox);
                    break;
                case "textBoxA2":
                    _model.A2 = ParseTextBoxUnformatted(clickedTextBox);
                    break;
                case "textBoxB1":
                    _model.B1 = ParseTextBoxUnformatted(clickedTextBox);
                    break;
                case "textBoxB2":
                    _model.B2 = ParseTextBoxUnformatted(clickedTextBox);
                    break;
                default:
                    break;
            }
        }
        public void SetCustomControlProperteis()
        {
            _model.startingPoint = _view._startingPoint;
            _model.rectangle = _view._rectangleArea;
        }

    }
}
