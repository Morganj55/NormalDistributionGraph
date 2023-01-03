using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuisnessLogic_and_Data
{
    public interface IView
    {
        //Event Handlers
        event CancelEventHandler ValidatingStatsTextBox;
        event EventHandler ValidatedStatsTextBox;
        event EventHandler GenerateNormalDistribution;
        event CancelEventHandler ValidatingProbabilityTextBox;
        event EventHandler ValidatedProbabilityTextBox;

        //Form controls 
        Panel _probabilityPanel { get; set; }
        Button _btnGenNormDistribution { get; set; }
        Dictionary<TextBox, ErrorProvider> TextBoxErrorProvider { get; set; }
        Label _lblPXACalculationSteve { get; set; }
        Label _lblAXBCalculationMike { get; set; }
        Label _lblPXBCalculationTony { get; set; }

        //Curve Properties 
        Rectangle _rectangleArea { get;  }
        PointF _startingPoint { get; }
        PointF[] _graphXYArray { set; }
        PointF[] _graphSDLines { set; }
        List<float> _XValues { set; }
        string mean { set; }
        float stdDev { set; }
        

        //Curve Methods
        void PaintCurve();
        
      
    }
}
