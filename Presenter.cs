using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BuisnessLogic_and_Data;

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
            if (!TextValidation.TextBoxTextIsValid_Stats(clickedTextBox.Text))
            {
                TextValidation.FocusAndHighlightTextSetError(clickedTextBox, _view.TextBoxErrorProvider, e);
                UpdateModelInvalidState(clickedTextBox);
                _model.UpdateProbabiltyPanelAndDistributionButton();
            }

        }
        private void ValidatedStats(object sender, EventArgs e)
        {
            TextBox clickedTextBox = (sender as TextBox);
            if (TextValidation.TextBoxTextIsValid_Stats(clickedTextBox.Text))
            {
                TextValidation.SetFormattedTextClearError_Stats((clickedTextBox.Text), clickedTextBox, _view.TextBoxErrorProvider);
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
            if (!TextValidation.TextBoxTextIsValid_Probability(clickedTextBox.Text))
            {
                TextValidation.FocusAndHighlightTextSetError(clickedTextBox, _view.TextBoxErrorProvider, e);
                UpdateModelInvalidState(clickedTextBox);
                _model.UpdateProbabiltyPanelAndDistributionButton();
            }

        }
        private void ValidatedProbability(object sender, EventArgs e)
        {
            TextBox clickedTextBox = (sender as TextBox);
            if (TextValidation.TextBoxTextIsValid_Probability(clickedTextBox.Text))
            {
                TextValidation.ValidTextProbability((clickedTextBox.Text), clickedTextBox, _view.TextBoxErrorProvider);
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
                    _model.mean = TextValidation.ParseTextBoxTextFormatted(clickedTextBox);
                    break;
                case "textBoxStdDev":
                    _model.stdDev = TextValidation.ParseTextBoxTextFormatted(clickedTextBox);
                    break;
                case "textBoxA1":
                    _model.A1 = TextValidation.ParseTextBoxUnformatted(clickedTextBox);
                    break;
                case "textBoxA2":
                    _model.A2 = TextValidation.ParseTextBoxUnformatted(clickedTextBox);
                    break;
                case "textBoxB1":
                    _model.B1 = TextValidation.ParseTextBoxUnformatted(clickedTextBox);
                    break;
                case "textBoxB2":
                    _model.B2 = TextValidation.ParseTextBoxUnformatted(clickedTextBox);
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
