using RibbonsColor.model;
using System.Drawing;

namespace RibbonsColor.solution.visiblecolor
{
    public interface IVisibleColorFinder
    {
        public KnownColor FindVisibleColor(long pos, List<IRibbonModel> ribbons, ref int level);
    }
}
