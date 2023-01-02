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

        public List<KnownColor> FindColors(AlgorythmKind algorythm, List<IRibbonModel> ribbons, long fromPos, long toPos)
        {
            List<KnownColor> colors = new();

            for (long pos = fromPos; pos < toPos; pos++)
            {
                KnownColor foundColor;
                switch (algorythm)
                {
                    case AlgorythmKind.RECURSIVE:
                        {
                            if (visibleColorFinder == null)
                            {
                                visibleColorFinder = new VisibleColorFinder();
                            }
                            int level = ribbons.Count - 1;
                            if (ribbons[level].HasHoleAtPosition(pos))
                            {
                                foundColor = visibleColorFinder.FindVisibleColor(pos, ribbons, ref level);
                            } else
                            {
                                foundColor = ribbons[level].RibbonColor;
                            }
                            colors.Add(foundColor);
                            break;
                        }
                    case AlgorythmKind.NON_RECURSIVE:
                        {
                            if (visibleColorFinderNonRecursive == null)
                            {
                                visibleColorFinderNonRecursive = new VisibleColorFinderNonRecursive();
                            }
                            if (ribbons[ribbons.Count - 1].HasHoleAtPosition(pos))
                            {
                                foundColor = visibleColorFinderNonRecursive.FindVisibleColor(pos, ribbons);
                            } else
                            {
                                foundColor = ribbons[ribbons.Count - 1].RibbonColor;
                            }
                            colors.Add(foundColor);
                            break;
                        }
                }
            }

            return colors;
        }
    }
}
