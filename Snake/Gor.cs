using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Gor : Figure
    {       

        public Gor(int xL, int xR, int y, string sum)
        {
            pList = new List<Point>();
            for (int x = xL; x <= xR; x++)
            {
                Point p = new Point(x, y, sum);
                pList.Add(p);
            }

        }
        

    }
}
