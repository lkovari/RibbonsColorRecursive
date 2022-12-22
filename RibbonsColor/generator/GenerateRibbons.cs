using RibbonsColor.generator.ribon;
using RibbonsColor.generator.ribon.color;
using RibbonsColor.model;
using System.Drawing;

namespace RibbonsColor.generator
{
    public class GenerateRibbons : IGenerateRibbons
    {
        private List<IRibbonModel> ribbons = new();

        public List<IRibbonModel> Generate(long maxHoles)
        {
            Random random = new();
            
            List<Color> generatedColors = new List<Color>();

            IGenerateRibbon generateRibbon = new GenerateRibbon();
            
            IGenerateColor generateColor = new GenerateColor();
            
            for (int ix = 0; ix < 5; ix++)
            {
                Color color = generateColor.Generate();
                while (generatedColors.Contains(color)) {
                    color = generateColor.Generate();
                }
                
                IRibbonModel ribbonModel = generateRibbon.Generate(color, maxHoles, ix == 0);
                ribbons.Add(ribbonModel);
            }
            return ribbons;
        }
    }
}
