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

            Thread.Sleep(2000);
            eA.LetTheGamesBegin();
            Thread.Sleep(2000);
            eA.Noob();
            Thread.Sleep(2000);
            eA.EasyPeasy();
            Thread.Sleep(2000);
            eA.ForAzeroth();
            Thread.Sleep(2000);
            eA.Frostmourne();
            Thread.Sleep(2000);
            eA.GeeGee();
            Thread.Sleep(5000);
        }
    }
}
