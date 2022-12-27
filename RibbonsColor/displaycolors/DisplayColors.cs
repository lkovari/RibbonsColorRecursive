using System.Drawing;

namespace RibbonsColor.displaycolors
{
    public class DisplayColors : IDisplayColors
    {
        KnownColor[] knownColors = (KnownColor[])Enum.GetValues(typeof(KnownColor));

        public void DisplayColorName(List<KnownColor> knowColors)
        {
            Console.WriteLine();
            Console.WriteLine("Visible Colors");
            for (int ix = 0; ix < knowColors.Count; ix++)
            {
                Console.WriteLine($" { ix } Color: { knowColors[ix] }");
            }
            Console.WriteLine();
        }
    }
}
