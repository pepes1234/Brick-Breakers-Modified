using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joguinho_da_bolinha
{
    internal class Particle2 : Entity2
    {
        public override void Draw(Graphics g)
        {
            Pen pen1 = new Pen(Color.Black, 8);

            g.DrawRectangle(pen1, (float)PositionX, (float)PositionY, (float)Largura, (float)Altura);
            g.FillRectangle(Brushes.LightGray, (float)PositionX, (float)PositionY, (float)Largura, (float)Altura);
        }
    }
}
