using RibbonsColor.model;
using System.Drawing;

namespace RibbonsColor.solution.visiblecolor
{
    public class VisibleColorFinder : IVisibleColorFinder
    {
        public Color FindVisibleColor(long pos, List<IRibbonModel> ribbons, ref int level)
        {
            if (level >= 0)
            {
                if (ribbons[level].HasHoleAtPosition(pos))
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
