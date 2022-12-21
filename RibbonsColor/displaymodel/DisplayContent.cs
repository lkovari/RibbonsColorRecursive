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
            Console.WriteLine();
            for (int ix = 0; ix < ribbons.Count; ix++)
            {
                Console.Write($"Ribbon { ix }. ");
                Console.WriteLine($"Color { ribbons.ElementAt<IRibbonModel>(ix).RibbonColor.Name}");
                Console.Write("Holes ");
                for (int ixh = 0; ixh < ribbons[ix].HolePositions.Count; ixh++)
                {
                    byte hasHole = ribbons.ElementAt<IRibbonModel>(ix).HolePositions.ElementAt<byte>(ixh);
                    Console.Write($"{ hasHole } ");
                }
                Console.WriteLine();
            }
        }
    }
}
