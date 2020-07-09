using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> walllist;
        public Walls(int mapW, int mapH)
        {
            walllist = new List<Figure>();
            Vert VertL = new Vert(0, mapH -1, 0, "*");
            Gor GorD = new Gor(0, mapW -2, mapH -1, "*");
            Vert VertR = new Vert(0, mapH -1, mapW -2, "*");
            Gor GorUp = new Gor(0, mapW -2, 0, "*");

            walllist.Add(VertL);
            walllist.Add(VertR);
            walllist.Add(GorUp);
            walllist.Add(GorD);

            }
        internal bool IsHit(Figure figure)
        {
            foreach(var wall in walllist)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
                      
        }
        public void Draw()
        {
        
        foreach (var wall in walllist)
            {
                wall.Draw();
            }
        }
    }
}
