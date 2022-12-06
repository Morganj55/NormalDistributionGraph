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

        public ModelUpdate(bool enableProbPanelDistBtn, float XLessThanA, float ALessThanXLessThanB, float XGreaterThanB)
        {
            _enableProbPanelDistBtn = enableProbPanelDistBtn;
            _XLessThanA = XLessThanA;
            _ALessThanXLessThanB = ALessThanXLessThanB;
            _XGreaterThanB = XGreaterThanB;
        }

        public bool _enableProbPanelDistBtn { get; set; }
        
        public float _XLessThanA { get; set; }
        public float _ALessThanXLessThanB{ get; set; }
        public float _XGreaterThanB { get; set; }
    }
}
