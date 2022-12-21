using RibbonsColor.generator.ribon;
using RibbonsColor.generator.ribon.color;
using RibbonsColor.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonsColor.generator
{
    public class GenerateRibbons : IGenerateRibbons
    {
        private List<IRibbonModel> ribbons = new();

        public List<IRibbonModel> Generate(int maxHoles)
        {
            Random random = new();
            
            List<Color> generatedColors = new List<Color>();

            IGenerateRibbon ribbonGenerator = new GenerateRibbon();
            
            IGenerateColor generateColor = new GenerateColor();
            
            for (int ix = 0; ix < 5; ix++)
            {
                Color color = generateColor.Generate();
                while (generatedColors.Contains(color)) {
                    color = generateColor.Generate();
                }
                
                IRibbonModel ribbonModel = ribbonGenerator.Generate(color, maxHoles, ix == 0);
                ribbons.Add(ribbonModel);
            }
            return ribbons;
        }
    }
}
