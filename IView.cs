using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormalDistributionGraph
{
    public interface IView
    {
        event CancelEventHandler ValidatingTextBox;
        event EventHandler ValidatedTextBox;
        event EventHandler GenerateNormalDistribution;
        Panel _probabilityPanel { get; set; }
        Button _btnGenNormDistribution { get; set; }
        Dictionary<TextBox, ErrorProvider> TextBoxErrorProvider { get; set; }
        Rectangle _rectangleArea { get;  }
        PointF _startingPoint { get; }

        PointF[] _graphXYArray { set; }
        PointF[] _graphSDLines { set; }
        void PaintCurve();
        Label _lblPXACalculation { get; set; }
    }
}
