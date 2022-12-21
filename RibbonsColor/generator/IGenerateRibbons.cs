using RibbonsColor.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonsColor.generator
{
    public interface IGenerateRibbons
    {
        public List<IRibbonModel> Generate(int maxHoles);
    }
}
