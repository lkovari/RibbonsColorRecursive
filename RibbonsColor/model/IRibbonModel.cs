using System.Drawing;

namespace RibbonsColor.model
{
    public interface IRibbonModel
    {
        public Color RibbonColor { get; set; }
        public byte[] HolePositions { get; set; }
        public long HolesCount { get; set; }
        public byte CalcMod(long pos);
        public long CalculateArraySize();
        public bool HasHoleAtPosition(long pos);
        public void SetHoleAtPosition(long pos, bool hole);
        public long CalculateByteIndexByPos(long pos);
        public byte CalculateBitIndexByPos(long pos);
        public byte FasterPow(byte exp);
    }
}
