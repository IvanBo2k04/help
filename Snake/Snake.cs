
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Snake : Figure
	{
		public Direction direction;

		public Snake(Point tail, int length, Direction _direction)
		{
			direction = _direction;
			pList = new List<Point>();
			for (int i = 0; i < length; i++)
			{
				Point p = new Point(tail);
				p.Move(i, direction);
				pList.Add(p);
			}
		}

        internal void move()
        {
			Point tail = pList.First();
			pList.Remove(tail);
			Point head = GetNextPoint();
			pList.Add(head);

			tail.clear();
			head.Draw(ConsoleColor.Black);
        }
		public Point GetNextPoint()
		{
			Point head = pList.Last();
			Point nextPoint = new Point(head);
			nextPoint.Move(1, direction);
			return nextPoint;
		}
		public void handl(ConsoleKey key)
		{
			if (key == ConsoleKey.LeftArrow)
				direction = Direction.left;
			else if (key == ConsoleKey.RightArrow)
				direction = Direction.right;
			else if (key == ConsoleKey.UpArrow)
				direction = Direction.up;
			else if (key == ConsoleKey.DownArrow)
				direction = Direction.down;
		}
		internal bool Eat(Point Food)
		{
			Point head = GetNextPoint();
			if (head.IsHit(Food))
			{
				Food.sym = head.sym;
				pList.Add(Food);
				return true;
			}
			else
			{
				return false;
			}
		}
		internal bool IsHitTail()
		{
			var head = pList.Last();
			for(int i = 0; i < pList.Count - 2; i++)
			{
				if (head.IsHit(pList[i]))
				{
					return true;
				}
			}
			return false;
		}
	}
}
