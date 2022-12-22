using RibbonsColor.generator.holes;
using RibbonsColor.model;
using System.Drawing;

namespace RibbonsColor.generator.ribon
{
    public class GenerateRibbon : IGenerateRibbon
    {
        public IRibbonModel Generate(Color color, long maxHoles, bool noHole)
        {
            IGenerateHoles? holeGenerator;
            IRibbonModel ribbonModel = new RibbonModel();
            ribbonModel.HolesCount = maxHoles;
            ribbonModel.RibbonColor = color;

            holeGenerator = new GenerateHoles(ribbonModel);
            holeGenerator.Generate(noHole);

            return ribbonModel;
        }
    }
}
