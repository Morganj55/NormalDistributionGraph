using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalDistributionGraph
{
    public class ModelUpdate
    {

        public ModelUpdate(bool enableProbPanelDistBtn)
        {
            _enableProbPanelDistBtn = enableProbPanelDistBtn;
        }

        public bool _enableProbPanelDistBtn { get; set; }
        
    }
}
