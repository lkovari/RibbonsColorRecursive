using RibbonsColor.model;

namespace RibbonsColor.generator.holes
{
    public class GenerateHoles : IGenerateHoles
    {
        private IRibbonModel ribbonModel;
        private long arraySize = 0;
        
        public GenerateHoles(IRibbonModel ribbon, long arrSize)
        {
            ribbonModel = ribbon;
            arraySize = arrSize;
        }
        public void Generate(bool noHole, bool optimizedFill)
        {
            ribbonModel.HolePositions = new byte[arraySize];
            var random = new Random();
            if (optimizedFill)
            {
                for (int ix = 0; ix < ribbonModel.HolePositions.Length; ix++)
                {
                    ribbonModel.HolePositions[ix] = (byte)random.Next(0xff);
                }
            } else
            {
                for (int ix = 0; ix < ribbonModel.HolesCount; ix++)
                {
                    if (noHole)
                    {
                        ribbonModel.SetHoleAtPosition(ix, !noHole);
                    }
                    else
                    {
                        ribbonModel.SetHoleAtPosition(ix, (bool)(random.Next(10) > 3 ? true : false));
                    }
                }
            }
        }
    }
}
