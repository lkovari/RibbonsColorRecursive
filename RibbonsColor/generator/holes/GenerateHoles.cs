using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonsColor.generator.holes
{
    public class GenerateHoles : IGenerateHoles
    {
        private Dictionary<int, bool> holes;
        public GenerateHoles()
        {
            holes = new Dictionary<int, bool>();
        }

        public Dictionary<int, bool> Generate(int maxHoles, bool noHole)
        {
            var random = new Random();
            for (int ix = 0; ix < maxHoles; ix++)
            {
                if (noHole)
                {
                    holes.Add(ix, false);
                } else
                {
                    holes.Add(ix, random.Next(10) > 3 ? true : false);
                }
            }
            random = null;
            return holes;
        }
    }
}
