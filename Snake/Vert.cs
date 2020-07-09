using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Vert : Figure
    {       

        public Vert(int yL, int yR, int x, string sum)
        {
            pList = new List<Point>();
            for (int y = yL; y <= yR; y++)
            {
                Point p = new Point(x, y, sum);
                pList.Add(p);
            }

        }

       

    }
}
