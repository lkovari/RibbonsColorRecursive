using RibbonsColor.model;
using RibbonsColor.solution.visiblecolor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonsColor.solution
{
    public class ColorFinder : IColorFinder
    {
        private readonly List<Color> colors;
        private VisibleColorFinder? visibleColorFinder;

        public ColorFinder()
        {
            colors = new List<Color>();
        }

        public List<Color> FindColors(List<IRibbonModel> ribbons, int fromPos, int toPos)
        {
            visibleColorFinder = new VisibleColorFinder();
            try
            {
                for (int pos = fromPos; pos < toPos; pos++)
                {
                    int level = ribbons.Count - 1;
                    Color foundColor = visibleColorFinder.FindVisibleColor(pos, ribbons, ref level);
                    colors.Add(foundColor);
                }
            }
            finally
            {
                visibleColorFinder = null;
            }
            return colors;
        }
    }
}
