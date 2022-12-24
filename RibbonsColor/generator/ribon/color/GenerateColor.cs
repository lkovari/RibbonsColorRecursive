
using System.Drawing;

namespace RibbonsColor.generator.ribon.color
{
    public class GenerateColor : IGenerateColor
    {
        public Color Generate(Random random)
        {
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[random.Next(names.Length)];
            return Color.FromKnownColor(randomColorName);
        }
    }
}
