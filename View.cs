using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //Properties and Events 
        public event CancelEventHandler ValidatingTextBox;
        public event EventHandler ValidatedTextBox;
        public event EventHandler GenerateNormalDistribution;
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


        public void View_Load(object sender, EventArgs e)
        {
            TextBoxErrorProvider = new Dictionary<TextBox, ErrorProvider>();
            TextBoxErrorProvider.Add(textBoxMean, errorProviderMean);
            TextBoxErrorProvider.Add(textBoxStdDev, errorProviderStdDev);
            TextBoxErrorProvider.Add(textBoxA1, errorProviderA1);
            TextBoxErrorProvider.Add(textBoxA2, errorProviderA2);
            TextBoxErrorProvider.Add(textBoxB1, errorProviderB1);
            TextBoxErrorProvider.Add(textBoxB2, errorProviderB2);
            
        }

        public void textBox_Validating(object sender, CancelEventArgs e)
        {
            ValidatingTextBox?.Invoke(sender, e);
        }

        public void textBox_Validated(object sender, EventArgs e)
        {
            ValidatedTextBox?.Invoke(sender, EventArgs.Empty);
        }

        private void btnGenNormDist_Click(object sender, EventArgs e)
        {
            GenerateNormalDistribution?.Invoke(sender, EventArgs.Empty);
        }
    }
}
