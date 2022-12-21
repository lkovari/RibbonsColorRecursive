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
        public List<byte> HolePositions { get; set; }

        public RibbonModel(Color color, List<byte> holes)
        {
            this.RibbonColor = color;
            this.HolePositions = holes;
        }
    }
}
