using System;
using System.Threading;

namespace Algoritmia
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Initialization
            ExerciciosAlgoritmia eA = new ExerciciosAlgoritmia();
            Console.WriteLine("Hello World!");
            Thread.Sleep(3000);
            Console.Clear();
            #endregion

            // Escreva aqui o primeiro programa a ser executado:


            #region Let The Games Begin
            eA.LetTheGamesBegin();
            Console.WriteLine("");
            #endregion

            #region Noob
            Thread.Sleep(2000);
            eA.Noob();
            Console.WriteLine("");
            #endregion

            #region Easy Peasy
            Thread.Sleep(2000);
            eA.EasyPeasy();
            Console.WriteLine("");
            #endregion

            #region For Azeroth
            Thread.Sleep(3000);
            Console.Clear();
            eA.ForAzeroth();
            Console.WriteLine("");
            #endregion

            #region Frostmourne
            Thread.Sleep(2000);
            eA.Frostmourne();
            Console.WriteLine("");
            #endregion

            #region Gee Gee
            Thread.Sleep(2000);
            eA.GeeGee();
            Console.WriteLine("");
            #endregion

            #region 
            Thread.Sleep(2000);
            eA.LuckyBastard();
            Console.WriteLine("");
            #endregion

            #region Vegito
            Thread.Sleep(3000);
            Console.Clear();
            eA.Vegito();
            Console.WriteLine("");
            #endregion

            #region Let's Get Pumped
            Thread.Sleep(2000);
            eA.LetsGetPumped();
            Console.WriteLine("");
            #endregion

            #region Roll
            Thread.Sleep(2000);
            eA.Roll();
            Console.WriteLine("");
            #endregion

            #region Lost in the Map
            Thread.Sleep(2000);
            eA.LostintheMap();
            Console.WriteLine("");
            #endregion

            #region Time Over
            Thread.Sleep(3000);
            Console.Clear();
            eA.TimeOver();
            Console.WriteLine("");
            #endregion

            #region Even
            Thread.Sleep(2000);
            eA.Even();
            Console.WriteLine("");
            #endregion

            #region Keep Randomizing
            Thread.Sleep(2000);
            eA.KeepRandomizing();
            Console.WriteLine("");
            #endregion

            #region Between Walls
            Thread.Sleep(2000);
            eA.BetweenWalls();
            Console.WriteLine("");
            #endregion

            #region Lets Move
            Thread.Sleep(3000);
            Console.Clear();
            eA.LetsMove();
            Console.WriteLine("");
            #endregion

        }
    }
}
