﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Pipes;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;

namespace Algoritmia
{
    class ExerciciosAlgoritmia
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
    }
}
