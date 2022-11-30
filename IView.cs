using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        Panel _probabilityPanel { get; set; }
        Dictionary<TextBox, ErrorProvider> TextBoxErrorProvider { get; set; }

    }
}
