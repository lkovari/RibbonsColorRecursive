using RibbonsColor.model;
using System.Drawing;

namespace RibbonsColorRecursive.solution.visiblecolor
{
    internal interface IVisibleColorFinderNonRecursive
    {
        public KnownColor FindVisibleColor(long pos, List<IRibbonModel> ribbons);
    }
}
