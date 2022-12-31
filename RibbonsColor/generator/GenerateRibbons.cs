﻿using RibbonsColor.generator.ribon;
using RibbonsColor.generator.ribon.color;
using RibbonsColor.model;
using System.Drawing;

namespace RibbonsColor.generator
{
    public class GenerateRibbons : IGenerateRibbons
    {
        private List<IRibbonModel> ribbons = new();

        public List<IRibbonModel> Generate(long maxHoles, byte ribbonsCount)
        {
            List<KnownColor> generatedColors = new List<KnownColor>();

            IGenerateRibbon generateRibbon = new GenerateRibbon();

            IGenerateColor generateColor = new GenerateColor();

            Random random = new();
            for (int ix = 0; ix < ribbonsCount; ix++)
            {
                KnownColor color = generateColor.Generate(random);
                while (generatedColors.Contains(color))
                {
                    color = generateColor.Generate(random);
                }
                generatedColors.Add(color);

                IRibbonModel ribbonModel = generateRibbon.Generate(color, maxHoles, ix == 0);
                ribbons.Add(ribbonModel);
            }
            return ribbons;
        }
    }
}
