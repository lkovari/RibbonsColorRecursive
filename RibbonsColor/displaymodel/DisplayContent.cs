using RibbonsColor.model;

namespace RibbonsColor.displaymodel
{
    public class DisplayContent : IDisplayContent
    {
        public void displayModel(List<IRibbonModel> ribbons)
        {
            Console.WriteLine();
            for (int ix = 0; ix < ribbons.Count; ix++)
            {
                Console.Write($"Ribbon {ix}. ");
                Console.WriteLine($"Color {ribbons[ix].RibbonColor.Name}");
                Console.Write("Holes ");
                for (int ixh = 0; ixh < ribbons[ix].HolesCount; ixh++)
                {
                    bool hasHole = ribbons[ix].HasHoleAtPosition(ixh);
                    Console.Write($"{hasHole} ");
                }
                Console.WriteLine();
            }
        }
    }
}
