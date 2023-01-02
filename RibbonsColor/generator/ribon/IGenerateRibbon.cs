using RibbonsColor.model;
using System.Drawing;

namespace RibbonsColor.generator.ribon
{
    public interface IGenerateRibbon
    {
        IRibbonModel GenerateARibbon(KnownColor color, long maxHoles, bool noHole);
    }
}
