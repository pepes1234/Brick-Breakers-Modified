﻿using System;
using System.Collections.Generic;   
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joguinho_da_bolinha
{
    internal abstract class Entity
    {
        public double Mass { get; set; }
        public double Class { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public double DX { get; set; }
        public double DY { get; set; }

        public abstract void Draw(Graphics g);
    }
}
