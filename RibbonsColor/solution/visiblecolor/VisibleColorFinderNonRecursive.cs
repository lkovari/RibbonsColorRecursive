using RibbonsColor.model;
using System.Drawing;

namespace RibbonsColorRecursive.solution.visiblecolor
{
    public class VisibleColorFinderNonRecursive : IVisibleColorFinderNonRecursive
    {
        public Color FindVisibleColor(long pos, List<IRibbonModel> ribbons)
        {
            int ixr = ribbons.Count - 1;
            Color foundColor = ribbons[ixr].RibbonColor;
            while (ixr > 0 && (ribbons[ixr].HasHoleAtPosition(pos)))
            {
                ixr--;
                foundColor = ribbons[ixr].RibbonColor;
            }
            return foundColor;
        }
    }
}
