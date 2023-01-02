using RibbonsColor.generator.holes;
using RibbonsColor.model;
using System.Drawing;

namespace RibbonsColor.generator.ribon
{
    public class GenerateRibbon : IGenerateRibbon
    {
        public IRibbonModel GenerateARibbon(KnownColor color, long maxHoles, bool noHole)
        {
            IGenerateHoles? holeGenerator;
            IRibbonModel ribbonModel = new RibbonModel
            {
                HolesCount = maxHoles,
                RibbonColor = color
            };

            holeGenerator = new GenerateHoles(ribbonModel);
            holeGenerator.GenerateRibbonHoles(noHole, true);

            return ribbonModel;
        }
    }
}
