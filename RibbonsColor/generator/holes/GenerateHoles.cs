using RibbonsColor.model;

namespace RibbonsColor.generator.holes
{
    public class GenerateHoles : IGenerateHoles
    {
        private IRibbonModel ribbonModel;

        public GenerateHoles(IRibbonModel ribbon)
        {
            ribbonModel = ribbon;
        }
        public void Generate(bool noHole)
        {
            ribbonModel.HolePositions = new byte[ribbonModel.CalculateArraySize()];
            var random = new Random();
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
