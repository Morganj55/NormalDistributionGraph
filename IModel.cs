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

        void UpdateProbabiltyPanelAndDistributionButton();

    }
}
