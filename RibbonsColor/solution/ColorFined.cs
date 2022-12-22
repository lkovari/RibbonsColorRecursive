using RibbonsColor.model;
using RibbonsColor.solution.visiblecolor;
using RibbonsColorRecursive.solution.visiblecolor;
using System.Drawing;

namespace RibbonsColor.solution
{
    public class ColorFinder : IColorFinder
    {
        private List<Color> colors = new();
        private IVisibleColorFinder visibleColorFinder;
        private IVisibleColorFinderNonRecursive visibleColorFinderNonRecursive;

        public List<Color> FindColors(AlgorythmKind algorythm, List<IRibbonModel> ribbons, long fromPos, long toPos)
        {
            switch (algorythm)  {
                case AlgorythmKind.RECURSIVE:
                    {
                        visibleColorFinder = new VisibleColorFinder();
                        break;
                    }
                case AlgorythmKind.NON_RECURSIVE:
                    {
                        visibleColorFinderNonRecursive = new VisibleColorFinderNonRecursive();
                        break;
                    }
            }
            
            visibleColorFinderNonRecursive = new VisibleColorFinderNonRecursive();
            for (long pos = fromPos; pos < toPos; pos++)
            {
                Color foundColor;
                switch (algorythm)
                {
                    case AlgorythmKind.RECURSIVE:
                        {
                            int level = ribbons.Count - 1;
                            foundColor = visibleColorFinder.FindVisibleColor(pos, ribbons, ref level);
                            colors.Add(foundColor);
                            break;
                        }
                    case AlgorythmKind.NON_RECURSIVE:
                        {
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
