
using System.Drawing;

namespace RibbonsColor.generator.ribon.color
{
    public class GenerateColor : IGenerateColor
    {
        public Color Generate()
        {
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            return Color.FromKnownColor(randomColorName);
        }
    }
}
