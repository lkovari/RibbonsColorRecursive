﻿using System.Drawing;

namespace RibbonsColor.model
{
    public class RibbonModel : IRibbonModel
    {
        public Color RibbonColor { get; set; }
        public byte[] HolePositions { get; set; }

        private readonly int BYTE_SIZE = 8;
        public long HolesCount { get; set; }

        public bool HasHoleAtPosition(long pos)
        {
            long byteIx = CalculateByteIndexByPos(pos);
            int bitPositionalNotation = CalculateBitIndexByPos(pos);
            byte bitMask = (byte)(2 >> bitPositionalNotation);

            return (HolePositions[byteIx] & bitMask) == bitMask;
        }

        public void SetHoleAtPosition(long pos, bool hole)
        {
            long byteIx = CalculateByteIndexByPos(pos);
            int bitPositionalNotation = CalculateBitIndexByPos(pos);
            byte bitMask = (byte)(2 >> bitPositionalNotation);
            if (hole)
            {
                HolePositions[byteIx] = (byte)(HolePositions[byteIx] | bitMask);
            }
            else
            {
                HolePositions[byteIx] = (byte)(HolePositions[byteIx] & (byte)~bitMask);
            }
        }

        public long CalculateArraySize()
        {
            // long remainder = HolesCount % BYTE_SIZE;
            long remainder = (HolesCount & (BYTE_SIZE - 1));
            long baseArraySize = remainder == 0 ? (HolesCount / BYTE_SIZE) : (HolesCount - remainder) / BYTE_SIZE;
            return remainder > 0 ? baseArraySize + 1 : baseArraySize;
        }

        public long CalculateByteIndexByPos(long pos)
        {
            return (pos - CalcMod(pos)) / BYTE_SIZE;
        }

        public byte CalculateBitIndexByPos(long pos)
        {
            //return (int)(pos % BYTE_SIZE);
            return CalcMod(pos);
        }

        public byte CalcMod(long pos)
        {
            return (byte)(pos & (BYTE_SIZE - 1));
        }
    }
}
