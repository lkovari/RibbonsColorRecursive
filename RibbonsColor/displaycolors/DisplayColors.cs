using System.Drawing;

namespace RibbonsColor.displaycolors
{
    public class DisplayColors : IDisplayColors
    {
        public void DisplayColorName(List<Color> colors)
        {
            Console.WriteLine();
            Console.WriteLine("Visible Colors");
            for (int ix = 0; ix < colors.Count; ix++)
            {
                Color color = colors.ElementAt<Color>(ix);
                string comma = (ix < colors.Count - 1) ? ", " : "";
                string colorName = color.Name + comma;
                Console.Write(colorName);
            }
            Console.WriteLine();
        }
    }
}
