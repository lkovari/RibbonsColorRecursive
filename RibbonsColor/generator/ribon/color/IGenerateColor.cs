using System.Drawing;

namespace RibbonsColor.generator.ribon.color
{
    public interface IGenerateColor
    {
        public KnownColor GenerateRibbonColor(Random random);
    }
}
