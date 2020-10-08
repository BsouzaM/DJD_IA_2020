using System;
using System.Threading;

namespace Algoritmia
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciciosAlgoritmia eA = new ExerciciosAlgoritmia();
            Console.WriteLine("Hello World!");

            eA.LuckyBastard();

            Thread.Sleep(2000);
            eA.LetTheGamesBegin();
            Console.WriteLine("");

            Thread.Sleep(2000);
            eA.Noob();
            Console.WriteLine("");

            Thread.Sleep(2000);
            eA.EasyPeasy();
            Console.WriteLine("");

            Thread.Sleep(2000);
            eA.ForAzeroth();
            Console.WriteLine("");

            Thread.Sleep(2000);
            eA.Frostmourne();
            Console.WriteLine("");

            Thread.Sleep(2000);
            eA.GeeGee();

            Thread.Sleep(5000);
        }
    }
}
