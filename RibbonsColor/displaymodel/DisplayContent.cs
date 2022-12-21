using RibbonsColor.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonsColor.displaymodel
{
    public class DisplayContent : IDisplayContent
    {
        public void displayModel(List<IRibbonModel> ribbons)
        {
            for (int ix = 0; ix < ribbons.Count; ix++)
            {
                Console.WriteLine($"Ribbon { ix }");
                Console.WriteLine($"Color { ribbons[ix].RibbonColor.Name}");
                Console.WriteLine("Holes");
                for (int ixh = 0; ixh < ribbons[ix].HolePositions.Count; ixh++)
                {
                    bool hasHole = ribbons[ix].HolePositions[ixh];
                    Console.Write($"{ hasHole } ");
                }
                Console.WriteLine();
            }
        }
    }
}
