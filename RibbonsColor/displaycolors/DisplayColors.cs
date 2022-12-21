using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonsColor.displaycolors
{
    public class DisplayColors : IDisplayColors
    {
        public void DisplayColorName(List<Color> colors)
        {
            Console.WriteLine("Found Visible Colors");
            for (int ix = 0; ix < colors.Count; ix++)
            {
                Console.Write(colors[ix].Name + " ");
            }
            Console.WriteLine();
        }
    }
}
