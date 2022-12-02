using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalDistributionGraph
{
    public interface ICurve
    {
        Rectangle rectangleArea { get; set; }
        PointF startingPoint { get; set; }
        PointF[] graphXYArray { get; set; }
        PointF[] graphSDLines { get; set; }
    }
}
