using RibbonsColor.model;
using System.Drawing;

namespace RibbonsColorRecursive.solution.visiblecolor
{
    public class VisibleColorFinderNonRecursive : IVisibleColorFinderNonRecursive
    {
        public KnownColor FindVisibleColor(long pos, List<IRibbonModel> ribbons)
        {
            int ixr = ribbons.Count - 1;
            KnownColor foundColor = ribbons[ixr].RibbonColor;
            while (ixr > 0 && (ribbons[ixr].HasHoleAtPosition(pos)))
            {
                ixr--;
                foundColor = ribbons[ixr].RibbonColor;
            }
            return foundColor;
        }
    }
}
