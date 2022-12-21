using RibbonsColor.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonsColor.solution
{
    public interface IColorFinder
    {
        public List<Color> FindColors(List<IRibbonModel> ribbons, int fromPos, int toPos);
    }
}
