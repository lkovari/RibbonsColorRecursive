using RibbonsColor.model;

namespace RibbonsColor.generator
{
    public interface IGenerateRibbons
    {
        public List<IRibbonModel> Generate(long maxHoles);
    }
}
