using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food
    {
        int mapw;
        int maph;
        string sym;

        Random random = new Random();

        public Food(int mapw, int maph, string sym)
        {
            this.maph = maph;
            this.mapw = mapw;
            this.sym = sym;
        }
        public Point CreateFood()
        {
            int x = random.Next(2, mapw - 2);
            int y = random.Next(2, maph - 2);
            return new Point(x, y, sym);
        }
    }
}
