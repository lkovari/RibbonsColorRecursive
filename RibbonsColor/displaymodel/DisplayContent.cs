using RibbonsColor.model;

namespace RibbonsColor.displaymodel
{
    public class DisplayContent : IDisplayContent
    {
        public void displayModelContent(List<IRibbonModel> ribbons)
        {
            Console.WriteLine();
            Console.WriteLine(" Display Data");
            Console.WriteLine();
            byte maxColorNameLength = (byte)(ribbons.Max(item => item.RibbonColor.ToString().Length) + 2);
            for (int ix = ribbons.Count - 1; ix >= 0; ix--)
            {
                Console.Write($"  Ribbon {ix}. ");
                string colorName = ribbons[ix].RibbonColor.ToString();
                string paddedColorName = colorName.PadRight(maxColorNameLength);
                Console.Write($"Color: { paddedColorName } ");
                Console.Write("Holes: ");
                for (int ixh = 0; ixh < ribbons[ix].HolesCount; ixh++)
                {
                    byte hasHole = (byte)(ribbons[ix].HasHoleAtPosition(ixh) ? 1 : 0);
                    Console.Write($"{ hasHole } ");
                }
                Console.WriteLine();
            }
        }
    }
}
