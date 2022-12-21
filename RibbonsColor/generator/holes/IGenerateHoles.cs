﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibbonsColor.generator.holes
{
    public interface IGenerateHoles
    {
        public Dictionary<int, bool> Generate(int maxHoles, bool noHole);
    }
}