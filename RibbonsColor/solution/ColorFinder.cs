using RibbonsColor.model;
using RibbonsColor.solution.visiblecolor;
using RibbonsColorRecursive.solution.visiblecolor;
using System.Drawing;

namespace RibbonsColor.solution
{
    public class ColorFinder : IColorFinder
    {
        private IVisibleColorFinder? visibleColorFinder;
        private IVisibleColorFinderNonRecursive? visibleColorFinderNonRecursive;
        public List<Color> FindColors(AlgorythmKind algorythm, List<IRibbonModel> ribbons, long fromPos, long toPos)
        {
            List<Color> colors = new();

            for (long pos = fromPos; pos < toPos; pos++)
            {
                Color foundColor;
                switch (algorythm)
                {
                    case AlgorythmKind.RECURSIVE:
                        {
                            if (visibleColorFinder == null)
                            {
                                visibleColorFinder = new VisibleColorFinder();
                            }
                            int level = ribbons.Count - 1;
                            foundColor = visibleColorFinder.FindVisibleColor(pos, ribbons, ref level);
                            colors.Add(foundColor);
                            break;
                        }
                    case AlgorythmKind.NON_RECURSIVE:
                        {
                            if (visibleColorFinderNonRecursive == null)
                            {
                                visibleColorFinderNonRecursive = new VisibleColorFinderNonRecursive();
                            }
                            foundColor = visibleColorFinderNonRecursive.FindVisibleColor(pos, ribbons);
                            colors.Add(foundColor);
                            break;
                        }
                }
            }

            return colors;
        }
    }
}
