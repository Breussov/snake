﻿using System;
using System.Collections.Generic;

namespace Snake
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 2, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(5,10,8,'+');
            line.Draw();

        }
    }
}
