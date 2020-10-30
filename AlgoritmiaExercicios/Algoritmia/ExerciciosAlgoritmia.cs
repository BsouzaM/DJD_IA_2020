﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO.Pipes;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Algoritmia
{
    public class ExerciciosAlgoritmia
    {
        public void LetTheGamesBegin()
        {
            Console.WriteLine("Game Started");
            Console.WriteLine("Game Playing");
            Console.WriteLine("Game Over");
        }

        public void Noob()
        {
            string player = "#Fiinz";
            Console.WriteLine("You're such a Noob {0}! It's always good to have newbies around here!", player);
        }

        public void EasyPeasy()
        {
            int lives = 3;
            Console.WriteLine("You have {0} lives, use them wisely", lives);
        }

        public void ForAzeroth()
        {
            string nickname, race, faction, theClass;
            int level;
            char gender;

            nickname = "Player";
            race = "Gnome";
            faction = "Horde";
            theClass = "Mage";
            level = 60;
            gender = 'M';

            Console.WriteLine("Nickname: {0}\n " +
                "Level: {1}\n " +
                "Race: {2}\n " +
                "Gender: {3}\n " +
                "Faction: {4}\n " +
                "Class: {5}", nickname, level, race, gender, faction, theClass);
        }

        public void Frostmourne()
        {
            string name, rarity, description, targetClass;
            bool isTwoHand = true;
            int damage = 35000;
            name = "Frostmourne";
            rarity = "Legendary";
            description = "Hail to the king, baby!";
            targetClass = "Death Knight";

            Console.WriteLine("Weapon Name: {0}\n " +
                "Rarity: {1}\n " +
                "Description: {2}\n " +
                "Target Class: {3}\n " +
                "Is this weapon Two-Hand? {4}\n " +
                "Damage: {5}", name, rarity, description, targetClass, isTwoHand, damage);
        }

        public void GeeGee()
        {
            int player = 100;
            int fatalBlow = player;

            Console.WriteLine("Player Health: {0}", player);
            Console.WriteLine("A wild monster appeared!");
            Console.WriteLine("As you try to attack the monster, you got stun for 30 seconds!");
            player = player - fatalBlow;
            Console.WriteLine("Your player got a Face Slap! HP: {0}", player);
            Console.WriteLine("You are dead!");
        }
        public void LuckyBastard()
        {
            Random r = new Random();
            int hp = 100;

            int dmg = r.Next(1, hp - 3);
            Console.WriteLine("Damage: {0}", dmg);
            hp = hp - dmg;
            Console.WriteLine("HP: {0}", hp);

            dmg = r.Next(1, hp - 2);
            Console.WriteLine("Damage: {0}", dmg);
            hp = hp - dmg;
            Console.WriteLine("HP: {0}", hp);

            dmg = hp - 1;
            Console.WriteLine("Damage: {0}", dmg);
            hp = hp - dmg;
            Console.WriteLine("HP: {0}", hp);

            Console.WriteLine("Lucky Bastard!");
        }
        public void Vegito()
        {
            Random r = new Random();
            int cAverageAtk, cAverageDef, cAverageInt;

            cAverageAtk = (r.Next(1, 100) + r.Next(1, 351)) / 2;
            cAverageDef = (r.Next(1, 100) + r.Next(1, 156)) / 2;
            cAverageInt = (r.Next(1, 1001) + r.Next(1, 851)) / 2;

            Console.WriteLine("Average of Attack: {0}\n" +
                "Average of Defense: {1}\n" +
                "Average of Intellect: {2}", cAverageAtk, cAverageDef, cAverageInt);
        }
        public void LetsGetPumped()
        {
            Random r = new Random();
            float attackPower = r.Next(1, 2000);
            float powerUp = 1.5f; // 50% de X == 1.5

            attackPower = attackPower * powerUp; // Adiciona 50%
            Console.WriteLine("Your attack power using the Power UP is: {0}", attackPower);

            attackPower = attackPower / powerUp; // Remove 50%
            Console.WriteLine("Your attack power without using the Power UP is: {0}", attackPower);
        }
        public void Roll()
        {
            Random r = new Random();
            int p1 = r.Next(1, 7);
            int p2 = r.Next(1, 7);
            Console.WriteLine("Roll Player 1: {0}" +
                "\nRoll Player 2: {1}", p1, p2);

            if (p1 > p2) Console.WriteLine("Maior Roll é o P1: {0}", p1);
            else Console.WriteLine("Maior Roll é o P2: {0}", p2);
        }
        public void LostintheMap()
        // 0 == canto superior esquerdo
        // BUGGED
        {
            Random r = new Random();
            int xp1 = r.Next(1, 501);
            Console.WriteLine("Player 1 - X Position: {0}", xp1);

            int yp1 = r.Next(1, 501);
            Console.WriteLine("Player 1 - Y Position: {0}", yp1);

            if (xp1 > 250)
            {
                if (yp1 > 250)
                    Console.WriteLine("The position of the character is on the Top - Right side of the map");
                else if (yp1 < 250)
                    Console.WriteLine("The position of the character is on the Bottom - Right side of the map");
            }

            else if (xp1 < 250)
            {
                if (yp1 < 250)
                    Console.WriteLine("The position of the character is on the Bottom - Left side of the map");
                else if (yp1 > 250)
                    Console.WriteLine("The position of the character is on the Top - Left side of the map");
            }

            Console.WriteLine();
        }
        public void TimeOver()
        {
            for (int i = 99; i >= 0; i -= 1)
            {
                Console.WriteLine("{0}", i);
                if (i == 0)
                {
                    Console.WriteLine("Game Over");
                }
            }
        }

        public void Even()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void KeepRandomizing()
        {
            Random r = new Random();
            int n = r.Next(0, 100);

            for (int i = 0; i < n; i++)
            {
                int coordX = r.Next(0, 100);
                int coordY = r.Next(0, 100);
                Console.WriteLine("Coordenada X: " + coordX);
                Console.WriteLine("Coordenada Y: " + coordY);
            }
        }

        public void BetweenWalls()
        {
            Random r = new Random();

            int a = r.Next(1);
            int b = r.Next(a, 100);

            for (int i = a; i <= b; i++)
            {
                Console.WriteLine("Os valores entre {0} e {1} são: {2}", a, b, i);
            }
        }

        public void LetsMove()
        {
            Random r = new Random();
            TileManagement t = new TileManagement();

            int mapValueX, mapValueY;
            ConsoleKeyInfo targetPos;

            // Caso seja o utilizador a decidir o tamanho do mapa em X e Y:

            // Console.WriteLine("Qual é o tamanho do mapa em X? ");
            // mapValueX = int.Parse(Console.ReadLine());
            // Console.WriteLine("Qual é o tamanho do mapa em Y? ");
            // mapValueY = int.Parse(Console.ReadLine());

            // Caso haja apenas um valor para X e Y:
            mapValueX = 1000;
            mapValueY = mapValueX;

            // O player começa em 0, 0 :D
            int playerX = 0;
            int playerY = 0;
            Console.WriteLine("O mapa será de {0} por {1}.", mapValueX, mapValueY);
            Thread.Sleep(300);

            Console.WriteLine("\nO personagem está na posição\nX: 0\nY: 0");
            Thread.Sleep(300);
            Console.Clear();

            Console.WriteLine("\nA gerar o mapa...\n");
            t.InitTiles(mapValueX, mapValueY);

            Console.WriteLine("\nW, A, S ou D.\nPara onde você deseja movimentar o personagem?");


            // Há um pequeno bug cada vez que eu pressiono uma tecla! Ela aparece, ao invés de não aparecer.
            // E eu não sei como consertar.

            // Do-While para utilizar ConsoleKeys
            do
            {
                targetPos = Console.ReadKey(true);
                Console.WriteLine(" ");
                switch (targetPos.Key)
                {
                    case ConsoleKey.D:
                        playerX++;
                        Console.WriteLine("Right - Posição X: {0} ", playerX);
                        Console.WriteLine();
                        break;

                    case ConsoleKey.A:
                        playerX--;
                        Console.WriteLine("Left - Posição X: {0} ", playerX);
                        Console.WriteLine();
                        break;

                    case ConsoleKey.S:
                        playerY--;
                        Console.WriteLine("Down - Posição Y: {0} ", playerY);
                        Console.WriteLine();
                        break;

                    case ConsoleKey.W:
                        playerY++;
                        Console.WriteLine("Up - Posição Y: {0} ", playerY);
                        Console.WriteLine();
                        break;

                    case ConsoleKey.Q:
                        Console.WriteLine("O jogador terminou em:\nPosição X: {0}\nPosição Y: {1}", playerX, playerY);
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine(targetPos.Key.ToString());
            } while (targetPos.Key != ConsoleKey.Escape);

            Thread.Sleep(12000);
        }
    }
}
