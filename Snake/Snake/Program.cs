using System;
using System.Threading;
using System.Collections.Generic;

namespace Snake
{
    class MainClass
    {
        static void Main(string[] args)
        {
            HorizontalLine upLine   = new HorizontalLine(0, 75, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 75, 22, '+');
            VerticalLine leftLine   = new VerticalLine(0, 22, 0, '+');
            VerticalLine rightLine  = new VerticalLine(0, 22, 75, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(75, 22, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
        }
    }
}
