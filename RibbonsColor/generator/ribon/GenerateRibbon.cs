using RibbonsColor.generator.holes;
using RibbonsColor.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonsColor.generator.ribon
{
    public class GenerateRibbon : IGenerateRibbon
    {
        public IRibbonModel Generate(Color color, int maxHoles, bool noHole)
        {
            List<byte> holes = new();
            IGenerateHoles? holeGenerator;
            IRibbonModel ribbnModel = new RibbonModel(color, holes);
            try
            {
                holeGenerator = new GenerateHoles();
                holes = holeGenerator.Generate(maxHoles, noHole);
                ribbnModel.HolePositions = holes;
            }
            finally
            {
                holeGenerator = null;
            }
            return ribbnModel;
        }
    }
}
