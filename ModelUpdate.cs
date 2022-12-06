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

        public ModelUpdate(bool enableProbPanelDistBtn, string XLessThanA, string ALessThanXLessThanB, string XGreaterThanB)
        { 
            _enableProbPanelDistBtn = enableProbPanelDistBtn;
            //if (XLessThanA == default) { _XLessThanA = ""; }
            //else { _XLessThanA = XLessThanA.ToString("0.000000") + "%"; }

            //if (ALessThanXLessThanB == default) { _ALessThanXLessThanB = ""; }
            //else { _ALessThanXLessThanB = ALessThanXLessThanB.ToString("0.000000") + "%";  }
           

            //if (XGreaterThanB == default) { _XGreaterThanB= ""; }
            //else { _XGreaterThanB = XGreaterThanB.ToString("0.000000") + "%"; }

            _XLessThanA = XLessThanA + "%";
            _ALessThanXLessThanB = ALessThanXLessThanB + "%";
            _XGreaterThanB = XGreaterThanB + "%";
        }

        public bool _enableProbPanelDistBtn { get; set; }
        
        public string _XLessThanA { get; set; }
        public string _ALessThanXLessThanB { get; set; }
        public string _XGreaterThanB { get; set; }
    }
}
