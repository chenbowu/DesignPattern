﻿using DesignPattern.Builder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.PhoneParts
{
    internal class IntelCPU : ICPU
    {
        public string Type { get; set; } = "IntelCPU";
    }
}
