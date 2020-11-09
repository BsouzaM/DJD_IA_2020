using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace Algoritmia
{
    public class Tarefas
    {
        public void TPC01() // Given a group with N students, I want to know how many students have an average between 15 and 20 and which was the best average.
        {
            Random r = new Random();
            int student = 25;
            int studentID = 0;

            int score1 = 1;
            int score2 = score1;
            int average = 0;
            int average2 = 0;

            for (int i = 1; i < student; i++)
            {
                score1 = r.Next(0, 21);
                score2 = r.Next(0, 21);
                average2 = (score1 + score2) / 2;
                studentID = r.Next(1, 25);

                if (average2 >= 15 && average2 <= 20)
                {
                    Console.WriteLine("Student Nº: " + studentID + "\nScore: " + average2);
                    Console.WriteLine("Is above average!");
                    Console.WriteLine("==========");
                }
                else
                {
                    Console.WriteLine("Student Nº: " + studentID + "\nScore: " + average2);
                    Console.WriteLine("Is below average!!");
                    Console.WriteLine("==========");
                }

                if (average < average2)
                    average = average2;
            }
            Console.WriteLine("The average is: " + average);
            Console.ReadKey();
        }
        // dado n numeros quero descobrir quais desses números são primos
        public void NumerosPrimos()
        {
            Random r = new Random();
            int n = r.Next(1, 51);
            int checker = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    checker++;
            }
            if (checker == 2)
                Console.WriteLine("O número {0} é primo", n);
            else
                Console.WriteLine("O número {0} não é primo", n);
        }
        // 2 Dice Rolls e se os números forem iguais, o programa termina.
        public void BrackeysExercise_WhileLoop()
        {
            Random r = new Random();

            Console.WriteLine("Watch as the computer slowly roll the dices for you (:");

            int roll1 = 0;
            int roll2 = 0;

            int attempts = 0;

            // O || é utilizado para a diferença. 
            // Roll 1 deve ser igual a Roll 2.
            while (roll1 != 1 || roll2 != 1)
            {
                Thread.Sleep(1000);

                roll1 = r.Next(1, 100);
                roll2 = r.Next(1, 100);

                Console.WriteLine("Roll 1: " + roll1);
                Console.WriteLine("Roll 2: " + roll2);
                
                Console.WriteLine("");

                attempts++;
                
                if (roll1 == roll2)
                    break;
            }
            Console.WriteLine("The computer tried " + attempts + " times until both numbers were equal!");
            Console.WriteLine("");
        }
    }
}
