using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonsColor.generator.holes
{
    public class GenerateHoles : IGenerateHoles
    {
        public List<byte> Generate(int maxHoles, bool noHole)
        {
            List<byte> holes = new();
            var random = new Random();
            for (int ix = 0; ix < maxHoles; ix++)
            {
                if (noHole)
                {
                    holes.Add(0);
                }
                else
                {
                    holes.Add((byte)(random.Next(10) > 3 ? 1 : 0));
                }
            }
            return holes;
        }
    }
}
