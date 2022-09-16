using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joguinho_da_bolinha
{   
    internal class World
    {
        public List<Entity> Entities = new List<Entity>();

        public void Draw(Graphics g)
        {
            foreach (var e in Entities)
            {
                e.PositionX += e.DX / 50;
                e.PositionY += e.DY / 50;
                e.DY += 9.8 / 50;
                e.Draw(g);
            }
        }

    }
}
