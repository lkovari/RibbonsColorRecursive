using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RibbonsColor.model;

namespace RibbonsColor.model
{
    public class RibbonModel : IRibbonModel
    {
        public Color RibbonColor { get; set; }
        public Dictionary<int, bool> HolePositions { get; set; }

        public RibbonModel(Color color, Dictionary<int, bool> holes)
        {
            this.RibbonColor = color;
            this.HolePositions = holes;
        }
    }
}
