using System.Drawing;

namespace RibbonsColor.model
{
    public interface IRibbonModel {
        public Color RibbonColor { get; set; }
        public byte[] HolePositions { get; set; }
        public long HolesCount { get; set; }
        public long CalculateArraySize();
        public bool HasHoleAtPosition(long pos);
        public void SetHoleAtPosition(long pos, bool hole);
        public long CalculateByteIndexByPos(long pos);
        public int CalculateBitIndexByPos(long pos);
    }
}
