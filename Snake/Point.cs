
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Point
	{
		public int x;
		public int y;
		public String sym;

		public Point()
		{
		}

		public Point(int _x, int _y, String _sym)
		{
			x = _x;
			y = _y;
			sym = _sym;
		}

		public Point(Point p)
		{
			x = p.x;
			y = p.y;
			sym = p.sym;
		}

		public Point(int v1, int v2, char v3)
		{
		}

		public void clear()
		{
			sym = " ";
			Draw(ConsoleColor.Black);
		}

		public void Move(int offset, Direction direction)
		{
			if (direction == Direction.right)
			{
				x = x + offset;
			}
			else if (direction == Direction.left)
			{
				x = x - offset;
			}
			else if (direction == Direction.up)
			{
				y = y - offset;
			}
			else if (direction == Direction.down)
			{
				y = y + offset;
			}
		}

		public void Draw(ConsoleColor black)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}

		

		public override string ToString()
		{
			return x + ", " + y + ", " + sym;
		}
		public bool IsHit(Point p)
		{
			return p.x == this.x && p.y == this.y;
		}
	}
}

