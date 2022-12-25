using System.Drawing;

namespace RibbonsColor.generator.ribon.color
{
    public interface IGenerateColor
    {
        public KnownColor Generate(Random random);
    }
}
