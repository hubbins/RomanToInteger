﻿using System;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            //s.RomanToInt("V");
            Console.WriteLine("Converting XIV to " + s.RomanToInt("XIV"));
        }
    }
}
