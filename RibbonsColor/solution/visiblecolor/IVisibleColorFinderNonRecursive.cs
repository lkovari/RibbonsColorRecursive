using RibbonsColor.model;
using System.Drawing;

namespace RibbonsColorRecursive.solution.visiblecolor
{
    internal interface IVisibleColorFinderNonRecursive
    {
        public Color FindVisibleColor(long pos, List<IRibbonModel> ribbons);
    }
}
