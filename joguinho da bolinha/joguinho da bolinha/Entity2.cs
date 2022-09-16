using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace joguinho_da_bolinha
{
    internal abstract class Entity2
    {
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public double Dx { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }

        public abstract void Draw(Graphics g);
    }
}
