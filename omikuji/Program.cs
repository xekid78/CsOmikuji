﻿using System;

namespace Omikuji
{
    class Omikuji
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var omikuji = rand.Next(1, 6);

            if (omikuji == 1)
            {
                Console.WriteLine("大吉");
            }
            else if (omikuji == 2)
            {
                Console.WriteLine("中吉");
            }
            else if (omikuji == 3)
            {
                Console.WriteLine("小吉");
            }
            else if (omikuji == 4)
            {
                Console.WriteLine("吉");
            }
            else if (omikuji == 5)
            {
                Console.WriteLine("凶");
            }
            else
            {
                Console.WriteLine("大凶");
            }
        }
    }
}
