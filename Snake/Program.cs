using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            Vert VertL = new Vert(0, 24, 0, "*");
            VertL.Draw();

            Gor GorD = new Gor(0, 78, 24, "*");
            GorD.Draw();

            Vert VertR = new Vert(0, 24, 78, "*");
            VertR.Draw();

            Gor GorUp = new Gor(0, 78, 0, "*");
            GorUp.Draw();

            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, "+");

            //Vert vl = new Vert(0, 10, 5, "%");
            //Draw(vl);

            //Point p = new Point(4, 5, "*");
            //Figure fsnake = new Snake(p, 4, Direction.right);
            //Draw(fsnake);

            //Snake snake = (Snake)fsnake;

            //Gor gl = new Gor(0, 5, 6, "#");
            //Draw(gl);

            //List<Figure> figures = new List<Figure>();
            //figures.Add(fsnake);
            //figures.Add(vl);
            //figures.Add(gl);

            //foreach(var f in figures)
            //{
            //    f.Draw();
            //}


            Snake snake = new Snake(p, 4, Direction.right);
            snake.Draw();


            Food FoodCreator = new Food(80, 25, "$");
            Point food = FoodCreator.CreateFood();
            food.Draw(ConsoleColor.Black);


            tttt tttt = new tttt(0);

            while (true)
            {
                int a = 0;
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {

                    food = FoodCreator.CreateFood();
                    food.Draw(ConsoleColor.Red);

                }
                
                else
                {
                    snake.move();
                }
                
                Thread.Sleep(100);
                
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.handl(key.Key);
                }
            }

            WriteScore();
            Console.ReadLine();
        }

        static void Draw(Figure figure)
        {
            figure.Draw();
        }


        static void WriteScore()
        {
            
            int x = 25;
            int y = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x, y++);
            WriteText("============================", x, y++);
            WriteText("И Г Р А   О К О Н Ч Е Н А", x + 1, y++);
            //WriteText("    В А Ш   С Ч Ё Т", x + 1, y++);
            //WriteText1(pList.Count, x + 2, y++);
            y++;
            WriteText("Автор: Иван Боровиков ", x + 3, y++);
            
            WriteText("============================", x, y++);

        }

        static void WriteText(String text, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
        }

        static void WriteText1( int text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}


