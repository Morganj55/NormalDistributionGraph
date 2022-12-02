using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalDistributionGraph
{
    interface IModel
    {
        bool meanValidated {get;set;}
        bool stdDevValidated { get; set; }
        bool enableProbPanelDistBtn { get; set; }
        float mean { get; set; }
        float stdDev { get; set; }
        float A1  {get; set; }
        float A2 { get; set; }
        float B1 { get; set; }
        float B2 { get; set; }


        void UpdateProbabiltyPanelAndDistributionButton();

    }
}
