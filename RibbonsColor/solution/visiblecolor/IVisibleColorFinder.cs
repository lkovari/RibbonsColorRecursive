using RibbonsColor.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonsColor.solution.visiblecolor
{
    public interface IVisibleColorFinder
    {
        public Color FindVisibleColor(int pos, List<IRibbonModel> ribbons, ref int level);
    }
}
