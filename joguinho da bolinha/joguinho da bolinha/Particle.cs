using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joguinho_da_bolinha
{
    internal class Particle : Entity
    {
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Blue, (float)(PositionX - Mass / 2), (float)(PositionY - Mass / 2), (float)Mass, (float)Mass);
            g.FillEllipse(Brushes.Red, (float)(PositionX - Mass / 2), (float)(PositionY - Mass / 2), (float)Mass, (float)Mass);
        }
    }
}
