using RibbonsColor.model;

namespace RibbonsColor.generator
{
    public interface IGenerateRibbons
    {
        public List<IRibbonModel> GenerateAllRibbons(long maxHoles, byte ribbonsCount);
    }
}
