using RibbonsColor.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonsColor.solution.visiblecolor
{
    public class VisibleColorFinder : IVisibleColorFinder
    {
        public Color FindVisibleColor(int pos, List<IRibbonModel> ribbons, ref int level)
        {
            if (level >= 0)
            {
                if (ribbons[level].HolePositions[pos])
                {
                    level--;
                    return FindVisibleColor(pos, ribbons, ref level);
                }
                else
                {
                    return ribbons[level].RibbonColor;
                }

            }
            else
            {
                return ribbons[level].RibbonColor;
            }
        }
    }
}
