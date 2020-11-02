using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace Algoritmia
{
    public class TarefasParaCasa
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
    }
}
