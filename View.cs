using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControl;

namespace NormalDistributionGraph
{
    public partial class View : Form, IView
    {
        public View()
        {
            InitializeComponent();
            presenter = new Presenter(this);
            
        }

        //References 
        private readonly Presenter presenter;
        //private readonly CustomCurve newCurve;

        //Properties and Events 
        public event CancelEventHandler ValidatingStatsTextBox;
        public event EventHandler ValidatedStatsTextBox;
        public event EventHandler GenerateNormalDistribution;
        public event CancelEventHandler ValidatingProbabilityTextBox;
        public event EventHandler ValidatedProbabilityTextBox;
        public Dictionary<TextBox, ErrorProvider> TextBoxErrorProvider { get; set; }
 

        public Panel _probabilityPanel
        {
            get { return ProbabilityPanel; }
            set { ProbabilityPanel = value; }
        }
        public Button _btnGenNormDistribution
        {
            get { return btnGenNormDist; }
            set { btnGenNormDist = value; }
        }
        public Label _lblPXACalculationSteve
        {
            get { return steve; }
            set { steve = value; }
        }

        public Label _lblAXBCalculationMike
        {
            get { return mike; }
            set { mike = value; }
        }
        public Label _lblPXBCalculationTony
        {
            get { return tony; }
            set {tony = value; }
        }

        public Rectangle _rectangleArea
        {
            get { return newCurve1.rectangleArea; }
        }
        public PointF _startingPoint
        {
            get { return newCurve1.startingPoint; }
        }
        public PointF[] _graphXYArray
        {
            set { newCurve1.graphXYArray = value; }
        }
        public PointF[] _graphSDLines
        {
            set { newCurve1.graphSDLines = value; }
        }

        public void View_Load(object sender, EventArgs e)
        {
            TextBoxErrorProvider = new Dictionary<TextBox, ErrorProvider>();
            TextBoxErrorProvider.Add(textBoxMean, errorProviderMean);
            TextBoxErrorProvider.Add(textBoxStdDev, errorProviderStdDev);
            TextBoxErrorProvider.Add(textBoxA1, errorProviderA1);
            TextBoxErrorProvider.Add(textBoxA2, errorProviderA2);
            TextBoxErrorProvider.Add(textBoxB1, errorProviderB1);
            TextBoxErrorProvider.Add(textBoxB2, errorProviderB2);

            textBoxMean.Text = "0.000";
            textBoxStdDev.Text = "1.000";
            ValidatedStatsTextBox.Invoke(textBoxMean, e);
            ValidatedStatsTextBox.Invoke(textBoxStdDev, e);
        }

        public void textBoxStats_Validating(object sender, CancelEventArgs e)
        {
            ValidatingStatsTextBox?.Invoke(sender, e);
        }

        public void textBoxStats_Validated(object sender, EventArgs e)
        {
            ValidatedStatsTextBox?.Invoke(sender, EventArgs.Empty);
        }

        public void textBoxProbability_Validated(object sender, EventArgs e)
        {
            ValidatedProbabilityTextBox?.Invoke(sender, EventArgs.Empty);
        }

        public void textBoxProbability_Validating(object sender, CancelEventArgs e)
        {
            ValidatingProbabilityTextBox?.Invoke(sender, e);
        }

        private void btnGenNormDist_Click(object sender, EventArgs e)
        {
            GenerateNormalDistribution?.Invoke(sender, EventArgs.Empty);
        }

        private void customContolResize(object sender, EventArgs e)
        {
            GenerateNormalDistribution?.Invoke(sender, EventArgs.Empty);
            PaintCurve();
        }

        public void PaintCurve()
        {
            newCurve1.Invalidate();
        }

      
    }
}
