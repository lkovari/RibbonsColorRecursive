using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonsColor.model
{
    public interface IRibbonModel {
        public Color RibbonColor { get; set; }
        public Dictionary<int, bool> HolePositions { get; set; }
    }
}
