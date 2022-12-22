using RibbonsColor.model;
using System.Drawing;

namespace RibbonsColor.solution
{
    public interface IColorFinder
    {
        public List<Color> FindColors(AlgorythmKind algorythm, List<IRibbonModel> ribbons, long fromPos, long toPos);
    }
}
