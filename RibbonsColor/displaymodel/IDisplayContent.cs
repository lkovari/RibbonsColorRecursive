using RibbonsColor.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonsColor.displaymodel
{
    public interface IDisplayContent
    {
        public void displayModel(List<IRibbonModel> ribbons);
    }
}
