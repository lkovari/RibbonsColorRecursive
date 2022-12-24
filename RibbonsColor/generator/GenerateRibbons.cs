using RibbonsColor.generator.ribon;
using RibbonsColor.generator.ribon.color;
using RibbonsColor.model;
using System.Drawing;

namespace RibbonsColor.generator
{
    public class GenerateRibbons : IGenerateRibbons
    {
        private readonly uint RIBBON_COUNT = 5;
        private List<IRibbonModel> ribbons = new();

        public List<IRibbonModel> Generate(long maxHoles)
        {
            List<Color> generatedColors = new List<Color>();

            IGenerateRibbon generateRibbon = new GenerateRibbon();

            IGenerateColor generateColor = new GenerateColor();

            Random random = new();
            for (int ix = 0; ix < RIBBON_COUNT; ix++)
            {
                Color color = generateColor.Generate(random);
                while (generatedColors.Contains(color))
                {
                    color = generateColor.Generate(random);
                }

                IRibbonModel ribbonModel = generateRibbon.Generate(color, maxHoles, ix == 0);
                ribbons.Add(ribbonModel);
            }
            return ribbons;
        }
    }
}
