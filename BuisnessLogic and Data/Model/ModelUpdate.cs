using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic_and_Data
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

            if (XLessThanA == null) { _XLessThanA = ""; }
            else { _XLessThanA = XLessThanA + "%"; }

            if (ALessThanXLessThanB == null) { _ALessThanXLessThanB = ""; }
            else { _ALessThanXLessThanB = ALessThanXLessThanB + "%"; }


            if (XGreaterThanB == null) { _XGreaterThanB = ""; }
            else { _XGreaterThanB = XGreaterThanB + "%"; }

          
        }

        public bool _enableProbPanelDistBtn { get; set; }
        
        public string _XLessThanA { get; set; }
        public string _ALessThanXLessThanB { get; set; }
        public string _XGreaterThanB { get; set; }
    }
}
