using RibbonsColor.model;
using System.Drawing;

namespace RibbonsColor.generator.ribon
{
    public interface IGenerateRibbon
    {
        IRibbonModel Generate(Color color, long maxHoles, bool noHole);
    }
}
