using RibbonsColor.model;
using System.Drawing;

namespace RibbonsColor.solution
{
    public interface IColorFinder
    {
        public List<KnownColor> FindColors(AlgorythmKind algorythm, List<IRibbonModel> ribbons, long fromPos, long toPos);
    }
}
