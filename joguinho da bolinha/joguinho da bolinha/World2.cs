using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joguinho_da_bolinha
{
    internal class World2
    {
        public List<Entity2> Entities2 = new List<Entity2>();

        public void Draw(System.Drawing.Graphics g)
        {
            foreach (var e in Entities2)
            {
                e.PositionX += 0;
                e.Draw(g);
            }
        }
    }
}
