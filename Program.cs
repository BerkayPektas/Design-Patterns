﻿namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler chocolateBoiler = ChocolateBoiler.GetInstance();
        }
    }
}