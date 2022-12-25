
using System.Drawing;

namespace RibbonsColor.generator.ribon.color
{
    public class GenerateColor : IGenerateColor
    {
        KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));

        public KnownColor Generate(Random random)
        {
            return names[random.Next(names.Length)];
        }
    }
}
